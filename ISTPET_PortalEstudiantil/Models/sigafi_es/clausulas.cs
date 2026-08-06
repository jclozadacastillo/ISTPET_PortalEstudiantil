using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class clausulas
{
    public int idClausulas { get; set; }

    public string? nombre_clausula { get; set; }

    public int? orden { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual ICollection<plantilla_clausulas> plantilla_clausulas { get; set; } = new List<plantilla_clausulas>();
}
