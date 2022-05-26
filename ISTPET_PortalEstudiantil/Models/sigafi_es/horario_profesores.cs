using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class horario_profesores
    {
        public int idHorario { get; set; }
        public int? idAsignacion { get; set; }
        public int? idHora { get; set; }
        public int? idFecha { get; set; }
        public byte? asiste { get; set; }
        public byte? activo { get; set; }
    }
}
