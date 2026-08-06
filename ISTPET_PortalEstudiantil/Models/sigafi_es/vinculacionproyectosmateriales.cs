using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosmateriales
{
    public int idProyectosMateriales { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? material { get; set; }

    public int? cantidad { get; set; }

    public decimal? valor { get; set; }

    public decimal? total { get; set; }

    public int instituto { get; set; }

    public int autogestion { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public sbyte activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
