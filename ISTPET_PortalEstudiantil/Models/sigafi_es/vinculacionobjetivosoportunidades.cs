using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionobjetivosoportunidades
{
    public int idObjetivoOportunidad { get; set; }

    public int? idCategoriaObjetivoOportunidad { get; set; }

    public string? objetivoOportunidad { get; set; }

    public sbyte? activo { get; set; }

    public virtual vinculacioncategoriasobjetivosoportunidades? idCategoriaObjetivoOportunidadNavigation { get; set; }

    public virtual ICollection<vinculacionproyectosobjetivosoportunidades> vinculacionproyectosobjetivosoportunidades { get; set; } = new List<vinculacionproyectosobjetivosoportunidades>();
}
