using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class calificaciones_propedeutico
    {
        public string idAlumno { get; set; }
        public int idAsignatura { get; set; }
        public string idPeriodo { get; set; }
        public decimal? nota1 { get; set; }
        public byte? aprobado { get; set; }
        public string observacion { get; set; }
    }
}
