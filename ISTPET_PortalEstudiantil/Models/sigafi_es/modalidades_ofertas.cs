using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class modalidades_ofertas
{
    public int idmodalidades_ofertas { get; set; }

    public string? tipo_modalidad { get; set; }

    public virtual ICollection<detalles_ofertas> detalles_ofertas { get; set; } = new List<detalles_ofertas>();
}
