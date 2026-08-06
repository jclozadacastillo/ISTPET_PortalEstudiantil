using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class fechas_semanas
{
    public int idFechasSemanas { get; set; }

    public int idSemanasHorarios { get; set; }

    public int idFecha { get; set; }

    public string idPeriodo { get; set; } = null!;

    public virtual fechas_horarios idFechaNavigation { get; set; } = null!;

    public virtual periodos idPeriodoNavigation { get; set; } = null!;

    public virtual semanas_horarios idSemanasHorariosNavigation { get; set; } = null!;
}
