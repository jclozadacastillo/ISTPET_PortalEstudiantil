using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class alumnos_acta_conduccion
    {
        public string idalumno { get; set; }
        public int? numero_acta { get; set; }
        public DateTime? fecha_grado { get; set; }
        public string idperiodo { get; set; }
    }
}
