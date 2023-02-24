using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class detalle_pagos
{
    public int idPago { get; set; }

    public int idEspecie { get; set; }

    public decimal? valor { get; set; }

    public decimal? descuento { get; set; }

    public int? idCredito { get; set; }

    public virtual especies idEspecieNavigation { get; set; } = null!;

    public virtual pagos idPagoNavigation { get; set; } = null!;
}
