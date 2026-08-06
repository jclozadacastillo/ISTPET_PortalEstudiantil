using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class modalidades
{
    public int idModalidad { get; set; }

    public string? modalidad { get; set; }

    public string? sufijo { get; set; }

    public string? modalidadImpresion { get; set; }

    public virtual ICollection<fechas_pagos_cuotas> fechas_pagos_cuotas { get; set; } = new List<fechas_pagos_cuotas>();

    public virtual ICollection<matriculas> matriculas { get; set; } = new List<matriculas>();

    public virtual ICollection<modalidades_carreras> modalidades_carreras { get; set; } = new List<modalidades_carreras>();
}
