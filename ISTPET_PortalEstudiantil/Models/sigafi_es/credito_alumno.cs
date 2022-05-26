using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class credito_alumno
    {
        public int idMatricula { get; set; }
        public int idEspecie { get; set; }
        public decimal? credito_inicial { get; set; }
        public decimal? saldo { get; set; }
        public decimal? beca { get; set; }
        public decimal? saldo_beca { get; set; }
        public int? numero_cuotas { get; set; }
        public decimal? valor_cuotas { get; set; }
        public int idCredito { get; set; }
    }
}
