using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class asignacion_instructores_vehiculos
    {
        public int idAsignacion { get; set; }
        public int idVehiculo { get; set; }
        public string idProfesor { get; set; }
        public DateTime? fecha_asignacion { get; set; }
        public DateTime? fecha_salidad { get; set; }
        public bool? activo { get; set; }
        public string usuario_asigna { get; set; }
        public string usuario_desactiva { get; set; }
        public string observacion { get; set; }
    }
}
