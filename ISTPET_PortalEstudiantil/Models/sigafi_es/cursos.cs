using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class cursos
    {
        public cursos()
        {
            detallemallas = new HashSet<detallemallas>();
            matriculas = new HashSet<matriculas>();
        }

        public int idNivel { get; set; }
        public int idCarrera { get; set; }
        public string Nivel { get; set; }
        public int? jerarquia { get; set; }
        public int? orden { get; set; }
        public byte? esRecuperacion { get; set; }

        public virtual carreras idCarreraNavigation { get; set; }
        public virtual ICollection<detallemallas> detallemallas { get; set; }
        public virtual ICollection<matriculas> matriculas { get; set; }
    }
}
