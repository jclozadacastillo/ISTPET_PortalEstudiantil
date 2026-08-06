using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_convocatorias_becas
{
    public int idConvocatoriasBecas { get; set; }

    public DateTime fechaInicio { get; set; }

    public DateTime? fechaFin { get; set; }

    public int? idDetalleCronograma { get; set; }

    public int idTipoConvocatoria { get; set; }

    public virtual ICollection<bien_postulaciones_becas> bien_postulaciones_becas { get; set; } = new List<bien_postulaciones_becas>();

    public virtual cron_detalle_cronograma? idDetalleCronogramaNavigation { get; set; }

    public virtual bien_tipo_convocatoria idTipoConvocatoriaNavigation { get; set; } = null!;
}
