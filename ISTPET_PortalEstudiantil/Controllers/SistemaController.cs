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
            if (!_auth.isLogged()) return RedirectToAction("Index", "Login");
            return View();
        }

        public IActionResult Calificaciones()
        {
            if (!_auth.isLogged()) return RedirectToAction("Index", "Login");
            return View();
        }

        public IActionResult Perfil()
        {
            if (!_auth.isLogged()) return RedirectToAction("Index", "Login");
            return View();
        }
        public IActionResult EditarPerfil()
        {
            if (!_auth.isLogged()) return RedirectToAction("Index", "Login");
            return View();
        }
        public IActionResult EvaluacionDocente()
        {
            if (!_auth.isLogged() || _auth.evaluacionesPendientes()==0) return RedirectToAction("Index", "Login");
            return View();
        }

    }
}
