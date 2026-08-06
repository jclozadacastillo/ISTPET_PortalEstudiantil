using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cron_detalle_cronograma
{
    public int idDetalleCronograma { get; set; }

    public int idCronograma { get; set; }

    public int idTipoProceso { get; set; }

    public DateTime fechaInicio { get; set; }

    public DateTime fechaFin { get; set; }

    public DateTime? fechaExtension { get; set; }

    public string? observaciones { get; set; }

    public virtual ICollection<bien_convocatorias_becas> bien_convocatorias_becas { get; set; } = new List<bien_convocatorias_becas>();

    public virtual cron_cronograma idCronogramaNavigation { get; set; } = null!;

    public virtual cron_tipo_proceso idTipoProcesoNavigation { get; set; } = null!;
}
