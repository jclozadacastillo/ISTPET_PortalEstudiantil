using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class pagos
    {
        public pagos()
        {
            detalle_pagos = new HashSet<detalle_pagos>();
            detalles_documentos_pagos = new HashSet<detalles_documentos_pagos>();
        }

        public int idPago { get; set; }
        public int? idMatricula { get; set; }
        public int? idCuenta { get; set; }
        public string factura { get; set; }
        public string numero_deposito { get; set; }
        public DateTime? fecha_deposito { get; set; }
        public decimal? valor { get; set; }
        public decimal? descuento { get; set; }
        public string observacion { get; set; }
        public string tipo_documento { get; set; }
        public byte? anulado { get; set; }
        public DateTime? fecha_anulacion { get; set; }
        public int? numero_registro { get; set; }
        public byte? numero_excepcion { get; set; }
        public string user_pago { get; set; }
        public byte? genera_manual { get; set; }
        public string documentoFactura { get; set; }
        public bool? migradoContabilidad { get; set; }

        public virtual ICollection<detalle_pagos> detalle_pagos { get; set; }
        public virtual ICollection<detalles_documentos_pagos> detalles_documentos_pagos { get; set; }
    }
}
