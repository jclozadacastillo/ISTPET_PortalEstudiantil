using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosentidades
{
    public int idProyectoEntidad { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? entidad { get; set; }

    public string? tipoEntidad { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
