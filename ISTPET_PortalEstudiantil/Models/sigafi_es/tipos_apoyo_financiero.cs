using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipos_apoyo_financiero
{
    public int idTipoApoyo { get; set; }

    public string? nombreApoyo { get; set; }

    public sbyte? esBeca { get; set; }

    public sbyte? esAyudaEconomica { get; set; }

    public sbyte? activo { get; set; }
}
