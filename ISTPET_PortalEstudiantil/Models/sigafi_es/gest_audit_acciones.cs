using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class gest_audit_acciones
{
    public string idAuditAcciones { get; set; } = null!;

    public string codigoSistema { get; set; } = null!;

    public string idModulo { get; set; } = null!;

    public string? nombre { get; set; }

    public string? descripcion { get; set; }

    public sbyte? esActivo { get; set; }
}
