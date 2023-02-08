using Dapper;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class InscripcionesController : Controller
    {
        private readonly string cn;
        private readonly string condicionPruebas="and datediff(p.fecha_inicial, current_date()) >-100";
        public InscripcionesController(IConfiguration config)
        {
            cn = config.GetConnectionString("sigafi_es");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> comboCarreras()
        {
            var dapper=new MySqlConnection(cn);
            try
            {
                string sql=$@"select distinct(c.idCarrera),c.Carrera
                            from cursos n
                            inner join carreras c on c.idCarrera = n.idCarrera
                            inner join periodos_matriculas_niveles mn on mn.idNivel = n.idNivel
                            inner join periodos p on p.idPeriodo = mn.idPeriodo
                            where c.activa = 1 and p.permiteMatricula=1
                            {condicionPruebas}";
                return Json(await dapper.QueryAsync(sql));
            }
            catch (Exception ex)
            {
                return Json(new{error=ex.Message});
            }
            finally
            {
                dapper.Dispose();
            }
        }
                [HttpPost]
        public async Task<IActionResult> comboSecciones(int idCarrera)
        {
            var dapper=new MySqlConnection(cn);
            try
            {
                string sql=$@"select distinct(s.idSeccion),s.seccion
                            from cursos n
                            inner join carreras c on c.idCarrera = n.idCarrera
                            inner join periodos_matriculas_niveles mn on mn.idNivel = n.idNivel
                            inner join periodos p on p.idPeriodo = mn.idPeriodo
                            inner join secciones s on s.idSeccion=mn.idSeccion
                            where c.activa = 1 and p.permiteMatricula=1 and c.idCarrera=@idCarrera 
                            {condicionPruebas}";
                return Json(await dapper.QueryAsync(sql,new{idCarrera}));
            }
            catch (Exception ex)
            {
                return Json(new{error=ex.Message});
            }
            finally
            {
                dapper.Dispose();
            }
        }

        [HttpPost]
        public async Task<IActionResult> comboPeriodos(int idCarrera,int idSeccion)
        {
            var dapper=new MySqlConnection(cn);
            try
            {
                string sql=$@"select distinct(p.idPeriodo),p.detalle,fecha_inicial
                            from cursos n
                            inner join carreras c on c.idCarrera = n.idCarrera
                            inner join periodos_matriculas_niveles mn on mn.idNivel = n.idNivel
                            inner join periodos p on p.idPeriodo = mn.idPeriodo
                            inner join secciones s on s.idSeccion=mn.idSeccion
                            where c.activa = 1 and p.permiteMatricula=1 and c.idCarrera=@idCarrera and s.idSeccion=@idSeccion
                            {condicionPruebas}
                            order by fecha_inicial";
                return Json(await dapper.QueryAsync(sql,new{idCarrera,idSeccion}));
            }
            catch (Exception ex)
            {
                return Json(new{error=ex.Message});
            }
            finally
            {
                dapper.Dispose();
            }
        }
    }
}
