using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace ISTPET_PortalEstudiantil.Controllers
{
    [AuthorizeAlumnos]
    public class CalificacionesController : Controller
    {
        private readonly string cn;
        private readonly ISessionAlumnos _auth;
        private JsonSerializerSettings _loop_handler = new JsonSerializerSettings();
        public CalificacionesController(ISessionAlumnos auth, IConfiguration config)
        {
            cn = config.GetConnectionString("sigafi_es");
            _auth = auth;
            _loop_handler.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }

        public async Task<string> comboCarreras()
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string usuario = _auth.getUser();
                string sql = @"select distinct(c.idCarrera),c.Carrera
                                from matriculas m
                                inner join cursos n on n.idNivel = m.idNivel
                                inner join carreras c on c.idCarrera = n.idCarrera
                                where m.idAlumno =@usuario
                                order by m.idMatricula desc;
                                ";

                return JsonConvert.SerializeObject(
                    await dapper.QueryAsync(sql, new { usuario })
                    );
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new { error = ex.Message });
            }
            finally
            {
                dapper?.Dispose();
            }
        }
        [HttpPost]
        public async Task<string> comboNiveles(int idCarrera)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string usuario = _auth.getUser();
                string sql = @"select m.idMatricula,concat(n.Nivel,' - (',p.detalle,')') as nivel
                               from matriculas m
                               inner join cursos n on n.idNivel = m.idNivel
                               inner join carreras c on c.idCarrera = n.idCarrera
                               inner join periodos p on p.idPeriodo = m.idPeriodo
                               where m.idAlumno =@usuario and n.idCarrera = @idCarrera
                               order by idMatricula desc;
                               ";
                return JsonConvert.SerializeObject(
                    await dapper.QueryAsync(sql, new { usuario, idCarrera })
                    );
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new { error = ex.Message });
            }
            finally
            {
                dapper?.Dispose();
            }
        }

        [HttpPost]
        public async Task<string> listaNotas(int idMatricula)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string usuario = _auth.getUser();
                string sql = @"select * from 
                               calificaciones c 
                               inner join asignaturas a on a.idAsignatura = c.idAsignatura 
                               where idMatricula =@idMatricula
                               order by a.asignatura;
                               ";
                return JsonConvert.SerializeObject(
                    await dapper.QueryAsync(sql, new { usuario, idMatricula }),
                    _loop_handler
                    );
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new { error = ex.Message });
            }
            finally
            {
                dapper?.Dispose();
            }
        }
    }
}