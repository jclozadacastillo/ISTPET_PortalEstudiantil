using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class campo_especifico_unesco
{
    public int idCampospecificoUnesco { get; set; }

    public int? idCampoAmplioUnesco { get; set; }

    public string? nombreEspecifico { get; set; }

    public string? codigoEspecifico { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<campo_detallado_unesco> campo_detallado_unesco { get; set; } = new List<campo_detallado_unesco>();

    public virtual campo_amplio_unesco? idCampoAmplioUnescoNavigation { get; set; }
}
