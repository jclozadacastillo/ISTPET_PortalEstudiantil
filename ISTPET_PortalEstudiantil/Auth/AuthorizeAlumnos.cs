using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ISTPET_PortalEstudiantil.Auth
{
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorizeAlumnos : Attribute, IAuthorizationFilter
    {
        public string? Roles { get; set; }
        private AuthorizationFilterContext? _context;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _context = context;

            if (!verificarRol() || !verificarSesion())
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }
        private bool verificarSesion()
        {
            return !string.IsNullOrEmpty(get("idAlumno"));
        }
        private bool verificarRol()
        {
            if (string.IsNullOrEmpty(Roles)) return true;
            var sesion_roles = get("roles");
            if (string.IsNullOrEmpty(sesion_roles)) return false;
            var lista_roles_sesion = sesion_roles.Split(',');
            var lista_roles_requerido = Roles.Split(',');
            if (lista_roles_requerido.Count() == 0) return true;
            foreach (var item in lista_roles_sesion)
            {
                if (lista_roles_requerido.Contains(item)) return true;
            }
            return false;
        }

        public bool inRol(string _rol)
        {
            if (string.IsNullOrEmpty(Roles)) return true;
            var sesion_roles = get("roles");
            if (string.IsNullOrEmpty(sesion_roles)) return false;
            var lista_roles_sesion = sesion_roles.Split(',');
            return lista_roles_sesion.Contains(_rol);
        }

        public string get(string key)
        {
            try
            {
                var sesion = _context?.HttpContext.Session.GetString(key);
                if (string.IsNullOrEmpty(sesion)) throw new Exception("Key no encontada");
                return Convert.ToString(sesion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

    }
}
