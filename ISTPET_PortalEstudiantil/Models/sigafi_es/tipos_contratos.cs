using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipos_contratos
{
    public int idTiposContratos { get; set; }

    public string? nombre { get; set; }

    public string? codigo { get; set; }

    public int? duracionSemanas { get; set; }

    public ulong? esAfiliado { get; set; }

    public virtual ICollection<plantilla_contrato> plantilla_contrato { get; set; } = new List<plantilla_contrato>();
}
