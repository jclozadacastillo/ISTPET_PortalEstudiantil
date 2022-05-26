using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class horas_clases
    {
        public int idhora { get; set; }
        public int? idSeccion { get; set; }
        public int? idCarrera { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fin { get; set; }
        public int? minutos { get; set; }
        public int? numero_hora { get; set; }
        public string tipo { get; set; }
        public byte? activo { get; set; }
    }
}
