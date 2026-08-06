using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class jornadas_ofertas
{
    public int idjornadas_ofertas { get; set; }

    public string? tipo_jornada { get; set; }

    public virtual ICollection<detalles_ofertas> detalles_ofertas { get; set; } = new List<detalles_ofertas>();
}
