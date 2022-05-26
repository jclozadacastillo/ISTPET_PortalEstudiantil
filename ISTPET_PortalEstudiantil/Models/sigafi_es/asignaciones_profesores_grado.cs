using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class asignaciones_profesores_grado
    {
        public string idProfesor { get; set; }
        public int idAsignatura { get; set; }
        public string idPeriodo { get; set; }
        public int idModalidad { get; set; }
        public int idSeccion { get; set; }
        public int idNivel { get; set; }
        public string paralelo { get; set; }
        public byte? activo { get; set; }
    }
}
