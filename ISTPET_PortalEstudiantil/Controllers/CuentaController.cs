using Dapper;
using ISTPET_PortalEstudiantil.Auth;
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

        public async Task<string> datosPersonales(){
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

    }
}
