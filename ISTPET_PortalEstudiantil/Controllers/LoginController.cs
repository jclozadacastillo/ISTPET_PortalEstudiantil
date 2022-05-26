using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class LoginController : Controller
    {
        private readonly string cn;
        private readonly ISessionAlumnos _auth;
        public LoginController(IConfiguration config,ISessionAlumnos auth)
        {
           cn=config.GetConnectionString("sigafi_es");
           _auth=auth;
        }
        public IActionResult Index()
        {
            if (_auth.isLogged()) return RedirectToAction("Index", "Sistema");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> login(alumnos _data)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = @"SELECT * FROM alumnos where
                               idAlumno=@idAlumno and password=@password   
                              ";
                var alumno = await dapper.QueryFirstOrDefaultAsync<alumnos>(sql, _data);
                if (alumno == null) throw new Exception("Usuario y/o contraseña incorrectos");
                _auth.set("idAlumno", alumno.idAlumno);
                _auth.set("usuario", alumno.idAlumno);
                _auth.set("alumno", $"{alumno.apellidoPaterno} {alumno.apellidoMaterno} {alumno.primerNombre} {alumno.segundoNombre}");
                _auth.set("email", alumno.email);
                _auth.set("email_institucional", alumno.email_institucional);
                return JsonConvert.SerializeObject(alumno);
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
