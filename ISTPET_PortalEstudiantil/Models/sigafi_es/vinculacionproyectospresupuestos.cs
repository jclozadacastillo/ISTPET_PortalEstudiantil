using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectospresupuestos
{
    public int idProyectoPresupuesto { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? empresa { get; set; }

    public decimal? cantidad { get; set; }

    public int? orden { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
