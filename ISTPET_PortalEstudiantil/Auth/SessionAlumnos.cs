using Dapper;
using MySql.Data.MySqlClient;

namespace ISTPET_PortalEstudiantil.Auth
{
    public class SessionAlumnos : ISessionAlumnos
    {
        private readonly ISession? _session;
        private readonly string _cn;

        public SessionAlumnos(IHttpContextAccessor context, IConfiguration config)
        {
            _session = context.HttpContext?.Session;
            _cn = config.GetConnectionString("sigafi_es") ?? string.Empty;
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
            if (string.IsNullOrEmpty(sesion_roles) || string.IsNullOrEmpty(_rol)) return false;
            var lista_roles_sesion = sesion_roles.Split(',');
            var lista_roles_verificar = _rol.Split(',');
            foreach (var item in lista_roles_verificar)
            {
                if (lista_roles_sesion.Contains(item.Trim())) return true;
            }
            return false;
        }

        public void set(string key, string value)
        {
            _session?.SetString(key, value ?? string.Empty);
        }

        public string get(string key)
        {
            return _session?.GetString(key) ?? string.Empty;
        }

        public Task<bool> logoutAsync()
        {
            try
            {
                _session?.Clear();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(true);
            }
        }

        public bool logoutSync()
        {
            try
            {
                _session?.Clear();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }

        public int evaluacionesPendientes()
        {
            var usuario = getUser();
            if (string.IsNullOrEmpty(usuario)) return 0;

            try
            {
                using var dapper = new MySqlConnection(_cn);
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
                            and ap.idAsignacion not in(select sh.idAsignacion from seddheteroevaluacion sh
                            WHERE sh.idMatricula=m.idMatricula)";
                return dapper.ExecuteScalar<int>(sql, new { usuario });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool terminosCondicionesPendientes()
        {
            var usuario = getUser();
            if (string.IsNullOrEmpty(usuario)) return false;

            try
            {
                using var dapper = new MySqlConnection(_cn);
                string sql = @"
                    SELECT COUNT(1)
                    FROM pd_terminos_condiciones t
                    INNER JOIN pd_categorias_terminos_condiciones c ON c.idCategoria = t.idCategoria
                    WHERE t.esVigente = 1
                    AND c.activo = 1
                    AND c.esAlumno = 1
                    AND NOT EXISTS (
                        SELECT 1
                        FROM pd_aceptaciones_usuarios au
                        WHERE au.idUsuario = @usuario
                    )";

                return dapper.ExecuteScalar<int>(sql, new { usuario }) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
