using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class SistemaController : Controller
    {
        private readonly ISessionAlumnos _auth;
        private readonly string _cn;

        public SistemaController(ISessionAlumnos auth, IConfiguration config)
        {
            _auth = auth;
            _cn = config.GetConnectionString("sigafi_es") ?? string.Empty;
        }

        public IActionResult Index()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;
            return View();
        }

        public async Task<IActionResult> Calificaciones()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;

            using var dapper = new MySqlConnection(_cn);
            try
            {
                string usuario = _auth.getUser();
                string sqlCarreras = @"select distinct(idCarrera),Carrera from(
                                select m.idMatricula,c.idCarrera,c.Carrera
                                from matriculas m
                                inner join cursos n on n.idNivel = m.idNivel
                                inner join carreras c on c.idCarrera = n.idCarrera
                                where m.idAlumno = @usuario
                                order by idMatricula desc) t1";
                var carreras = await dapper.QueryAsync(sqlCarreras, new { usuario });
                ViewBag.Carreras = carreras;
            }
            catch
            {
                ViewBag.Carreras = Enumerable.Empty<dynamic>();
            }

            return View();
        }

        public async Task<IActionResult> Perfil()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;

            using var dapper = new MySqlConnection(_cn);
            try
            {
                string idAlumno = _auth.get("idAlumno");
                var alumno = await dapper.QueryFirstOrDefaultAsync<alumnos>(
                    "SELECT * FROM alumnos WHERE idAlumno = @idAlumno LIMIT 1",
                    new { idAlumno });
                return View(alumno);
            }
            catch
            {
                return View(new alumnos());
            }
        }

        public async Task<IActionResult> EditarPerfil()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;

            using var dapper = new MySqlConnection(_cn);
            try
            {
                string idAlumno = _auth.get("idAlumno");
                var alumno = await dapper.QueryFirstOrDefaultAsync<alumnos>(
                    "SELECT * FROM alumnos WHERE idAlumno = @idAlumno LIMIT 1",
                    new { idAlumno });

                var permiteActualizacion = (await dapper.QueryFirstOrDefaultAsync<int?>(
                    "SELECT permiteActualizacionCompleta FROM parametros WHERE activo = 1 LIMIT 1")) == 1;

                var etnias = permiteActualizacion
                    ? await dapper.QueryAsync<etnias>("SELECT idEtnia, etnia FROM etnias ORDER BY etnia")
                    : Enumerable.Empty<etnias>();

                ViewBag.PermiteActualizacion = permiteActualizacion;
                ViewBag.Etnias = etnias;
                return View(alumno);
            }
            catch
            {
                ViewBag.PermiteActualizacion = false;
                ViewBag.Etnias = Enumerable.Empty<etnias>();
                return View(new alumnos());
            }
        }

        public async Task<IActionResult> EvaluacionDocente()
        {
            var acceso = ValidarAcceso(validarEvaluaciones: true);
            if (acceso != null) return acceso;

            using var dapper = new MySqlConnection(_cn);
            try
            {
                string usuario = _auth.getUser();
                string sql = @"
                    select distinct(m.idMatricula),c.Carrera,n.Nivel,
                    s.seccion,mo.modalidad 
                    from matriculas m
                    inner join periodos p on p.idPeriodo = m.idPeriodo
                    INNER JOIN cursos n ON n.idNivel= m.idNivel 
                    INNER JOIN carreras c ON c.idCarrera=n.idCarrera 
                    INNER JOIN secciones s ON s.idSeccion = m.idSeccion 
                    INNER JOIN modalidades mo ON mo.idModalidad = m.idModalidad 
                    where p.activo = 1 and p.permiteCalificacionesInstituto = 1
                    and m.idAlumno = @usuario
                    GROUP BY m.idMatricula,c.Carrera,n.Nivel,s.seccion,mo.modalidad";
                var matriculas = await dapper.QueryAsync(sql, new { usuario });
                ViewBag.Matriculas = matriculas;
            }
            catch
            {
                ViewBag.Matriculas = Enumerable.Empty<dynamic>();
            }

            return View();
        }

        private IActionResult? ValidarAcceso(bool validarEvaluaciones = false)
        {
            if (!_auth.isLogged()) return RedirectToAction("Index", "Login");
            if (_auth.terminosCondicionesPendientes())
            {
                _auth.logoutSync();
                return RedirectToAction("Index", "Login");
            }
            if (validarEvaluaciones && _auth.evaluacionesPendientes() == 0) return RedirectToAction("Index", "Login");

            return null;
        }
    }
}
