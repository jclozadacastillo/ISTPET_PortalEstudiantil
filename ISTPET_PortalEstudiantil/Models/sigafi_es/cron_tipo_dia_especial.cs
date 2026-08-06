using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cron_tipo_dia_especial
{
    public int idTipoDiaEspecial { get; set; }

    public string? detalle { get; set; }

    public sbyte? esFeriado { get; set; }

    public sbyte? esEventoInterno { get; set; }

    public DateTime? fechaOriginal { get; set; }

    public virtual ICollection<cron_dias_especiales> cron_dias_especiales { get; set; } = new List<cron_dias_especiales>();
}
