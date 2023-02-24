using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class fechas_grados
{
    public string idperiodo { get; set; } = null!;

    public int idnivel { get; set; }

    public int idseccion { get; set; }

    public string paralelo { get; set; } = null!;

    public DateTime? fecha_grado { get; set; }
}
