using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class paises
{
    public int idpaises { get; set; }

    public string? nombre { get; set; }

    public string? nacionalidad { get; set; }

    public sbyte? esEcuador { get; set; }

    public virtual ICollection<bien_parentezcos_alumno> bien_parentezcos_alumno { get; set; } = new List<bien_parentezcos_alumno>();

    public virtual ICollection<provincias> provincias { get; set; } = new List<provincias>();

    public virtual ICollection<universidades> universidades { get; set; } = new List<universidades>();
}
