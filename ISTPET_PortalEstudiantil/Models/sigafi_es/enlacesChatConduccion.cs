using System;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class enlacesChatConduccion
{
    public int idEnlace { get; set; }

    public string? idPeriodo { get; set; }

    public int? idNivel { get; set; }

    public int? idModalidad { get; set; }

    public int? idSeccion { get; set; }

    public string? paralelo { get; set; }

    public string? enlace { get; set; }

    public sbyte? activo { get; set; }

    public DateTime? fechaRegistro { get; set; }
}
