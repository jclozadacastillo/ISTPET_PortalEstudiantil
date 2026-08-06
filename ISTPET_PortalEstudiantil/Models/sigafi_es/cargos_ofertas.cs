using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cargos_ofertas
{
    public int idcargos_ofertas { get; set; }

    public string? nombre_cargo { get; set; }

    public virtual ICollection<ofertas_laborales> ofertas_laborales { get; set; } = new List<ofertas_laborales>();
}
