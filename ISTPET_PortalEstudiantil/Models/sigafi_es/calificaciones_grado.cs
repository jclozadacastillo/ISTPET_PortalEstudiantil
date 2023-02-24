using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class calificaciones_grado
{
    public int idMatricula { get; set; }

    public int idAsignatura { get; set; }

    public decimal? nota { get; set; }

    public bool? aprobado { get; set; }

    public DateTime? fecha_evaluacion { get; set; }
}
