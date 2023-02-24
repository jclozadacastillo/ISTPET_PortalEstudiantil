using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class calificaciones_propedeutico
{
    public string idAlumno { get; set; } = null!;

    public int idAsignatura { get; set; }

    public string idPeriodo { get; set; } = null!;

    public decimal? nota1 { get; set; }

    public sbyte? aprobado { get; set; }

    public string? observacion { get; set; }
}
