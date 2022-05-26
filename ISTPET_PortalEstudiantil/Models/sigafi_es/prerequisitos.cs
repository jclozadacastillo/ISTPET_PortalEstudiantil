using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class prerequisitos
    {
        public int idDetalleMalla { get; set; }
        public int idAsignatura { get; set; }
        public byte? activa { get; set; }

        public virtual asignaturas idAsignaturaNavigation { get; set; }
        public virtual detallemallas idDetalleMallaNavigation { get; set; }
    }
}
