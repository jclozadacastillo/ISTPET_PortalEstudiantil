using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class profesores_actas_parciales
    {
        public int idAsignacion { get; set; }
        public int idParcial { get; set; }
        public byte? activo { get; set; }
        public string codigo_impresion { get; set; }
        public byte? entrega_acta { get; set; }
        public byte? ingresa_notas { get; set; }
        public string usuario_graba { get; set; }
    }
}
