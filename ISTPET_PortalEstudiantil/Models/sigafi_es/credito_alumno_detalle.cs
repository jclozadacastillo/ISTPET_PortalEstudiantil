using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class credito_alumno_detalle
{
    public int idCreditoAlumnoDetalle { get; set; }

    public int? idCredito { get; set; }

    public DateTime? fecha_pago { get; set; }

    public decimal? valorCuota { get; set; }

    public decimal? valorAbonado { get; set; }

    public sbyte? cancelado { get; set; }
}
