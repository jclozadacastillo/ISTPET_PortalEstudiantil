using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class asignaciones_profesores
    {
        public string idProfesor { get; set; }
        public int idAsignatura { get; set; }
        public string idPeriodo { get; set; }
        public int idModalidad { get; set; }
        public int idSeccion { get; set; }
        public int idNivel { get; set; }
        public string paralelo { get; set; }
        public byte? activo { get; set; }
        public DateTime? fecha_grabar { get; set; }
        public DateTime? fecha_modificacion { get; set; }
        public string codigo_asignacion { get; set; }
        public byte? entrega_acta { get; set; }
        public byte? ingresa_notas { get; set; }
        public string user_asignaciones { get; set; }
        public DateTime? fecha_fin { get; set; }
        public DateTime? fecha_inicial { get; set; }
        public string user_acta { get; set; }
        public int idAsignacion { get; set; }
        public byte? esActivaAsignacion { get; set; }
    }
}
