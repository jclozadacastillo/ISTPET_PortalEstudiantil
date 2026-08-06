using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class contratos_facturas
{
    public int idFacturasContratos { get; set; }

    public int idContratos { get; set; }

    public DateTime? periodoFactura { get; set; }

    public string numeroFactura { get; set; } = null!;

    public decimal? valorFacturado { get; set; }

    public virtual contratos idContratosNavigation { get; set; } = null!;
}
