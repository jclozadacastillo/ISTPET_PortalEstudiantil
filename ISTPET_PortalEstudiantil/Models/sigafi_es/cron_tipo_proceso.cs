using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cron_tipo_proceso
{
    public int idTipoProceso { get; set; }

    public string detalle { get; set; } = null!;

    public sbyte esInformativo { get; set; }

    public string audiencia { get; set; } = null!;

    public int orden { get; set; }

    public bool? esActivo { get; set; }

    public virtual ICollection<cron_detalle_cronograma> cron_detalle_cronograma { get; set; } = new List<cron_detalle_cronograma>();
}
