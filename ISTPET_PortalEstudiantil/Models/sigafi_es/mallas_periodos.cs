using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class mallas_periodos
{
    public string idPeriodo { get; set; } = null!;

    public int idNivel { get; set; }

    public int idMalla { get; set; }
}
