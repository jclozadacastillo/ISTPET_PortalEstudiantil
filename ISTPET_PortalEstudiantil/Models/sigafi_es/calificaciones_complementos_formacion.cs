using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class calificaciones_complementos_formacion
{
    public string idAlumno { get; set; } = null!;

    public int idComplemento { get; set; }

    public int idAsignatura { get; set; }

    public decimal? notaFinal { get; set; }

    public sbyte? aprobado { get; set; }
}
