using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class asignaturas
    {
        public asignaturas()
        {
            calificaciones = new HashSet<calificaciones>();
            detallemallas = new HashSet<detallemallas>();
            prerequisitos = new HashSet<prerequisitos>();
        }

        public int idAsignatura { get; set; }
        public string asignatura { get; set; }
        public bool? anulada { get; set; }
        public string codigo { get; set; }

        public virtual ICollection<calificaciones> calificaciones { get; set; }
        public virtual ICollection<detallemallas> detallemallas { get; set; }
        public virtual ICollection<prerequisitos> prerequisitos { get; set; }
    }
}
