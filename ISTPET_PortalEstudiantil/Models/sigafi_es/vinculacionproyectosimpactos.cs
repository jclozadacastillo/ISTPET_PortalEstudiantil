using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosimpactos
{
    public int idProyectoImpacto { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idImpactoproyecto { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionimpactosproyectos? idImpactoproyectoNavigation { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }

    public virtual ICollection<vinculacionproyectosplantrabajo> vinculacionproyectosplantrabajo { get; set; } = new List<vinculacionproyectosplantrabajo>();
}
