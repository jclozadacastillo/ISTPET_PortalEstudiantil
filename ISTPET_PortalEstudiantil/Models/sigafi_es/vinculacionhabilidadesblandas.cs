using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionhabilidadesblandas
{
    public int idHablidadBlanda { get; set; }

    public string? habilidadBlanda { get; set; }

    public string? descripcion { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<vinculacionproyectoshabilidadesblandas> vinculacionproyectoshabilidadesblandas { get; set; } = new List<vinculacionproyectoshabilidadesblandas>();
}
