using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class pd_terminos_condiciones
{
    public int idTermino { get; set; }

    public int? idCategoria { get; set; }

    public string? versionTermino { get; set; }

    public string? contenido { get; set; }

    public DateTime? fechaPublicacion { get; set; }

    public DateTime fechaRegistro { get; set; }

    public string? archivoHtml { get; set; }

    public sbyte? esVigente { get; set; }
}
