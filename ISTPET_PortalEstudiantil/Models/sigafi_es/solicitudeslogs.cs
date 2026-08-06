using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class solicitudeslogs
{
    public int idLogSolicitud { get; set; }

    public int? idSolicitud { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public string? detalle { get; set; }

    public int? idRespuestaSolicitud { get; set; }
}
