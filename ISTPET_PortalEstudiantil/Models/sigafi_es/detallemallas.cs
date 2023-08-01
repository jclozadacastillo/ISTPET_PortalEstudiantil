using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class detallemallas
{
    public int idDetalleMalla { get; set; }

    public int idMalla { get; set; }

    public int idAsignatura { get; set; }

    public int idNivel { get; set; }

    public string? tipo { get; set; }

    public bool? opcional { get; set; }

    public int? creditos { get; set; }

    public int? horas { get; set; }

    public bool? anulada { get; set; }

    public virtual asignaturas idAsignaturaNavigation { get; set; } = null!;

    public virtual mallas idMallaNavigation { get; set; } = null!;

    public virtual cursos idNivelNavigation { get; set; } = null!;

    public virtual ICollection<prerequisitos> prerequisitos { get; set; } = new List<prerequisitos>();
}
