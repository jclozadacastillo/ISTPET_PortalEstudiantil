using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class alumnos_habilidades
{
    public int idalumnos_habilidades { get; set; }

    public string? idAlumno { get; set; }

    public int idhabilidades { get; set; }

    public string? nivel { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public virtual habilidades idhabilidadesNavigation { get; set; } = null!;
}
