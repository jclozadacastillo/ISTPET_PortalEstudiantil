using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class alumnos_carreras
    {
        public string idAlumno { get; set; }
        public int idCarrera { get; set; }
        public byte? convalidacion { get; set; }
        public string carrera_convalidada { get; set; }
        public string institucion_convalidada { get; set; }
        public int? creditos_convalidados { get; set; }
        public byte? pasantias { get; set; }
        public decimal? nota_pasantia { get; set; }
        public int? creditos_pasantia { get; set; }
        public byte? trabajo_grado { get; set; }
        public decimal? nota_documento { get; set; }
        public decimal? nota_defensa { get; set; }
        public decimal? nota_tesis { get; set; }
        public int? creditos_titulo { get; set; }
    }
}
