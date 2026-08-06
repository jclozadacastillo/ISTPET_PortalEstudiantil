using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class fechas_horarios
{
    public int idFecha { get; set; }

    public DateTime? fecha { get; set; }

    public sbyte? finsemana { get; set; }

    public string? dia { get; set; }

    public virtual ICollection<fechas_semanas> fechas_semanas { get; set; } = new List<fechas_semanas>();

    public virtual ICollection<horario_detalle> horario_detalle { get; set; } = new List<horario_detalle>();
}
