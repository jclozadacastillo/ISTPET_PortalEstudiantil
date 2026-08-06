using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class estadocivil
{
    public int idestadoCivil { get; set; }

    public string? nombre { get; set; }

    public sbyte? requiereConyuge { get; set; }

    public virtual ICollection<alumnos> alumnos { get; set; } = new List<alumnos>();

    public virtual ICollection<profesores> profesores { get; set; } = new List<profesores>();
}
