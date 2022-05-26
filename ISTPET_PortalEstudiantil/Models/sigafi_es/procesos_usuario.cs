using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class procesos_usuario
    {
        public string proceso { get; set; }
        public string usuario { get; set; }
        public byte? consultar { get; set; }
        public byte? insertar { get; set; }
        public byte? modificar { get; set; }
        public byte? eliminar { get; set; }
    }
}
