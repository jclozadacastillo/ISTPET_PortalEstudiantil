using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class provincias
{
    public int idprovincias { get; set; }

    public int idpaises { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<ciudades> ciudades { get; set; } = new List<ciudades>();

    public virtual paises idpaisesNavigation { get; set; } = null!;
}
