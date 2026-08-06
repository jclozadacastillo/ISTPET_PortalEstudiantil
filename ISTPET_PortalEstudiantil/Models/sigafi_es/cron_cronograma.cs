using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cron_cronograma
{
    public int idCronograma { get; set; }

    public string idPeriodo { get; set; } = null!;

    public string detalle { get; set; } = null!;

    public bool esPublico { get; set; }

    public bool? esActivo { get; set; }

    public virtual ICollection<cron_detalle_cronograma> cron_detalle_cronograma { get; set; } = new List<cron_detalle_cronograma>();

    public virtual ICollection<cron_dias_especiales> cron_dias_especiales { get; set; } = new List<cron_dias_especiales>();

    public virtual periodos idPeriodoNavigation { get; set; } = null!;
}
