using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionsubarea
{
    public int idSubArea { get; set; }

    public int? idArea { get; set; }

    public string? subArea { get; set; }

    public sbyte activo { get; set; }

    public virtual vinculacionarea? idAreaNavigation { get; set; }

    public virtual ICollection<vinculacionsubareaespecifica> vinculacionsubareaespecifica { get; set; } = new List<vinculacionsubareaespecifica>();
}
