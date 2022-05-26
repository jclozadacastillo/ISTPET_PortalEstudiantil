using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class secciones
    {
        public secciones()
        {
            matriculas = new HashSet<matriculas>();
        }

        public int idSeccion { get; set; }
        public string seccion { get; set; }
        public string sufijo { get; set; }

        public virtual ICollection<matriculas> matriculas { get; set; }
    }
}
