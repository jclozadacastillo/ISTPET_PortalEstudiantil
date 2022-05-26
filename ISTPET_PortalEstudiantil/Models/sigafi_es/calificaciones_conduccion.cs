using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class calificaciones_conduccion
    {
        public int? idmatricula { get; set; }
        public int? nota_final { get; set; }
        public bool? aprobado { get; set; }
        public string observacion { get; set; }
    }
}
