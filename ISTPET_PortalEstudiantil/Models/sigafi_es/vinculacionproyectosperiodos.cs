using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosperiodos
{
    public int idProyectoPeriodo { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? idPeriodo { get; set; }

    public sbyte? esPrincipal { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
