using ISTPET_PortalEstudiantil.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ISTPET_PortalEstudiantil.Controllers
{
    public class SistemaController : Controller
    {
        private readonly ISessionAlumnos _auth;
        public SistemaController(ISessionAlumnos auth)
        {
            _auth = auth;
        }
        public IActionResult Index()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;
            return View();
        }

        public IActionResult Calificaciones()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;
            return View();
        }

        public IActionResult Perfil()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;
            return View();
        }
        public IActionResult EditarPerfil()
        {
            var acceso = ValidarAcceso();
            if (acceso != null) return acceso;
            return View();
        }
        public IActionResult EvaluacionDocente()
        {
            var acceso = ValidarAcceso(validarEvaluaciones: true);
            if (acceso != null) return acceso;
            return View();
        }

        private IActionResult? ValidarAcceso(bool validarEvaluaciones = false)
        {
            if (!_auth.isLogged()) return RedirectToAction("Index", "Login");
            if (_auth.terminosCondicionesPendientes())
            {
                _auth.logoutSync();
                return RedirectToAction("Index", "Login");
            }
            if (validarEvaluaciones && _auth.evaluacionesPendientes() == 0) return RedirectToAction("Index", "Login");

            return null;
        }

    }
}
