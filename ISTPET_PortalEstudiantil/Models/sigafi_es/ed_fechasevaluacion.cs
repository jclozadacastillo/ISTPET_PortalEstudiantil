using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ed_fechasevaluacion
{
    public string idPeriodo { get; set; } = null!;

    public int idModalidad { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public DateTime? fecha_final { get; set; }
}
