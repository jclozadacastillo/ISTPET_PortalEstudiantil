using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class instituciones_instituto
{
    public int idInstitucionesInstituto { get; set; }

    public string? nombre { get; set; }

    public string? ruc { get; set; }

    public string? ubicado { get; set; }

    public string? representante { get; set; }

    public string? cedula_representante { get; set; }

    public virtual ICollection<contratos> contratos { get; set; } = new List<contratos>();

    public virtual ICollection<plantilla_contrato> plantilla_contrato { get; set; } = new List<plantilla_contrato>();
}
