using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class plantillasparametros
{
    public int idParametro { get; set; }

    public int? idPlantilla { get; set; }

    public string? parametro { get; set; }

    public decimal? x { get; set; }

    public decimal? y { get; set; }

    public decimal? fontSize { get; set; }

    public string? textAlign { get; set; }

    public string? width { get; set; }

    public string? fontFamily { get; set; }

    public virtual plantillas? idPlantillaNavigation { get; set; }
}
