using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cliente_factura
{
    public string documentoFactura { get; set; } = null!;

    public string? tipoDocumento { get; set; }

    public string? nombre { get; set; }

    public string? direccion { get; set; }

    public string? telefono { get; set; }

    public string? email { get; set; }

    public DateTime? fechaCreacion { get; set; }
}
