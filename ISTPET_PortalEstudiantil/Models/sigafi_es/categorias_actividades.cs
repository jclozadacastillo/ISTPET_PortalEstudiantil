using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class categorias_actividades
{
    public int idCategoria { get; set; }

    public string categoria { get; set; } = null!;

    public sbyte? esDocencia { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? porcentaje { get; set; }

    public virtual ICollection<seddinstrumentos> seddinstrumentos { get; set; } = new List<seddinstrumentos>();
}
