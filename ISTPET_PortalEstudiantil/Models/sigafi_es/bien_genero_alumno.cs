using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_genero_alumno
{
    public int idGeneroAlumno { get; set; }

    public string detalle { get; set; } = null!;

    public virtual ICollection<alumnos> alumnos { get; set; } = new List<alumnos>();
}
