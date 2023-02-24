using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class especies
{
    public int idEspecie { get; set; }

    public string especie { get; set; } = null!;

    public decimal valor { get; set; }

    public int numero_cuotas { get; set; }

    public int? prioridad { get; set; }

    public sbyte? permite_intercalar { get; set; }

    public string? codigo_referencia { get; set; }

    public string? idperiodo { get; set; }

    public decimal? extraordinaria { get; set; }

    public int? idNivel { get; set; }

    public virtual ICollection<detalle_pagos> detalle_pagos { get; } = new List<detalle_pagos>();
}
