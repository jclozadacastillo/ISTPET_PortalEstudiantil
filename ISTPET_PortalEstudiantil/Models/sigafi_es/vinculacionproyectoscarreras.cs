using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectoscarreras
{
    public int idProyectoCarrera { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idCarrera { get; set; }

    public sbyte? esPrincipal { get; set; }

    public sbyte? activo { get; set; }

    public virtual carreras? idCarreraNavigation { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
