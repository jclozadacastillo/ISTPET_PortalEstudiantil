using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class categoriassolicitudes
{
    public int idCategoriaSolicitud { get; set; }

    public string? categoria { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<tipossolicitudes> tipossolicitudes { get; set; } = new List<tipossolicitudes>();
}
