using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosobjetivos
{
    public int idProyectoObjetivo { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? objetivo { get; set; }

    public sbyte? esGeneral { get; set; }

    public string? resultado { get; set; }

    public int? orden { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }

    public virtual ICollection<vinculacionproyectosplantrabajo> vinculacionproyectosplantrabajo { get; set; } = new List<vinculacionproyectosplantrabajo>();
}
