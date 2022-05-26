using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class agenda_academica
    {
        public string idperiodo { get; set; }
        public DateTime? fecha_desde { get; set; }
        public DateTime? fecha_hasta { get; set; }
        public string evento { get; set; }
    }
}
