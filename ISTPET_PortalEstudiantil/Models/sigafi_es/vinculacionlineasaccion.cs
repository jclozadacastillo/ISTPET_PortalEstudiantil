using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionlineasaccion
{
    public int idlineaAsccion { get; set; }

    public string? linea { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<vinculacionproyectos> vinculacionproyectos { get; set; } = new List<vinculacionproyectos>();
}
