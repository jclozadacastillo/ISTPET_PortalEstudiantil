using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_tipo_convocatoria
{
    public int idTipoConvocatoria { get; set; }

    public string detalle { get; set; } = null!;

    public sbyte esActivo { get; set; }

    public sbyte esInformativo { get; set; }

    public sbyte bloquea { get; set; }

    public virtual ICollection<bien_convocatorias_becas> bien_convocatorias_becas { get; set; } = new List<bien_convocatorias_becas>();
}
