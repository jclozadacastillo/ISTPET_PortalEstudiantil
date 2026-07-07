using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class motivos_becas
{
    public int idMotivo { get; set; }

    public int? idTipoApoyo { get; set; }

    public string? motivo { get; set; }

    public sbyte? activo { get; set; }

    public DateTime? fechaRegistro { get; set; }
}
