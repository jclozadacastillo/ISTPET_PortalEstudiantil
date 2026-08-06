using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_apoyo
{
    public int idBienApoyo { get; set; }

    public string? detalle { get; set; }

    public sbyte? esBeca { get; set; }

    public sbyte? esAyudaEconomica { get; set; }

    public virtual ICollection<bien_tipo_apoyo_financiero> bien_tipo_apoyo_financiero { get; set; } = new List<bien_tipo_apoyo_financiero>();
}
