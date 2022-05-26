using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class cond_alumnos_horarios
    {
        public int idAsignacionHorario { get; set; }
        public int idAsignacion { get; set; }
        public int idFecha { get; set; }
        public int idHora { get; set; }
        public byte? asiste { get; set; }
        public byte? activo { get; set; }
        public string observacion { get; set; }
    }
}
