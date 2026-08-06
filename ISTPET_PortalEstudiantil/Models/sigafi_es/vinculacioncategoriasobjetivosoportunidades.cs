using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacioncategoriasobjetivosoportunidades
{
    public int idCategoriaObjetivoOportunidad { get; set; }

    public string? categoriaObjetivoOportunidad { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<vinculacionobjetivosoportunidades> vinculacionobjetivosoportunidades { get; set; } = new List<vinculacionobjetivosoportunidades>();
}
