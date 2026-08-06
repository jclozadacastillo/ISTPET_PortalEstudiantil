using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_datos_economicos
{
    public int idFichaSocioEconomica { get; set; }

    public sbyte familiaRecibeBono { get; set; }

    public string tipoActividadEconomica { get; set; } = null!;

    public decimal ingresosPropios { get; set; }

    public string? empleaIngresos { get; set; }

    public string? nombreBono { get; set; }

    public virtual bien_ficha_socioeconomica idFichaSocioEconomicaNavigation { get; set; } = null!;
}
