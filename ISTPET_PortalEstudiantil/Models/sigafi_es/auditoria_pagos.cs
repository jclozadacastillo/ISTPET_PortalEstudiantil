using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class auditoria_pagos
{
    public int? idpago { get; set; }

    public int? idmatricula { get; set; }

    public DateTime fecha { get; set; }

    public string? numero_deposito { get; set; }

    public string? cuenta { get; set; }

    public float? valor { get; set; }

    public int? num_registro { get; set; }

    public string? usuario { get; set; }
}
