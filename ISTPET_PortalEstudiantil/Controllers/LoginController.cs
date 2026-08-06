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
        private const string SistemaAceptacion = "Portal Estudiantil";
        private readonly string cn;
        private readonly ISessionAlumnos _auth;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly sigafi_esContext _context;

        public LoginController(IConfiguration config, ISessionAlumnos auth, IWebHostEnvironment webHostEnvironment, sigafi_esContext context)
        {
            cn = config.GetConnectionString("sigafi_es") ?? string.Empty;
            _config = config;
            _auth = auth;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            if (_auth.isLogged())
            {
                if (_auth.terminosCondicionesPendientes())
                {
                    _auth.logoutSync();
                    return View();
                }
                return RedirectToAction("Index", "Sistema");
            }
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
                _auth.set("email", alumno.email ?? string.Empty);
                _auth.set("email_institucional", alumno.email_institucional ?? string.Empty);
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
        public async Task<IActionResult> terminoVigentePendiente()
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                if (!_auth.isLogged()) throw new Exception("Su sesión ha caducado");

                var termino = await ObtenerTerminoPendienteAsync(dapper, _auth.getUser());
                if (termino == null) return Json(new { requiereAceptar = false });

                return Json(new
                {
                    requiereAceptar = true,
                    termino.idTermino,
                    termino.versionTermino,
                    termino.fechaPublicacion,
                    termino.archivoHtml,
                    archivoHtmlUrl = Url.Action(nameof(archivoTermino), "Login", new { idTermino = termino.idTermino, v = termino.versionTermino })
                });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
            finally
            {
                dapper.Dispose();
            }
        }

        [HttpGet]
        public async Task<IActionResult> archivoTermino(int idTermino)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                var termino = await dapper.QueryFirstOrDefaultAsync<TerminoCondicion>(@"
                    SELECT idTermino, versionTermino, contenido, fechaPublicacion, archivoHtml
                    FROM pd_terminos_Condiciones
                    WHERE idTermino = @idTermino", new { idTermino });

                if (termino == null) return NotFound("No se encontro el termino solicitado");

                if (!string.IsNullOrEmpty(termino.contenido))
                {
                    return Content(termino.contenido, "text/html", Encoding.UTF8);
                }

                var contenido = string.IsNullOrWhiteSpace(termino.contenido)
                    ? "<p>No se encontro contenido para los terminos y condiciones vigentes.</p>"
                    : termino.contenido;

                return Content(contenido, "text/html", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                return Content($"<p>{WebUtility.HtmlEncode(ex.Message)}</p>", "text/html", Encoding.UTF8);
            }
            finally
            {
                dapper.Dispose();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> aceptarTerminos(int idTermino, string? datosDispositivo)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                if (!_auth.isLogged()) throw new Exception("Su sesión ha caducado");

                var idTerminoVigente = await ObtenerIdTerminoVigenteAsync(dapper);
                if (idTerminoVigente == null) throw new Exception("No existe un termino vigente para aceptar");
                if (idTerminoVigente != idTermino)
                {
                    throw new Exception("Los terminos y condiciones cambiaron. Vuelva a iniciar sesion.");
                }

                var idUsuario = _auth.getUser();
                var existe = await dapper.ExecuteScalarAsync<int>(@"
                    SELECT COUNT(1)
                    FROM pd_aceptaciones_usuarios
                    WHERE idUsuario = @idUsuario
                    LIMIT 1", new { idUsuario });

                if (existe == 0)
                {
                    await dapper.ExecuteAsync(@"
                        INSERT INTO pd_aceptaciones_usuarios
                        (idUsuario, idTermino, sistema, fechaRegistro, ipOrigen, dispositivo)
                        VALUES
                        (@idUsuario, @idTermino, @sistema, NOW(), @ipOrigen, @dispositivo)",
                        new
                        {
                            idUsuario,
                            idTermino,
                            sistema = SistemaAceptacion,
                            ipOrigen = ObtenerIpOrigen(),
                            dispositivo = ObtenerDispositivo(datosDispositivo)
                        });
                }

                return "ok";
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(new { error = ex.Message });
            }
            finally
            {
                dapper.Dispose();
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

        private static async Task<TerminoCondicion?> ObtenerTerminoPendienteAsync(MySqlConnection dapper, string idUsuario)
        {
            return await dapper.QueryFirstOrDefaultAsync<TerminoCondicion>(@"
                SELECT t.idTermino, t.idCategoria, t.versionTermino, t.contenido, t.fechaPublicacion, t.archivoHtml
                FROM pd_terminos_condiciones t
                INNER JOIN pd_categorias_terminos_condiciones c ON c.idCategoria = t.idCategoria
                WHERE t.esVigente = 1
                AND c.activo = 1
                AND c.esAlumno = 1
                AND NOT EXISTS (
                    SELECT 1
                    FROM pd_aceptaciones_usuarios au
                    WHERE au.idUsuario = @idUsuario
                )
                ORDER BY t.fechaPublicacion DESC, t.idTermino DESC
                LIMIT 1", new { idUsuario });
        }

        private static async Task<int?> ObtenerIdTerminoVigenteAsync(MySqlConnection dapper)
        {
            return await dapper.ExecuteScalarAsync<int?>(@"
                SELECT idTermino
                FROM pd_terminos_condiciones t
                INNER JOIN pd_categorias_terminos_condiciones c ON c.idCategoria = t.idCategoria
                WHERE t.esVigente = 1
                AND c.activo = 1
                AND c.esAlumno = 1
                ORDER BY t.fechaPublicacion DESC, t.idTermino DESC
                LIMIT 1");
        }

        private string? ConstruirUrlArchivoExterno(string? archivoHtml)
        {
            if (string.IsNullOrWhiteSpace(archivoHtml)) return null;
            if (EsUrlHttp(archivoHtml)) return archivoHtml;

            var baseUrl = _config["TerminosCondiciones:baseUrl"];
            if (!EsUrlHttp(baseUrl)) return null;

            var baseConSeparador = baseUrl!.EndsWith("/") ? baseUrl : $"{baseUrl}/";
            return new Uri(new Uri(baseConSeparador), archivoHtml).ToString();
        }

        private static bool EsUrlHttp(string? valor)
        {
            return Uri.TryCreate(valor, UriKind.Absolute, out var uri)
                && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
        }

        private string? LeerArchivoTermino(string? archivoHtml)
        {
            if (string.IsNullOrWhiteSpace(archivoHtml)) return null;

            var basePath = _config["TerminosCondiciones:baseUrl"];
            if (string.IsNullOrWhiteSpace(basePath) || EsUrlHttp(basePath)) return null;

            var rutaBase = Path.GetFullPath(basePath);
            var rutaArchivo = Path.GetFullPath(Path.Combine(rutaBase, archivoHtml));
            var rutaBaseConSeparador = rutaBase.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                + Path.DirectorySeparatorChar;

            if (!rutaArchivo.StartsWith(rutaBaseConSeparador, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("El archivo de terminos no pertenece a la ruta base configurada");
            }

            return System.IO.File.Exists(rutaArchivo)
                ? System.IO.File.ReadAllText(rutaArchivo, Encoding.UTF8)
                : null;
        }

        private string ObtenerIpOrigen()
        {
            var forwardedFor = Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(forwardedFor))
            {
                return forwardedFor.Split(',')[0].Trim();
            }

            return HttpContext.Connection.RemoteIpAddress?.ToString() ?? "";
        }

        private string ObtenerDispositivo(string? datosDispositivo)
        {
            var partes = new List<string>();
            AgregarParteDispositivo(partes, "UA", Request.Headers.UserAgent.ToString());
            AgregarParteDispositivo(partes, "Lang", Request.Headers.AcceptLanguage.ToString());
            AgregarParteDispositivo(partes, "Host", Request.Headers.Host.ToString());
            AgregarParteDispositivo(partes, "Ref", Request.Headers.Referer.ToString());
            AgregarParteDispositivo(partes, "XFwd", Request.Headers["X-Forwarded-For"].ToString());
            AgregarParteDispositivo(partes, "Client", datosDispositivo);

            var dispositivo = string.Join(" | ", partes);
            return dispositivo.Length <= 200 ? dispositivo : dispositivo[..200];
        }

        private static void AgregarParteDispositivo(List<string> partes, string etiqueta, string? valor)
        {
            if (!string.IsNullOrWhiteSpace(valor))
            {
                partes.Add($"{etiqueta}: {valor.Trim()}");
            }
        }

        private class TerminoCondicion
        {
            public int idTermino { get; set; }
            public int? idCategoria { get; set; }
            public string? versionTermino { get; set; }
            public string? contenido { get; set; }
            public DateTime? fechaPublicacion { get; set; }
            public string? archivoHtml { get; set; }
        }
    }
}