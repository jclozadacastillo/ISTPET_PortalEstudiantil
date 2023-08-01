using Dapper;
using MySql.Data.MySqlClient;

namespace ISTPET_PortalEstudiantil.Auth
{
    public class SessionAlumnos : ISessionAlumnos
    {
        private readonly ISession _session;
        private readonly IHttpContextAccessor _context;
        private readonly string _cn;

        public SessionAlumnos(IHttpContextAccessor context,IConfiguration config)
        {
            _context = context;
            _session = context.HttpContext.Session;
            _cn = config.GetConnectionString("sigafi_es");
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
            _session.SetString(key, value==null?"":value);
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


        public int evaluacionesPendientes()
        {
            var dapper = new MySqlConnection(_cn);
            try
            {
                string sql = @"select count(ag.idAsignatura)
                            from alumnos a 
                            inner join matriculas m on a.idalumno=m.idalumno 
                            inner join calificaciones c on m.idmatricula=c.idmatricula
                            inner join asignaturas ag on ag.idAsignatura = c.idAsignatura
                            inner join periodos p on p.idPeriodo = m.idPeriodo
                            inner join asignaciones_profesores ap 
                            on ap.idPeriodo = p.idPeriodo and ap.idAsignatura = ag.idAsignatura and ap.idnivel = m.idNivel and ap.idseccion = m.idSeccion
                            and ap.paralelo = m.paralelo and ap.idModalidad = m.idModalidad and ap.activo = '1'
                            where m.idAlumno  = @usuario
                            and p.activo = 1 and p.permiteCalificacionesInstituto = 1
                            and idAsignacion not in(select sh.idAsignacion from seddheteroevaluacion sh
                            WHERE sh.idMatricula=m.idMatricula)";
                return dapper.ExecuteScalar<int>(sql, new { usuario = getUser() });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                dapper.Dispose();
            }
        }
    }
}