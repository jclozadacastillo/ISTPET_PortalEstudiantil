using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class ed_fechasevaluacion
    {
        public string idPeriodo { get; set; }
        public int idModalidad { get; set; }
        public DateTime? fecha_inicio { get; set; }
        public DateTime? fecha_final { get; set; }
    }
}
