using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Net;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class LoginController : Controller
    {
        private readonly string cn;
        private readonly ISessionAlumnos _auth;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly sigafi_esContext _context;

        public LoginController(IConfiguration config, ISessionAlumnos auth, IWebHostEnvironment webHostEnvironment, sigafi_esContext context)
        {
            cn = config.GetConnectionString("sigafi_es");
            _config = config;
            _auth = auth;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
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
                               idAlumno=@idAlumno";
                var alumno = await dapper.QueryFirstOrDefaultAsync<alumnos>(sql, _data);
                if (alumno == null) throw new Exception("El usuario ingresado no existe");
                if (alumno.password != _data.password) throw new Exception("La contraseña ingresada no es correcta");
                if (alumno.idAlumno == alumno.password) return "clave";
                _auth.set("idAlumno", alumno.idAlumno);
                _auth.set("usuario", alumno.idAlumno);
                _auth.set("alumno", $"{alumno.apellidoPaterno} {alumno.apellidoMaterno} {alumno.primerNombre} {alumno.segundoNombre}");
                _auth.set("email", alumno.email);
                _auth.set("email_institucional", alumno.email_institucional);
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

        [HttpPost]
        public async Task<string> cambiarPassword(alumnos _data)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
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

        [HttpGet]
        public async Task<string> logout()
        {
            await _auth.logoutAsync();
            return "ok";
        }

        [HttpPost]
        public async Task<string> recuperarClave(string usuarioRecuperar)
        {
            try
            {
                if (string.IsNullOrEmpty(usuarioRecuperar)) throw new Exception("Debe ingresar un usuario");
                if (!_context.alumnos.Any(x => x.idAlumno == usuarioRecuperar)) throw new Exception("El usuario ingresado no existe");
                var alumno = _context.alumnos.FirstOrDefault(x => x.idAlumno == usuarioRecuperar);
                EnviarCorreoRecuperacion(alumno);
                return "Todo belen";
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new { error = ex.Message });
            }
        }

        private void EnviarCorreoRecuperacion(alumnos alumno)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "correos", "RecuperarClave.html");
                StringBuilder emailHtml = new StringBuilder(System.IO.File.ReadAllText(path));
                AlternateView htmlimagen;
                emailHtml.Replace("@contenido", $"SU CONTRASEÑA DE INGRESO ES: <b>{alumno.password}</b>");
                htmlimagen = AlternateView.CreateAlternateViewFromString(emailHtml.ToString(), null, "text/html");
                MailMessage correo = new MailMessage();
                if (!string.IsNullOrEmpty(alumno.email)) correo.To.Add(alumno.email);
                if (!string.IsNullOrEmpty(alumno.email_institucional)) correo.To.Add(alumno.email_institucional);
                if (correo.To.Count == 0) throw new Exception("El usuario no tiene un correo registrado");
                correo.From = new MailAddress(_config["Sistema:email"]);
                correo.Subject = $"ISTPET: RECUPEAR CONTRASEÑA";
                correo.Body = emailHtml.ToString();
                correo.AlternateViews.Add(htmlimagen);
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.office365.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(_config["Sistema:email"], _config["Sistema:clave_email"]);
                smtp.Send(correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dapper.Dispose();
            }
        }
    }
}