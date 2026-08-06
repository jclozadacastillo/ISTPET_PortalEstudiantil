using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_servicios_fichas
{
    public int idServicioFicha { get; set; }

    public sbyte tieneServicio { get; set; }

    public int idTipoServicio { get; set; }

    public int idFichaSocioEconomica { get; set; }

    public virtual bien_ficha_socioeconomica idFichaSocioEconomicaNavigation { get; set; } = null!;

    public virtual bien_tipo_servicios idTipoServicioNavigation { get; set; } = null!;
}
