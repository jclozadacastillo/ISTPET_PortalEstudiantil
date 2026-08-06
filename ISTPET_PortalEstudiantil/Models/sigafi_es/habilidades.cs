using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class habilidades
{
    public int idhabilidades { get; set; }

    public string? nombre { get; set; }

    public string? descripcion { get; set; }

    public virtual ICollection<alumnos_habilidades> alumnos_habilidades { get; set; } = new List<alumnos_habilidades>();

    public virtual ICollection<habilidades_requeridas> habilidades_requeridas { get; set; } = new List<habilidades_requeridas>();
}
