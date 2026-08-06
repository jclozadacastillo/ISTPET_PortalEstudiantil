using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosobjetivosoportunidades
{
    public int idProyectObjetivoOportunidad { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idObjetivoOportunidad { get; set; }

    public int? orden { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionobjetivosoportunidades? idObjetivoOportunidadNavigation { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
