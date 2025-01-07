using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class usuarios
{
    public string usuario { get; set; } = null!;

    public string? nombre { get; set; }

    public string? clave { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? administrador { get; set; }
}
