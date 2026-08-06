using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class gest_password_resets
{
    public int idToken { get; set; }

    public int idUsuario { get; set; }

    public string tokenHash { get; set; } = null!;

    public DateTime fechaCreacion { get; set; }

    public DateTime fechaExpiracion { get; set; }

    public sbyte usado { get; set; }

    public string? ipSolicitud { get; set; }

    public virtual usuarios idUsuarioNavigation { get; set; } = null!;
}
