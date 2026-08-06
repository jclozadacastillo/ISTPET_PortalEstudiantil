using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipos_ofertas
{
    public int idtipos_ofertas { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<ofertas_laborales> ofertas_laborales { get; set; } = new List<ofertas_laborales>();
}
