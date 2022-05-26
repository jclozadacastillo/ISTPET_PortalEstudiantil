using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class asignaciones_propedeutico
    {
        public int idCarrera { get; set; }
        public int idAsignatura { get; set; }
        public byte? activa { get; set; }
    }
}
