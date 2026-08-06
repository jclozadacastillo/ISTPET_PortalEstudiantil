using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class detallemallas
{
    public int idDetalleMalla { get; set; }

    public int idMalla { get; set; }

    public int idAsignatura { get; set; }

    public int idNivel { get; set; }

    public int idtipo_asignatura { get; set; }

    public string? tipo { get; set; }

    public bool? opcional { get; set; }

    public int? creditos { get; set; }

    public int? horas { get; set; }

    public bool? anulada { get; set; }

    public int? horasDocente { get; set; }

    public decimal? horasPracticoExperimental { get; set; }

    public virtual asignaturas idAsignaturaNavigation { get; set; } = null!;

    public virtual mallas idMallaNavigation { get; set; } = null!;

    public virtual cursos idNivelNavigation { get; set; } = null!;

    public virtual tipos_asignatura idtipo_asignaturaNavigation { get; set; } = null!;

    public virtual ICollection<prerequisitos> prerequisitos { get; set; } = new List<prerequisitos>();
}
