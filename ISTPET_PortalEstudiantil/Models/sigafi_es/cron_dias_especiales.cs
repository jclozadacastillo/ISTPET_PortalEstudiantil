using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cron_dias_especiales
{
    public int idDiasEspeciales { get; set; }

    public DateTime? fecha { get; set; }

    public int idTipoDiaEspecial { get; set; }

    public int idCronograma { get; set; }

    public virtual cron_cronograma idCronogramaNavigation { get; set; } = null!;

    public virtual cron_tipo_dia_especial idTipoDiaEspecialNavigation { get; set; } = null!;
}
