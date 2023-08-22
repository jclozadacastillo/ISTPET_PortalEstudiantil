using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using static Dapper.SqlMapper;

namespace ISTPET_PortalEstudiantil.Controllers
{
    [AuthorizeAlumnos]
    public class EvaluacionDocenteController : Controller
    {
        private readonly string _cn;
        private readonly ISessionAlumnos _auth;
        private JsonSerializerSettings _loop_handler = new JsonSerializerSettings();
        private readonly sigafi_esContext _context;
        public EvaluacionDocenteController(ISessionAlumnos auth, IConfiguration config,sigafi_esContext context)
        {
            _cn = config.GetConnectionString("sigafi_es");
            _auth = auth;
            _loop_handler.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            _context = context;
        }
        public async Task<IActionResult> comboCarreras()
        {
            var usuario = _auth.getUser();
            var dapper = new MySqlConnection(_cn);
            try
            {
                string sql = @"
                                select distinct(idMatricula),c.Carrera,n.Nivel,
                                s.seccion,mo.modalidad 
                                from matriculas m
                                inner join periodos p on p.idPeriodo = m.idPeriodo
                                INNER JOIN cursos n ON n.idNivel= m.idNivel 
                                INNER JOIN carreras c ON c.idCarrera=n.idCarrera 
                                INNER JOIN secciones s ON s.idSeccion = m.idSeccion 
                                INNER JOIN modalidades mo ON mo.idModalidad = m.idModalidad 
                                where p.activo = 1 and p.permiteCalificacionesInstituto = 1
                                and idAlumno = @usuario
                                GROUP BY idMatricula,Carrera,Nivel,seccion,modalidad
                                ";
                return Ok(await dapper.QueryAsync(sql, new { usuario }));
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
            finally
            {
                dapper.Dispose();
            }
        }

        [HttpPost]
        public async Task<IActionResult> comboAsignaturas(int idMatricula)
        {
            var dapper = new MySqlConnection(_cn);
            try
            {
                string sql = @"select m.idmatricula,concat(apellidopaterno,' ',apellidomaterno,' ',primernombre,' ',segundonombre) alumno,
                            ag.asignatura, p.idPeriodo, ap.idAsignacion, m.idMatricula
                            from alumnos a 
                            inner join matriculas m on a.idalumno=m.idalumno 
                            inner join calificaciones c on m.idmatricula=c.idmatricula
                            inner join asignaturas ag on ag.idAsignatura = c.idAsignatura
                            inner join periodos p on p.idPeriodo = m.idPeriodo
                            inner join asignaciones_profesores ap 
                            on ap.idPeriodo = p.idPeriodo and ap.idAsignatura = ag.idAsignatura and ap.idnivel = m.idNivel and ap.idseccion = m.idSeccion
                            and ap.paralelo = m.paralelo and ap.idModalidad = m.idModalidad and ap.activo = '1'
                            where m.idMatricula = @idMatricula
                            and p.activo = 1 and p.permiteCalificacionesInstituto = 1
                            and idAsignacion not in(select sh.idAsignacion from seddheteroevaluacion sh
                            WHERE sh.idMatricula=@idMatricula)
                            ";
                return Ok(await dapper.QueryAsync(sql, new { idMatricula }));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
            finally
            {
                dapper?.Dispose();
            }
        }

        public async Task<IActionResult> cargarEvaluacion()
        {
            var dapper = new MySqlConnection(_cn);
            try
            {
                string sql = @"select idInstrumento from SeddInstrumentos where activo = 1 and idCategoria = 1 and codigo = 'F2'";
                var idInstrumento=await dapper.ExecuteScalarAsync<int?>(sql);
                if (idInstrumento == null) throw new Exception("Aún no se ha configurado el instrumento.");
                sql = @"select * from seddinstrumentospreguntas sip
                               inner join seddpreguntas sp on sp.idPregunta = sip.idPregunta
                               inner join seddinstrumentos si on si.idInstrumento = sip.idInstrumento
                               where sip.activo = 1 and sp.activo = 1 and si.activo = 1
                               and si.idInstrumento = @idInstrumento";
                return Ok(await dapper.QueryAsync(sql, new { idInstrumento }));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
            finally
            {
                dapper.Dispose();
            }
        }

        public async Task<IActionResult> guardar(seddheteroevaluacion form, string arrayEvaluacion)
        {
            try
            {

                var detalle = JsonConvert.DeserializeObject<List<sedddetalleheteroevaluacion>>(arrayEvaluacion);
                form.fechaRegistro = DateTime.Now;
                form.sedddetalleheteroevaluacion = detalle;
                _context.seddheteroevaluacion.Add(form);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }


    }
}
