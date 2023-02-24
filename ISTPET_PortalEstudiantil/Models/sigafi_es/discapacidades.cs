using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class discapacidades
{
    public int idDiscapacidad { get; set; }

    public string? discapacidad { get; set; }

    public sbyte? esDefecto { get; set; }
}
