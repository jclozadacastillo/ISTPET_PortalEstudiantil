using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionarea
{
    public int idArea { get; set; }

    public string? area { get; set; }

    public sbyte activo { get; set; }

    public virtual ICollection<vinculacionsubarea> vinculacionsubarea { get; set; } = new List<vinculacionsubarea>();
}
