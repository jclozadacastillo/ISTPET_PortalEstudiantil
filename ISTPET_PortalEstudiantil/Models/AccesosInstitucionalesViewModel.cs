namespace ISTPET_PortalEstudiantil.Models;

public sealed class AccesosInstitucionalesViewModel
{
    public bool CredencialesDisponibles { get; set; }
    public bool MostrarUsuarioEva { get; set; }
    public bool MostrarChatConduccion => EnlacesChat.Count > 0;
    public string? EmailInstitucional { get; set; }
    public string? ClaveTemporalEmail { get; set; }
    public string? UsuarioEva { get; set; }
    public DateTime? FechaLimiteCredenciales { get; set; }
    public DateTime FechaActual { get; set; }
    public string? PeriodoCredenciales { get; set; }
    public IReadOnlyList<EnlaceChatViewModel> EnlacesChat { get; set; } = Array.Empty<EnlaceChatViewModel>();
}

public sealed class EnlaceChatViewModel
{
    public int IdEnlace { get; set; }
    public string Enlace { get; set; } = string.Empty;
    public string Periodo { get; set; } = string.Empty;
    public string Nivel { get; set; } = string.Empty;
    public string Modalidad { get; set; } = string.Empty;
    public string Seccion { get; set; } = string.Empty;
    public string Paralelo { get; set; } = string.Empty;
}
