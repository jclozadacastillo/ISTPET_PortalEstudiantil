using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class especies_extras
    {
        public int idmatricula { get; set; }
        public int idespecie { get; set; }
        public DateTime fecha_registro { get; set; }
        public decimal valor { get; set; }
        public DateTime fecha_limite_pago { get; set; }
        public string observacion { get; set; }
        public bool obligatoria { get; set; }
        public decimal pagado { get; set; }
        public bool extra { get; set; }
        public string tipo { get; set; }
    }
}
