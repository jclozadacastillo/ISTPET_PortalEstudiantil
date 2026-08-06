using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionimpactosproyectos
{
    public int idImpactoproyecto { get; set; }

    public string? impactoProyecto { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<vinculacionproyectosimpactos> vinculacionproyectosimpactos { get; set; } = new List<vinculacionproyectosimpactos>();
}
