using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ofertas_carreras
{
    public int idofertas_carreras { get; set; }

    public int idofertas_laborales { get; set; }

    public int idCarrera { get; set; }

    public virtual carreras idCarreraNavigation { get; set; } = null!;

    public virtual ofertas_laborales idofertas_laboralesNavigation { get; set; } = null!;
}
