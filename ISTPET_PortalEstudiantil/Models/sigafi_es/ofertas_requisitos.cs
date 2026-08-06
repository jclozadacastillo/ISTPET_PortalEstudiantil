using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ofertas_requisitos
{
    public int idofertas_requisitos { get; set; }

    public int idofertas_laborales { get; set; }

    public string? descripcion { get; set; }

    public sbyte? es_obligatoria { get; set; }

    public virtual ofertas_laborales idofertas_laboralesNavigation { get; set; } = null!;
}
