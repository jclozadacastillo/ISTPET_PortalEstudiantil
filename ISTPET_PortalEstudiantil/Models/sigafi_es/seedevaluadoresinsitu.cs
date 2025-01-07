using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seedevaluadoresinsitu
{
    public int idAsignacionEvaluador { get; set; }

    public string? idPeriodo { get; set; }

    public string? idEvaluador { get; set; }

    public string? idProfesor { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public sbyte? activo { get; set; }
}
