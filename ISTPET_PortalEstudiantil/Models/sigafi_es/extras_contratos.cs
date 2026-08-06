using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class extras_contratos
{
    public int idExtraContratos { get; set; }

    public int idContratos { get; set; }

    public DateTime? fecha_registro { get; set; }

    public DateTime? fecha_inicioextra { get; set; }

    public decimal? valor_extra { get; set; }

    public string? motivo { get; set; }

    public DateTime? fecha_finalizacion { get; set; }

    public sbyte? esactivo { get; set; }

    public string? usuarioRegistra { get; set; }

    public virtual contratos idContratosNavigation { get; set; } = null!;
}
