using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class cond_alumnos_vehiculos
    {
        public int idAsignacion { get; set; }
        public string idAlumno { get; set; }
        public int idVehiculo { get; set; }
        public string idPeriodo { get; set; }
        public string idProfesor { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public byte? activa { get; set; }
        public string observacion { get; set; }
    }
}
