using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace ISTPET_PortalEstudiantil.Controllers
{
    [AuthorizeAlumnos]
    public class CuentaController : Controller
    {
        private readonly string cn;
        private readonly ISessionAlumnos _auth;
        private JsonSerializerSettings _loop_handler = new JsonSerializerSettings();
        public CuentaController(ISessionAlumnos auth, IConfiguration config)
        {
            cn = config.GetConnectionString("sigafi_es");
            _auth = auth;
            _loop_handler.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }
        [HttpGet]
        public async Task<string> datosPersonales()
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string idAlumno = _auth.get("idAlumno");
                string sql = @"select * from 
                               alumnos WHERE idAlumno=@idAlumno 
                               ";
                return JsonConvert.SerializeObject(
                    await dapper.QueryFirstOrDefaultAsync(sql, new { idAlumno }),
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
        [HttpPost]
        public async Task<string> cambiarPassword(alumnos _data)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string idAlumno = _auth.get("idAlumno");
                if (_data.idAlumno != idAlumno) throw new Exception("Sólo puede cambiar la contraseña de su sesión");
                string sql = @"UPDATE alumnos set password=@password WHERE idAlumno=@idAlumno
                               ";
                await dapper.ExecuteAsync(sql, _data);
                _auth.logoutSync();
                return "ok";
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
