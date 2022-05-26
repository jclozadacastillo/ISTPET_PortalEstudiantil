using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class alumnos_titulos
    {
        public string idAlumno { get; set; }
        public int idTitulo { get; set; }
        public DateTime? fecha_acta { get; set; }
        public string numero_acta { get; set; }
        public string primer_vocal { get; set; }
        public string segundo_vocal { get; set; }
        public string tercer_vocal { get; set; }
        public string secretaria { get; set; }
        public string rector { get; set; }
        public string vicerrector { get; set; }
        public int? total_creditos { get; set; }
        public int? total_asignaturas { get; set; }
        public int? total_horas { get; set; }
        public decimal? puntaje_total { get; set; }
        public decimal? nota_final { get; set; }
        public string titulo_tesis { get; set; }
    }
}
