using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class fechas_horarios
    {
        public int idFecha { get; set; }
        public DateTime? fecha { get; set; }
        public byte? finsemana { get; set; }
        public string dia { get; set; }
    }
}
