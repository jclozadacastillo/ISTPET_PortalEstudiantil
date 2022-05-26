using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class ed_respuestastest
    {
        public int idIngresoTest { get; set; }
        public int idPregunta { get; set; }
        public byte? siempre { get; set; }
        public byte? casiSiempre { get; set; }
        public byte? aVeces { get; set; }
        public byte? casiNunca { get; set; }
    }
}
