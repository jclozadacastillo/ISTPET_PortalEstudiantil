using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class sueldos_contratos
{
    public int idSueldosContratos { get; set; }

    public int idContratos { get; set; }

    public DateTime? fecha_registro { get; set; }

    public DateTime? fecha_cambiosueldo { get; set; }

    public decimal? sueldo { get; set; }

    public sbyte? esactivo { get; set; }

    public string? usarioRegistra { get; set; }

    public virtual contratos idContratosNavigation { get; set; } = null!;
}
