using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionestadosproyectos
{
    public int idEstadoProyecto { get; set; }

    public string? estado { get; set; }

    public int? orden { get; set; }

    public sbyte? activo { get; set; }
}
