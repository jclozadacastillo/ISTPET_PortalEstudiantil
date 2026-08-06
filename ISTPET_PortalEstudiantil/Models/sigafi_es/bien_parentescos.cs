using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_parentescos
{
    public int idParentezco { get; set; }

    public string nombre { get; set; } = null!;

    public sbyte esPadre { get; set; }

    public sbyte esMadre { get; set; }

    public virtual ICollection<bien_parentezcos_alumno> bien_parentezcos_alumno { get; set; } = new List<bien_parentezcos_alumno>();
}
