using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ed_respuestastestab
{
    public int idIngresoTest { get; set; }

    public int idPregunta { get; set; }

    public string? respuesta { get; set; }
}
