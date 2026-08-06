using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class detalles_ofertas
{
    public int iddetalles_ofertas { get; set; }

    public int idofertas_laborales { get; set; }

    public int idjornadas_ofertas { get; set; }

    public int idmodalidades_ofertas { get; set; }

    public virtual jornadas_ofertas idjornadas_ofertasNavigation { get; set; } = null!;

    public virtual modalidades_ofertas idmodalidades_ofertasNavigation { get; set; } = null!;

    public virtual ofertas_laborales idofertas_laboralesNavigation { get; set; } = null!;
}
