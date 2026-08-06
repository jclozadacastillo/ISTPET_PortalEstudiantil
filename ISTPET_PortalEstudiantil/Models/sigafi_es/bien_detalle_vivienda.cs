using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_detalle_vivienda
{
    public string idAlumno { get; set; } = null!;

    public string tipoDeVivienda { get; set; } = null!;

    public int espaciosFisicos { get; set; }

    public int dormitorios { get; set; }

    public string referencia { get; set; } = null!;

    public int? miembrosHogar { get; set; }

    public int? adultosVivienda { get; set; }

    public int? niñosVivienda { get; set; }

    public sbyte? bonoDesarrolloHumano { get; set; }

    public decimal? ingresoPromedioHogar { get; set; }

    public int idFichaSocioEconomica { get; set; }

    public virtual bien_ficha_socioeconomica idFichaSocioEconomicaNavigation { get; set; } = null!;
}
