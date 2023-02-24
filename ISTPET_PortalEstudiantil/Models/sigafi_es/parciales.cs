using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class parciales
{
    public int idParcial { get; set; }

    public string? Parcial { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public DateTime? fecha_final { get; set; }
}
