using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class alumnos_acta_conduccion
{
    public string idalumno { get; set; } = null!;

    public int? numero_acta { get; set; }

    public DateTime? fecha_grado { get; set; }

    public string idperiodo { get; set; } = null!;
}
