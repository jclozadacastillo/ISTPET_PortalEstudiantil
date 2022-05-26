using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class fechas_grados
    {
        public string idperiodo { get; set; }
        public int idnivel { get; set; }
        public int idseccion { get; set; }
        public string paralelo { get; set; }
        public DateTime? fecha_grado { get; set; }
    }
}
