using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class ed_preguntas
    {
        public int IdPregunta { get; set; }
        public int? idEncuesta { get; set; }
        public string pregunta { get; set; }
        public int? orden { get; set; }
        public byte? activa { get; set; }
        public byte? esAbierta { get; set; }
    }
}
