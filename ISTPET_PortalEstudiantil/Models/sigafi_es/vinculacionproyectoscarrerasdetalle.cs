using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectoscarrerasdetalle
{
    public int idProyectoCarrera { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idTipoPoblacion { get; set; }

    public string? poblacion { get; set; }

    public string? descripcion { get; set; }

    public int? orden { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }

    public virtual vinculaciontipospoblaciones? idTipoPoblacionNavigation { get; set; }
}
