using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class periodos_matriculas_niveles
    {
        public string idPeriodo { get; set; }
        public int idNivel { get; set; }
        public int idSeccion { get; set; }
        public byte? activo { get; set; }
    }
}
