using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class detalle_sistema_evaluacion
{
    public string idperiodo { get; set; } = null!;

    public int idcarrera { get; set; }

    public int idsistemaevaluacion { get; set; }
}
