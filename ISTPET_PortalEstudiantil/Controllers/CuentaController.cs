using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using ISTPET_PortalEstudiantil.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly sigafi_esContext _context;
        private string rootPath;
        public CuentaController(ISessionAlumnos auth, IConfiguration config,sigafi_esContext context,IWebHostEnvironment env)
        {
            rootPath = env.WebRootPath;
            cn = config.GetConnectionString("sigafi_es");
            _auth = auth;
            _loop_handler.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            _context = context;
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

        [HttpGet]
        public async Task<IActionResult> verificarActualizacionDisponible()
        {
            try
            {
                var disponible = (await _context.parametros.Where(x=>x.activo==1).FirstOrDefaultAsync())?.permiteActualizacionCompleta == 1;
                return Ok(disponible);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
  
        }

        [HttpGet]
        public async Task<IActionResult> DatosAlumno()
        {
            try
            {
                var idAlumno = _auth.get("idAlumno");
                var alumno = await _context.alumnos.Where(x => x.idAlumno == idAlumno).FirstOrDefaultAsync();
                return Ok(alumno);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> ListaEtnias()
        {
            try
            {
                var etnias = await _context.etnias.ToListAsync();
                return Ok(etnias);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        public class AlumnoDto
        {
            public string idAlumno { get; set; } = null!;
            public string? direccion { get; set; }
            public string? email { get; set; }
            public string? telefono { get; set; }
            public string? celular { get; set; }
            public int? idEtnia { get; set; }
            public IFormFile? foto { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> GuardarCambios([FromForm] AlumnoDto updatedAlumno)
        {
            try
            {
                var idAlumno = _auth.get("idAlumno");
                var alumno = await _context.alumnos.FirstOrDefaultAsync(x => x.idAlumno == idAlumno);

                if (alumno == null)
                {
                    return NotFound("Alumno no encontrado.");
                }

                alumno.direccion = updatedAlumno.direccion;
                alumno.email = updatedAlumno.email;
                alumno.telefono = updatedAlumno.telefono;
                alumno.celular = updatedAlumno.celular;
                alumno.idEtnia = updatedAlumno.idEtnia;

                if (updatedAlumno.foto != null && updatedAlumno.foto.Length > 0)
                {
                    var folderPath = Path.Combine(rootPath, "alumnos", idAlumno);
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    var fileExtension = Path.GetExtension(updatedAlumno.foto.FileName);

                    var fileName = $"foto_perfil{fileExtension}";
                    var filePath = Path.Combine(folderPath, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await updatedAlumno.foto.CopyToAsync(fileStream);
                    }

                    alumno.archivoFoto = Path.Combine("alumnos", idAlumno, fileName).Replace("\\", "/");
                }

                _context.alumnos.Update(alumno);
                await _context.SaveChangesAsync();

                return Ok("Datos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                return Problem($"Error al guardar cambios: {ex.Message}");
            }
        }


    }
}
