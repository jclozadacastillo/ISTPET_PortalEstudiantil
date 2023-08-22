using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class parciales_modalidades_fechas
{
    public string? idPeriodo { get; set; }

    public int? idParcial { get; set; }

    public int? idModalidad { get; set; }

    public DateTime? fechaInicio { get; set; }

    public DateTime? fechaFin { get; set; }

    public sbyte? activo { get; set; }
}
