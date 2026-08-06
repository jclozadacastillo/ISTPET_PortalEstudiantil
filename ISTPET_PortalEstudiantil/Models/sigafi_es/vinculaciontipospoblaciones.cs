using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculaciontipospoblaciones
{
    public int idTipoPoblacion { get; set; }

    public string? tipoPoblacion { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<vinculacionproyectoscarrerasdetalle> vinculacionproyectoscarrerasdetalle { get; set; } = new List<vinculacionproyectoscarrerasdetalle>();
}
