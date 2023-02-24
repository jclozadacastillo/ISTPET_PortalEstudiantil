using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class sistema_titulacion
{
    public int codigo_sistema { get; set; }

    public string? detalle { get; set; }

    public sbyte? activo { get; set; }
}
