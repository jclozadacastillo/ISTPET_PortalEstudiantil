using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class departamentossolicitudes
{
    public int idDepartamentoSolicitud { get; set; }

    public string? departamento { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<tipossolicitudes> tipossolicitudes { get; set; } = new List<tipossolicitudes>();
}
