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
    }
}
