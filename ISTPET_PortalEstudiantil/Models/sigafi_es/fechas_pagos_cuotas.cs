using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class fechas_pagos_cuotas
{
    public int idFecha { get; set; }

    public string idPeriodo { get; set; } = null!;

    public int idModalidad { get; set; }

    public int idCarrera { get; set; }

    public string? codigo_referencia { get; set; }

    public DateTime? fecha { get; set; }

    public sbyte? genera_fecha { get; set; }

    public sbyte? activo { get; set; }

    public virtual carreras idCarreraNavigation { get; set; } = null!;

    public virtual modalidades idModalidadNavigation { get; set; } = null!;

    public virtual periodos idPeriodoNavigation { get; set; } = null!;
}
