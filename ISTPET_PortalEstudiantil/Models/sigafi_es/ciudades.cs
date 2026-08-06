using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ciudades
{
    public int idciudades { get; set; }

    public int idprovincias { get; set; }

    public string? nombre { get; set; }

    public virtual provincias idprovinciasNavigation { get; set; } = null!;

    public virtual ICollection<parroquias> parroquias { get; set; } = new List<parroquias>();
}
