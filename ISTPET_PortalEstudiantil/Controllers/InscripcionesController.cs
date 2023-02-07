using ISTPET_PortalEstudiantil.Models.sigafi_es;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class InscripcionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
//select distinct(c.idCarrera),c.Carrera
//from cursos n
//inner join carreras c on c.idCarrera = n.idCarrera
//inner join periodos_matriculas_niveles mn on mn.idNivel = n.idNivel
//inner join periodos p on p.idPeriodo = mn.idPeriodo
//where c.activa = 1
//and datediff(p.fecha_inicial, current_date()) >-100
    }
}
