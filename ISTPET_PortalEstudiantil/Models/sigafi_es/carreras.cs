using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class carreras
    {
        public carreras()
        {
            cursos = new HashSet<cursos>();
            mallas = new HashSet<mallas>();
        }

        public int idCarrera { get; set; }
        public string Carrera { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public bool? activa { get; set; }
        public string directorCarrera { get; set; }
        public int? numero_creditos { get; set; }
        public int? ordenCarrera { get; set; }
        public int? numero_alumnos { get; set; }
        public byte? revisaArrastres { get; set; }
        public string codigo_cases { get; set; }

        public virtual ICollection<cursos> cursos { get; set; }
        public virtual ICollection<mallas> mallas { get; set; }
    }
}
