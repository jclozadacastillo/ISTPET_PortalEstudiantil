using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class sectores_empresas
{
    public int idsectores_empresas { get; set; }

    public string? nombre_sector { get; set; }

    public string? codigo_sector { get; set; }

    public virtual ICollection<empresas> empresas { get; set; } = new List<empresas>();
}
