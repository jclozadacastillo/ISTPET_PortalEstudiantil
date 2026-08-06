using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectoshabilidadesblandas
{
    public int idProyectoHabilidad { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idHablidadBlanda { get; set; }

    public int? orden { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionhabilidadesblandas? idHablidadBlandaNavigation { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
