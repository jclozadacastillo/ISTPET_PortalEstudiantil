using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class categoria_contratos
{
    public int idCategoriaContratos { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<escalafon> escalafon { get; set; } = new List<escalafon>();
}
