using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class campo_amplio_unesco
{
    public int idCampoAmplioUnesco { get; set; }

    public string? nombre { get; set; }

    public string? codigoAmplio { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<campo_especifico_unesco> campo_especifico_unesco { get; set; } = new List<campo_especifico_unesco>();
}
