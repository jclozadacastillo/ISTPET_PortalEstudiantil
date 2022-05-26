using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class detallemallas
    {
        public detallemallas()
        {
            prerequisitos = new HashSet<prerequisitos>();
        }

        public int idDetalleMalla { get; set; }
        public int idMalla { get; set; }
        public int idAsignatura { get; set; }
        public int idNivel { get; set; }
        public string tipo { get; set; }
        public bool? opcional { get; set; }
        public int? creditos { get; set; }
        public int? horas { get; set; }
        public bool? anulada { get; set; }

        public virtual asignaturas idAsignaturaNavigation { get; set; }
        public virtual mallas idMallaNavigation { get; set; }
        public virtual cursos idNivelNavigation { get; set; }
        public virtual ICollection<prerequisitos> prerequisitos { get; set; }
    }
}
