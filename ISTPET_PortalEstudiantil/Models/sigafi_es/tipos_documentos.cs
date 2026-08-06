using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipos_documentos
{
    public int idtipos_documentos { get; set; }

    public string? documento { get; set; }

    public string? subijo_documento { get; set; }

    public virtual ICollection<documentos_adjuntos> documentos_adjuntos { get; set; } = new List<documentos_adjuntos>();
}
