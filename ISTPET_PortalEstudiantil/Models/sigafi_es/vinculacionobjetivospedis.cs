using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionobjetivospedis
{
    public int idObjetivoPedi { get; set; }

    public string? pedi { get; set; }

    public string? objetivoPedi { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<vinculacionproyectosobjetivospedis> vinculacionproyectosobjetivospedis { get; set; } = new List<vinculacionproyectosobjetivospedis>();
}
