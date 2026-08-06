using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_porcentaje_beca
{
    public int idPorcentajeBeca { get; set; }

    public decimal porcentaje { get; set; }

    public sbyte esActivo { get; set; }

    public virtual ICollection<bien_motivos_beca> bien_motivos_beca { get; set; } = new List<bien_motivos_beca>();
}
