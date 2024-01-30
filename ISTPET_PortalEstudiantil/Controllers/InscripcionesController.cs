using Dapper;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Drawing;
using ISTPET_PortalEstudiantil.Utilities;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class InscripcionesController : Controller
    {
        private readonly string cn;
        private readonly string condicionPruebas = "and datediff(p.fecha_inicial, current_date()) >-100";
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _config;
        public InscripcionesController(IConfiguration config, IWebHostEnvironment webHost)
        {
            _config = config;
            cn = config.GetConnectionString("sigafi_es");
            _webHostEnvironment = webHost;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirmacion(string id, string dni, string e)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = @"SELECT ai.*, 
                TIMESTAMPDIFF(month,fechaRegistro,current_date) as mesesPasado 
                FROM alumnos_inscripciones ai
                INNER JOIN alumnos a on a.idAlumno=ai.idAlumno
                WHERE ai.idInscripcion=@id AND ai.idAlumno=@dni AND a.email=@e";
                var inscripcion = dapper.QueryFirstOrDefault(sql, new { id, dni, e });
                var mensaje = "";
                if (inscripcion == null)
                {
                    ViewData["clase"] = "alert alert-info";
                    mensaje = @"<div class='text-center'><i class='bi-info-circle fs-1 mb-2'></i></div>
                                <div class='text-center'>
                                    No hemos encontrado lo que buscas
                                </div>
                            ";
                    ViewData["mensaje"] = mensaje;
                    return View();
                }
                if (inscripcion != null && Convert.ToBoolean(inscripcion?.activo) == false && inscripcion?.mesesPasado <= 0)
                {
                    sql = @"UPDATE alumnos_inscripciones SET activo=1 WHERE idInscripcion=@id;";
                    dapper.Execute(sql, new { id,dni });
                    ViewData["clase"] = "alert alert-success";
                    mensaje = @"<div class='text-center'><i class='bi-check-circle fs-1 mb-2'></i></div>
                                <div class='text-center'>
                                    Inscripción validada exitosamente
                                </div>
                            ";
                    ViewData["mensaje"] = mensaje;
                    enviarCorreoNuevaInscripcion(id);
                    return View();
                }

                if (inscripcion != null && Convert.ToBoolean(inscripcion?.activo) == true)
                {
                    ViewData["clase"] = "alert alert-success";
                    mensaje = @"<div class='text-center'><i class='bi-check-circle fs-1 mb-2'></i></div>
                                <div class='text-center'>
                                    Esta inscripción ya ha sido validada anteriormente.
                                </div>
                            ";
                    ViewData["mensaje"] = mensaje;
                    return View();
                }
                if (inscripcion != null && Convert.ToBoolean(inscripcion?.activo) == false && inscripcion?.mesesPasado > 0)
                {
                    ViewData["clase"] = "alert alert-warning";
                    mensaje = @"<div class='text-center'><i class='bi-exclamation-triangle fs-1 mb-2'></i></div>
                                <div class='text-center'>
                                    Lo sentimos su link de inscripción ha sido caducado.
                                    Debe repetir su proceso de inscripción.
                                </div>
                            ";
                    ViewData["mensaje"] = mensaje;
                    return View();
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewData["mensaje"] = ex.Message;
                ViewData["clase"] = "alert alert-danger";
                return View();
            }
            finally
            {

            }


        }

        private bool enviarCorreoNuevaInscripcion(string idInscripcion)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                var sql = @"SELECT concat('(',p.idPeriodo,') ',p.detalle) AS periodo,
                            c.Carrera as carrera,m.modalidad,s.seccion,a.idAlumno,
                            concat(a.primerNombre,' ',a.segundoNombre,' ',a.apellidoPaterno,' ',a.apellidoMaterno) AS alumno,
                            a.celular,a.telefono,a.email,p.idPeriodo
                            FROM alumnos_inscripciones ai 
                            INNER JOIN alumnos a ON a.idAlumno =ai.idalumno 
                            INNER JOIN periodos p ON p.idPeriodo = ai.idPeriodo 
                            INNER JOIN modalidades m ON m.idModalidad = ai.idModalidad 
                            INNER JOIN cursos n ON n.idNivel =ai.idNivel 
                            INNER JOIN carreras c ON c.idCarrera = n.idCarrera 
                            INNER JOIN secciones s ON s.idSeccion = ai.idSeccion 
                            WHERE idInscripcion =@idInscripcion";
                var _datos = dapper.QueryFirstOrDefault(sql, new {idInscripcion});
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "correos", "nuevaInscripcion.html");
                StringBuilder emailHtml = new StringBuilder(System.IO.File.ReadAllText(path));
                emailHtml.Replace("@alumno", _datos.alumno);
                emailHtml.Replace("@carrera", _datos.carrera);
                emailHtml.Replace("@periodo", _datos.periodo);
                emailHtml.Replace("@seccion", _datos.seccion);
                emailHtml.Replace("@modalidad", _datos.modalidad);
                emailHtml.Replace("@idAlumno", _datos.idAlumno);
                emailHtml.Replace("@telefono", _datos.telefono);
                emailHtml.Replace("@celular", _datos.celular);
                emailHtml.Replace("@email", _datos.email);
                AlternateView htmlimagen;
                htmlimagen = AlternateView.CreateAlternateViewFromString(emailHtml.ToString(), null, "text/html");
                MailMessage correo = new MailMessage();
                correo.To.Add(_config["Sistema:email_admisiones"]);
                correo.From = new MailAddress(_config["Sistema:email"]);
                correo.Subject = $"ISTPET: NUEVA INSCRIPCIÓN {_datos.carrera} {_datos.idPeriodo}";
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
                //dapper.Execute(sql, new { emailNotificacion = docente.emailInstitucion, idReservacion });
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                dapper.Dispose();
            }
        }

        [HttpPost]
        public async Task<IActionResult> comboCarreras(bool conduccion)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"select distinct(c.idCarrera),c.Carrera,n.nivel,n.idNivel
                                from periodos_inscripciones pi 
                                inner join cursos n on n.idNivel = pi.idNivel
                                inner join carreras c on c.idCarrera = n.idCarrera
                                inner join periodos p on p.idPeriodo = pi.idPeriodo
                                where pi.activo=1 and conduccion =@conduccion 
                                and datediff(pi.fechaFinal,pi.fechaInicio) > 0";
                return Json(await dapper.QueryAsync(sql, new { conduccion }));
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

        [HttpPost]
        public async Task<IActionResult> comboSecciones(int idNivel)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"select distinct(s.idSeccion),s.seccion
                                from periodos_inscripciones pi 
                                inner join cursos n on n.idNivel = pi.idNivel
                                inner join carreras c on c.idCarrera = n.idCarrera
                                inner join periodos p on p.idPeriodo = pi.idPeriodo
                                inner join secciones s on s.idSeccion=pi.idSeccion
                                where pi.activo=1 and pi.idNivel = @idNivel 
                                and datediff(pi.fechaFinal,pi.fechaInicio) > 0";
                return Json(await dapper.QueryAsync(sql, new { idNivel }));
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

        [HttpPost]
        public async Task<IActionResult> comboModalidades(int idNivel, int idSeccion)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"select distinct(m.idModalidad),m.modalidad
                                from periodos_inscripciones pi 
                                inner join cursos n on n.idNivel = pi.idNivel
                                inner join carreras c on c.idCarrera = n.idCarrera
                                inner join periodos p on p.idPeriodo = pi.idPeriodo
                                inner join secciones s on s.idSeccion=pi.idSeccion
                                inner join modalidades m on m.idModalidad=pi.idModalidad
                                where pi.activo=1 and pi.idNivel = @idNivel and pi.idSeccion=@idSeccion
                                and datediff(pi.fechaFinal,pi.fechaInicio) > 0";
                return Json(await dapper.QueryAsync(sql, new { idNivel, idSeccion }));
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

        [HttpPost]
        public async Task<IActionResult> comboPeriodos(int idNivel, int idSeccion, int idModalidad)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"
                                select distinct(p.idPeriodo),p.detalle,p.fecha_inicial
                                from periodos_inscripciones pi 
                                inner join cursos n on n.idNivel = pi.idNivel
                                inner join carreras c on c.idCarrera = n.idCarrera
                                inner join periodos p on p.idPeriodo = pi.idPeriodo
                                inner join secciones s on s.idSeccion=pi.idSeccion
                                inner join modalidades m on m.idModalidad=pi.idModalidad
                                where pi.activo=1 and pi.idNivel = @idNivel and pi.idSeccion=@idSeccion 
                                and pi.idModalidad=@idModalidad
                                and datediff(pi.fechaFinal,pi.fechaInicio) > 0
                ";
                return Json(await dapper.QueryAsync(sql, new { idNivel, idSeccion, idModalidad }));
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
        public async Task<IActionResult> comboProvincias()
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"select distinct(provincia) 
                                from instituciones 
                                order by trim(provincia) ";
                return Json(await dapper.QueryAsync(sql));
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



        [HttpPost]
        public async Task<IActionResult> comboCiudades(string provincia)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"select distinct(ciudad) 
                                from instituciones 
                                where provincia=@provincia
                                order by trim(ciudad) ";
                return Json(await dapper.QueryAsync(sql, new { provincia }));
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


        [HttpPost]
        public async Task<IActionResult> comboInstituciones(string ciudad)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"select distinct(idInstitucion),institucion 
                                from instituciones 
                                where ciudad=@ciudad
                                order by trim(institucion) ";
                return Json(await dapper.QueryAsync(sql, new { ciudad }));
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
        public async Task<IActionResult> comboMedios()
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                string sql = $@"SELECT * FROM medios_contacto where activo=1";
                return Json(await dapper.QueryAsync(sql));
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

        [HttpPost]
        public async Task<IActionResult> guardar(alumnos _alumno, alumnos_inscripciones _inscripcion, DateTime fecha_Nacimiento)
        {
            var dapper = new MySqlConnection(cn);
            string novedades = "";
            _alumno.fecha_Inscripcion = fecha_Nacimiento;
            try
            {
                string sql = $@"SELECT count(idAlumno) FROM alumnos where idAlumno=@idAlumno";
                if (await dapper.ExecuteScalarAsync<int>(sql, _alumno) > 0)
                {
                    sql = @"UPDATE alumnos
                            SET telefono=@telefono, 
                            celular=@celular, 
                            email=@email,  
                            sexo=@sexo
                            WHERE idAlumno=@idAlumno;
                     ";
                    novedades += "Su documento de identidad se encontró en el sistema.</br>";
                }
                else
                {
                    sql = $@"
                    INSERT INTO alumnos
                    (idAlumno, tipoDocumento, apellidoPaterno, apellidoMaterno, primerNombre, segundoNombre, fecha_Nacimiento, 
                    telefono, celular, email, sexo, fecha_Inscripcion,idInstitucion,tituloColegio,password)
                    VALUES(@idAlumno, @tipoDocumento, @apellidoPaterno, @apellidoMaterno, @primerNombre, @segundoNombre, @fecha_Inscripcion, 
                    @telefono, @celular, @email, @sexo, current_date,@idInstitucion,@tituloColegio,@idAlumno);
                    ";
                    novedades += "Bienvenido a ISTPET.</br>";
                }
                await dapper.ExecuteAsync(sql, _alumno);
                sql = @"SELECT count(idAlumno) 
                FROM alumnos_inscripciones 
                WHERE idAlumno=@idAlumno and idPeriodo=@idPeriodo";
                if (await dapper.ExecuteScalarAsync<int>(sql, _inscripcion) > 0)
                {
                    sql = @"SELECT * FROM alumnos_inscripciones
                            WHERE idAlumno=@idAlumno and idPeriodo=@idPeriodo AND (activo is null or activo=0) LIMIT 1";
                    var inscripcion_pendiente = await dapper.QueryFirstOrDefaultAsync<alumnos_inscripciones>(sql, _inscripcion);
                    if (inscripcion_pendiente != null)
                    {
                        enviarCorreo(_alumno, inscripcion_pendiente);
                        throw new Exception($"Ya te encuentras inscrito revisa tú correo {_alumno.email} para validar tú inscripción");
                    }
                    else
                    {
                        throw new Exception("Ya te encuentras inscrito para el presente periodo");
                    }

          
                };
                sql = @"INSERT INTO alumnos_inscripciones
                    (idalumno, idPeriodo, idModalidad, idNivel, idSeccion, fechaRegistro, usuario, activo,idMedio)
                    VALUES(@idalumno, @idPeriodo, @idModalidad, @idNivel, @idSeccion, current_timestamp, 'root', 0,@idMedio);
                    SELECT LAST_INSERT_ID();
                    ";
                _inscripcion.idInscripcion = await dapper.ExecuteScalarAsync<int>(sql, _inscripcion);
                novedades += "Registro de inscripción realizado exitosamente.</br>";
                try
                {
                    if (enviarCorreo(_alumno, _inscripcion) == false) throw new Exception();
                    novedades += $"Se ha enviado un correo de confirmación a <b>{_alumno.email}</b>, confirma tú correo para validar tu inscripción";
                }
                catch (Exception exC)
                {
                    Console.WriteLine(exC.Message);
                    sql = "DELETE FROM alumnos_inscripciones WHERE idInscripcion=@idInscripcion";
                    await dapper.ExecuteAsync(sql, _inscripcion);
                    throw new Exception("Ha ocurrido un error al enviar su correo de confirmación intente nuevamente.");
                }
                return Ok(novedades);
            }
            catch (Exception ex)
            {
                //string sql = "DELETE FROM alumnos_inscripciones WHERE idInscripcion=@idInscripcion";
                //await dapper.ExecuteAsync(sql, _inscripcion);
                return Json(new { error = ex.Message });
            }
            finally
            {
                dapper.Dispose();
            }
        }

        private bool enviarCorreo(alumnos _datos, alumnos_inscripciones _inscripcion)
        {
            var dapper = new MySqlConnection(cn);
            try
            {
                var sql = @"select concat(a.primerNombre,' ',a.segundoNombre,' ',a.apellidoPaterno,' ',a.apellidoMaterno) as alumno,
                        nivel,carrera,detalle as periodo,modalidad,seccion
                        from alumnos_inscripciones ai
                        inner join alumnos a on a.idAlumno = ai.idalumno 
                        inner join cursos n on n.idNivel = ai.idNivel
                        inner join carreras c on c.idCarrera = n.idCarrera
                        inner join periodos p on p.idPeriodo = ai.idPeriodo
                        inner join secciones s on s.idSeccion=ai.idSeccion
                        inner join modalidades m on m.idModalidad=ai.idModalidad
                        where ai.idInscripcion = @idInscripcion";
                var datosInscripcion = dapper.QueryFirstOrDefault(sql, _inscripcion);
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "correos", "confirmacion.html");
                StringBuilder emailHtml = new StringBuilder(System.IO.File.ReadAllText(path));
                emailHtml.Replace("@urlSistema", $"https://servicios.istpet.edu.ec/appEstudiantes/Inscripciones/Confirmacion/?id={_inscripcion.idInscripcion}&dni={_datos.idAlumno}&e={_datos.email}");
                emailHtml.Replace("@alumno", datosInscripcion.alumno);
                emailHtml.Replace("@carrera ", datosInscripcion.carrera);
                emailHtml.Replace("@periodo", datosInscripcion.periodo);
                emailHtml.Replace("@seccion", datosInscripcion.seccion);
                emailHtml.Replace("@modalidad", datosInscripcion.modalidad);
                emailHtml.Replace("@idBtn", $"id='btn{DateTime.Now.Ticks}'");
                AlternateView htmlimagen;
                htmlimagen = AlternateView.CreateAlternateViewFromString(emailHtml.ToString(), null, "text/html");
                LinkedResource imagen;
                imagen = new LinkedResource(Path.Combine(_webHostEnvironment.WebRootPath, "templateInscripciones/img/logo.png"));
                imagen.ContentId = "logoBlanco";
                htmlimagen.LinkedResources.Add(imagen);
                MailMessage correo = new MailMessage();
                correo.To.Add(_datos.email);
                if (correo.To.Count == 0) throw new Exception("NO SE PUDIERON RECUPERAR LOS DATOS");
                correo.From = new MailAddress(_config["Sistema:email"]);
                correo.Subject = "ISTPET: CONFIRMACIÓN DE INSCRIPCIÓN";
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
                //dapper.Execute(sql, new { emailNotificacion = docente.emailInstitucion, idReservacion });
                return true;
            }
            catch (Exception ex)
            {
                //string sql = @"UPDATE Lab_Reservaciones
                //        SET
                //        emailNotificacion=@emailNotificacion,
                //        notificado=0
                //        WHERE idReservacion=@idReservacion";
                //dapper.Execute(sql, new { emailNotificacion = emailDocente, idReservacion });
                //Console.WriteLine(ex.Message);
                Tools.logError(ex);
                return false;
            }
            finally
            {
                dapper.Dispose();
            }
        }

        private string imagenBase64(string url)
        {
            var path = Path.Combine(_webHostEnvironment.WebRootPath, url);
            byte[] bytesImagen = System.IO.File.ReadAllBytes(path);
            string base64Imagen = Convert.ToBase64String(bytesImagen);
            return String.Format("data:image/jpg;base64,{0}", base64Imagen);
        }
        public string sistemaUrl(string url)
        {
            return Path.Combine(_webHostEnvironment.WebRootPath, url);
        }

        private string host() => new UriBuilder(Request.Scheme, Request.Host.Host, Request.Host.Port ?? -1).ToString();

    }
}
