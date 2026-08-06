using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class respuestassolicitudes
{
    public int idRespuestaSolicitud { get; set; }

    public int? idSolicitud { get; set; }

    public int? idEstadoSolicitud { get; set; }

    public int? idUsuarioSolicitud { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public string? detalleRespuesta { get; set; }

    public sbyte? adjuntaArchivo { get; set; }

    public string? mailRespuesta { get; set; }

    public sbyte? envioMail { get; set; }

    public DateTime? fechaRespuesta { get; set; }

    public sbyte? activo { get; set; }

    public string? archivoAjunto { get; set; }

    public sbyte? revisarLogs { get; set; }

    public sbyte? adjuntarSoloArchivoAdjunto { get; set; }
}
