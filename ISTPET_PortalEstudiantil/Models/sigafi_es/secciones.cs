using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class secciones
{
    public int idSeccion { get; set; }

    public string? seccion { get; set; }

    public string? sufijo { get; set; }

    public virtual ICollection<matriculas> matriculas { get; } = new List<matriculas>();
}
