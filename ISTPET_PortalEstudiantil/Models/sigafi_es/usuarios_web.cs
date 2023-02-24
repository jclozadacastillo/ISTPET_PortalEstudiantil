using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class usuarios_web
{
    public string usuario { get; set; } = null!;

    public string? password { get; set; }

    public sbyte? salida { get; set; }

    public sbyte? ingreso { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? asistencia { get; set; }
}
