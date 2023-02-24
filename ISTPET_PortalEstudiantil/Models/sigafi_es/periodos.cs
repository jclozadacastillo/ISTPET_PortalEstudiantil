using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class periodos
{
    public string idPeriodo { get; set; } = null!;

    public string? detalle { get; set; }

    public DateTime? fecha_inicial { get; set; }

    public DateTime? fecha_final { get; set; }

    public bool? cerrado { get; set; }

    public DateTime? fecha_maxima_autocierre { get; set; }

    public bool? activo { get; set; }

    public bool? creditos { get; set; }

    public uint? numero_pagos { get; set; }

    public DateTime? fecha_matrucla_extraordinaria { get; set; }

    public int? foliop { get; set; }

    public sbyte? permiteMatricula { get; set; }

    public sbyte? ingresoCalificaciones { get; set; }

    public sbyte? permiteCalificacionesInstituto { get; set; }

    public sbyte? periodoactivoinstituto { get; set; }

    public virtual ICollection<matriculas> matriculas { get; } = new List<matriculas>();
}
