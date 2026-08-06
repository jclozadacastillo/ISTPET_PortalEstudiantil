using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_nivel_instruccion
{
    public int idNivelInstruccion { get; set; }

    public string detalle { get; set; } = null!;

    public virtual ICollection<bien_parentezcos_alumno> bien_parentezcos_alumno { get; set; } = new List<bien_parentezcos_alumno>();
}
