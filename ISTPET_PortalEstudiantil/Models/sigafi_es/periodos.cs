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

    public sbyte? visualizaPowerBi { get; set; }

    public sbyte? esInstituto { get; set; }

    public sbyte? periodoPlanificacion { get; set; }

    public sbyte? esConduccion { get; set; }

    public virtual ICollection<bien_resoluciones_tribunales> bien_resoluciones_tribunales { get; set; } = new List<bien_resoluciones_tribunales>();

    public virtual ICollection<contratos_asignaturas> contratos_asignaturas { get; set; } = new List<contratos_asignaturas>();

    public virtual ICollection<cron_cronograma> cron_cronograma { get; set; } = new List<cron_cronograma>();

    public virtual ICollection<fechas_pagos_cuotas> fechas_pagos_cuotas { get; set; } = new List<fechas_pagos_cuotas>();

    public virtual ICollection<fechas_semanas> fechas_semanas { get; set; } = new List<fechas_semanas>();

    public virtual ICollection<matriculas> matriculas { get; set; } = new List<matriculas>();

    public virtual ICollection<profesores_carreras_periodos> profesores_carreras_periodos { get; set; } = new List<profesores_carreras_periodos>();

    public virtual ICollection<profesores_dedicacion> profesores_dedicacion { get; set; } = new List<profesores_dedicacion>();
}
