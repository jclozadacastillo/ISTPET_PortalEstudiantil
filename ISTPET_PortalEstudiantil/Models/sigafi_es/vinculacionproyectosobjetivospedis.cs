using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosobjetivospedis
{
    public int idProyectoObjetivoPedi { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idObjetivoPedi { get; set; }

    public int? orden { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionobjetivospedis? idObjetivoPediNavigation { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
