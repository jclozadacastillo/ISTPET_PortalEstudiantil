namespace ISTPET_PortalEstudiantil.Auth
{
    public class SessionAlumnos : ISessionAlumnos
    {
        private readonly ISession _session;
        private readonly IHttpContextAccessor _context;

        public SessionAlumnos(IHttpContextAccessor context)
        {
            _context = context;
            _session = context.HttpContext.Session;
        }

        public string getUser()
        {
            return get("usuario");
        }

        public string getName()
        {
            return get("alumno");
        }

        public bool isLogged()
        {
            return !string.IsNullOrEmpty(get("usuario"));
        }

        public bool inRol(string _rol)
        {
            var sesion_roles = get("roles");
            if (string.IsNullOrEmpty(sesion_roles)) return false;
            var lista_roles_sesion = sesion_roles.Split(',');
            var lista_roles_verificar = _rol.Split(',');
            foreach (var item in lista_roles_verificar)
            {
                if (lista_roles_sesion.Contains(item)) return true;
            }
            return false;
        }

        public void set(string key, string value)
        {
            _session.SetString(key, value);
        }

        public string get(string key)
        {
            try
            {
                var sesion = _session.GetString(key);
                if (string.IsNullOrEmpty(sesion)) throw new Exception("Key no encontada");
                return Convert.ToString(sesion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public async Task<bool> logoutAsync()
        {
            try
            {
                List<string> lista = new List<string>();
                if (_session.Keys.Count() > 0)
                {
                    foreach (string key in _session.Keys)
                    {
                        lista.Add(key);
                    }
                }
                foreach (string key in lista)
                {
                    _session.Remove(key);
                }
                _session.Clear();
                await Task.Delay(1900);
                return true;
            }
            catch (Exception ex)
            {
                _session.Clear();
                Console.WriteLine(ex.Message);
                return true;
            }
        }

        public bool logoutSync()
        {
            try
            {
                List<string> lista = new List<string>();
                if (_session.Keys.Count() > 0)
                {
                    foreach (string key in _session.Keys)
                    {
                        lista.Add(key);
                    }
                }
                foreach (string key in lista)
                {
                    _session.Remove(key);
                }
                _session.Clear();
                return true;
            }
            catch (Exception ex)
            {
                _session.Clear();
                Console.WriteLine(ex.Message);
                return true;
            }
        }
    }
}