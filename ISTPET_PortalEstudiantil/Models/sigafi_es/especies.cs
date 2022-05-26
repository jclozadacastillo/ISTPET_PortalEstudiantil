using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class especies
    {
        public especies()
        {
            detalle_pagos = new HashSet<detalle_pagos>();
        }

        public int idEspecie { get; set; }
        public string especie { get; set; }
        public decimal valor { get; set; }
        public int numero_cuotas { get; set; }
        public int? prioridad { get; set; }
        public byte? permite_intercalar { get; set; }
        public string codigo_referencia { get; set; }
        public string idperiodo { get; set; }
        public decimal? extraordinaria { get; set; }

        public virtual ICollection<detalle_pagos> detalle_pagos { get; set; }
    }
}
