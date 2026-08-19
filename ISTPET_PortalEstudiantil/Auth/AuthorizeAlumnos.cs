using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ISTPET_PortalEstudiantil.Auth
{
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorizeAlumnos : Attribute, IAuthorizationFilter
    {
        public string? Roles { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var session = context.HttpContext.Session;

            if (!verificarSesion(session) || !verificarRol(session))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }

        private bool verificarSesion(ISession? session)
        {
            return !string.IsNullOrEmpty(get(session, "idAlumno"));
        }

        private bool verificarRol(ISession? session)
        {
            if (string.IsNullOrEmpty(Roles)) return true;
            var sesion_roles = get(session, "roles");
            if (string.IsNullOrEmpty(sesion_roles)) return false;
            var lista_roles_sesion = sesion_roles.Split(',');
            var lista_roles_requerido = Roles.Split(',');
            if (lista_roles_requerido.Length == 0) return true;
            foreach (var item in lista_roles_sesion)
            {
                if (lista_roles_requerido.Contains(item.Trim())) return true;
            }
            return false;
        }

        private string get(ISession? session, string key)
        {
            return session?.GetString(key) ?? string.Empty;
        }
    }
}
