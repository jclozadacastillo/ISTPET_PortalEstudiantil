using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class alumnos_sucesos
    {
        public int idSuceso { get; set; }
        public string idAlumno { get; set; }
        public int? idMatricula { get; set; }
        public string observacion { get; set; }
        public string usuario { get; set; }
    }
}
