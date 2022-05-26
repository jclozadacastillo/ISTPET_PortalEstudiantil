using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class modalidades
    {
        public modalidades()
        {
            matriculas = new HashSet<matriculas>();
        }

        public int idModalidad { get; set; }
        public string modalidad { get; set; }
        public string sufijo { get; set; }

        public virtual ICollection<matriculas> matriculas { get; set; }
    }
}
