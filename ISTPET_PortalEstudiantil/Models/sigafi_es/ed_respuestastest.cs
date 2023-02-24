using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ed_respuestastest
{
    public int idIngresoTest { get; set; }

    public int idPregunta { get; set; }

    public sbyte? siempre { get; set; }

    public sbyte? casiSiempre { get; set; }

    public sbyte? aVeces { get; set; }

    public sbyte? casiNunca { get; set; }
}
