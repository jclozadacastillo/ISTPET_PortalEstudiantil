using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class periodos
    {
        public periodos()
        {
            matriculas = new HashSet<matriculas>();
        }

        public string idPeriodo { get; set; }
        public string detalle { get; set; }
        public DateTime? fecha_inicial { get; set; }
        public DateTime? fecha_final { get; set; }
        public bool? cerrado { get; set; }
        public DateTime? fecha_maxima_autocierre { get; set; }
        public bool? activo { get; set; }
        public bool? creditos { get; set; }
        public int? numero_pagos { get; set; }
        public DateTime? fecha_matrucla_extraordinaria { get; set; }
        public int? foliop { get; set; }
        public byte? permiteMatricula { get; set; }
        public byte? ingresoCalificaciones { get; set; }
        public byte? permiteCalificacionesInstituto { get; set; }
        public byte? periodoactivoinstituto { get; set; }

        public virtual ICollection<matriculas> matriculas { get; set; }
    }
}
