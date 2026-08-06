using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class semanas_horarios
{
    public int idSemanasHorarios { get; set; }

    public string? detalle { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? esExamen { get; set; }

    public virtual ICollection<fechas_semanas> fechas_semanas { get; set; } = new List<fechas_semanas>();
}
