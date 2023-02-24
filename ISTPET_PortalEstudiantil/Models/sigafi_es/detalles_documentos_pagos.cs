using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class detalles_documentos_pagos
{
    public uint iddocumentopago { get; set; }

    public int idpago { get; set; }

    public decimal valor { get; set; }

    public virtual pagos idpagoNavigation { get; set; } = null!;
}
