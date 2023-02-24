using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class medios_contacto
{
    public int idMedio { get; set; }

    public string? medio { get; set; }

    public ulong? activo { get; set; }
}
