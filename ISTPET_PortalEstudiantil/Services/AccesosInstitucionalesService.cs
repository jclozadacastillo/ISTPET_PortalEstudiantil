using Dapper;
using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models;
using MySql.Data.MySqlClient;

namespace ISTPET_PortalEstudiantil.Services;

public interface IAccesosInstitucionalesService
{
    Task<AccesosInstitucionalesViewModel> ObtenerDisponibilidadAsync();
    Task<AccesosInstitucionalesViewModel> ObtenerCorreoAsync();
    Task<AccesosInstitucionalesViewModel> ObtenerUsuarioEvaAsync();
}

public sealed class AccesosInstitucionalesService : IAccesosInstitucionalesService
{
    private readonly ISessionAlumnos _auth;
    private readonly string _cn;
    private readonly TimeProvider _clock;
    private readonly ILogger<AccesosInstitucionalesService> _logger;
    private Task<AccesosInstitucionalesViewModel>? _disponibilidad;

    public AccesosInstitucionalesService(ISessionAlumnos auth, IConfiguration config,
        TimeProvider clock, ILogger<AccesosInstitucionalesService> logger)
    {
        _auth = auth;
        _cn = config.GetConnectionString("sigafi_es") ?? string.Empty;
        _clock = clock;
        _logger = logger;
    }

    // The database stores institutional deadlines in Ecuador local time (UTC-05).
    private DateTime Ahora => _clock.GetUtcNow().ToOffset(TimeSpan.FromHours(-5)).DateTime;

    public static bool CredencialesVigentes(int visibleCredenciales, DateTime? fechaLimiteCredenciales, DateTime ahora)
        => visibleCredenciales == 1 && fechaLimiteCredenciales.HasValue && ahora < fechaLimiteCredenciales.Value;

    public static bool EsEnlacePermitido(string? enlace)
        => Uri.TryCreate(enlace, UriKind.Absolute, out var uri)
            && (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
            && !string.IsNullOrWhiteSpace(uri.Host) && string.IsNullOrEmpty(uri.UserInfo);

    public Task<AccesosInstitucionalesViewModel> ObtenerDisponibilidadAsync()
        => _disponibilidad ??= ConsultarDisponibilidadAsync();

    private async Task<AccesosInstitucionalesViewModel> ConsultarDisponibilidadAsync()
    {
        var model = new AccesosInstitucionalesViewModel { FechaActual = Ahora };
        if (!_auth.isLogged()) return model;

        using var db = new MySqlConnection(_cn);
        var idAlumno = _auth.getUser();
        try
        {
            const string sql = @"
                SELECT COALESCE(p.visibleCredenciales, 0) AS VisibleCredenciales,
                    p.fechaLimiteCredenciales AS FechaLimiteCredenciales,
                    p.detalle AS PeriodoCredenciales,
                    CASE WHEN NULLIF(TRIM(a.email_institucional), '') IS NOT NULL THEN 1 ELSE 0 END AS TieneCorreo,
                    CASE WHEN NULLIF(TRIM(a.usuarioEva), '') IS NOT NULL THEN 1 ELSE 0 END AS TieneUsuarioEva
                FROM alumnos a
                INNER JOIN matriculas m ON m.idAlumno = a.idAlumno
                INNER JOIN periodos p ON p.idPeriodo = m.idPeriodo
                WHERE a.idAlumno = @idAlumno AND p.activo = 1
                    AND COALESCE(m.retirado, 0) = 0 AND COALESCE(m.valida, 1) = 1
                ORDER BY CASE WHEN p.visibleCredenciales = 1 AND p.fechaLimiteCredenciales > @ahora
                    THEN 0 ELSE 1 END, p.fechaLimiteCredenciales DESC, m.idMatricula DESC
                LIMIT 1";
            var estado = await db.QueryFirstOrDefaultAsync<EstadoCredenciales>(sql, new { idAlumno, ahora = Ahora });
            model.FechaActual = Ahora;
            if (estado != null)
            {
                model.FechaLimiteCredenciales = estado.FechaLimiteCredenciales;
                model.PeriodoCredenciales = estado.PeriodoCredenciales;
                var vigente = CredencialesVigentes(estado.VisibleCredenciales, estado.FechaLimiteCredenciales, model.FechaActual);
                model.CredencialesDisponibles = vigente && estado.TieneCorreo == 1;
                model.MostrarUsuarioEva = vigente && estado.TieneUsuarioEva == 1;
            }
        }
        catch (MySqlException ex)
        {
            _logger.LogWarning("No se pudo consultar la disponibilidad de credenciales. Código MySQL: {Codigo}", ex.Number);
        }

        // Chat availability is independent of the credentials deadline.
        try
        {
            const string sql = @"
                SELECT DISTINCT e.idEnlace AS IdEnlace, TRIM(e.enlace) AS Enlace,
                    COALESCE(p.detalle, p.idPeriodo) AS Periodo, n.Nivel AS Nivel,
                    mo.modalidad AS Modalidad, s.seccion AS Seccion, e.paralelo AS Paralelo
                FROM enlacesChatConduccion e
                INNER JOIN matriculas m ON m.idPeriodo = e.idPeriodo AND m.idNivel = e.idNivel
                    AND m.idModalidad = e.idModalidad AND m.idSeccion = e.idSeccion AND m.paralelo = e.paralelo
                INNER JOIN periodos p ON p.idPeriodo = m.idPeriodo
                INNER JOIN cursos n ON n.idNivel = m.idNivel
                INNER JOIN modalidades mo ON mo.idModalidad = m.idModalidad
                INNER JOIN secciones s ON s.idSeccion = m.idSeccion
                WHERE m.idAlumno = @idAlumno AND e.activo = 1 AND p.activo = 1
                    AND COALESCE(m.retirado, 0) = 0 AND COALESCE(m.valida, 1) = 1
                ORDER BY Periodo DESC, Nivel, Paralelo, IdEnlace";
            var enlaces = await db.QueryAsync<EnlaceChatViewModel>(sql, new { idAlumno });
            model.EnlacesChat = enlaces.Where(e => EsEnlacePermitido(e.Enlace)).ToArray();
        }
        catch (MySqlException ex)
        {
            _logger.LogWarning("No se pudieron consultar los chats de conducción. Código MySQL: {Codigo}", ex.Number);
        }

        return model;
    }

    public Task<AccesosInstitucionalesViewModel> ObtenerCorreoAsync() => ConsultarCredencialesAsync(correo: true);

    public Task<AccesosInstitucionalesViewModel> ObtenerUsuarioEvaAsync() => ConsultarCredencialesAsync(correo: false);

    private async Task<AccesosInstitucionalesViewModel> ConsultarCredencialesAsync(bool correo)
    {
        var disponibilidad = await ObtenerDisponibilidadAsync();
        // Keep the request's shared menu model free of credential values.
        var model = new AccesosInstitucionalesViewModel
        {
            CredencialesDisponibles = disponibilidad.CredencialesDisponibles,
            MostrarUsuarioEva = disponibilidad.MostrarUsuarioEva,
            FechaActual = disponibilidad.FechaActual,
            FechaLimiteCredenciales = disponibilidad.FechaLimiteCredenciales,
            PeriodoCredenciales = disponibilidad.PeriodoCredenciales,
            EnlacesChat = disponibilidad.EnlacesChat
        };
        if (!_auth.isLogged()) return model;

        using var db = new MySqlConnection(_cn);
        try
        {
            // Only credential pages read secrets. SQL checks permission again on every request.
            var campos = correo
                ? "a.email_institucional AS EmailInstitucional, a.claveTemporalEmail AS ClaveTemporalEmail"
                : "a.usuarioEva AS UsuarioEva";
            var sql = $@"
                SELECT {campos}, p.fechaLimiteCredenciales AS FechaLimiteCredenciales,
                    p.detalle AS PeriodoCredenciales
                FROM alumnos a
                INNER JOIN matriculas m ON m.idAlumno = a.idAlumno
                INNER JOIN periodos p ON p.idPeriodo = m.idPeriodo
                WHERE a.idAlumno = @idAlumno AND p.activo = 1 AND p.visibleCredenciales = 1
                    AND p.fechaLimiteCredenciales > @ahora
                    AND COALESCE(m.retirado, 0) = 0 AND COALESCE(m.valida, 1) = 1
                ORDER BY p.fechaLimiteCredenciales DESC, m.idMatricula DESC LIMIT 1";
            var credenciales = await db.QueryFirstOrDefaultAsync<AccesosInstitucionalesViewModel>(sql,
                new { idAlumno = _auth.getUser(), ahora = Ahora });
            model.FechaActual = Ahora;
            if (credenciales != null && CredencialesVigentes(1, credenciales.FechaLimiteCredenciales, model.FechaActual))
            {
                model.FechaLimiteCredenciales = credenciales.FechaLimiteCredenciales;
                model.PeriodoCredenciales = credenciales.PeriodoCredenciales;
                model.EmailInstitucional = credenciales.EmailInstitucional?.Trim();
                // Preserve literal spaces in the temporary password.
                model.ClaveTemporalEmail = credenciales.ClaveTemporalEmail;
                model.UsuarioEva = credenciales.UsuarioEva?.Trim();
                if (correo) model.CredencialesDisponibles = !string.IsNullOrWhiteSpace(model.EmailInstitucional);
                else model.MostrarUsuarioEva = !string.IsNullOrWhiteSpace(model.UsuarioEva);
            }
            else
            {
                model.CredencialesDisponibles = false;
                model.MostrarUsuarioEva = false;
            }
        }
        catch (MySqlException ex)
        {
            model.CredencialesDisponibles = false;
            model.MostrarUsuarioEva = false;
            _logger.LogWarning("No se pudieron consultar las credenciales institucionales. Código MySQL: {Codigo}", ex.Number);
        }

        return model;
    }

    private sealed class EstadoCredenciales
    {
        public int VisibleCredenciales { get; set; }
        public DateTime? FechaLimiteCredenciales { get; set; }
        public string? PeriodoCredenciales { get; set; }
        public int TieneCorreo { get; set; }
        public int TieneUsuarioEva { get; set; }
    }
}
