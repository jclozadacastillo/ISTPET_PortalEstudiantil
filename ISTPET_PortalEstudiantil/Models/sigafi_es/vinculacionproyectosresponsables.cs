using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosresponsables
{
    public int idProyectoResponsable { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? idProfesor { get; set; }

    public sbyte? esColaborador { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
