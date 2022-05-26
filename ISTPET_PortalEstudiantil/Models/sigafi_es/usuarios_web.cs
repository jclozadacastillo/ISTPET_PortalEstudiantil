using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class usuarios_web
    {
        public string usuario { get; set; }
        public string password { get; set; }
        public byte? salida { get; set; }
        public byte? ingreso { get; set; }
        public byte? activo { get; set; }
        public byte? asistencia { get; set; }
    }
}
