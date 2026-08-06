using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class departamentos
{
    public int iddepartamentos { get; set; }

    public string? nombre_departamento { get; set; }

    public string? abreviacion { get; set; }

    public string? descripcion { get; set; }

    public virtual ICollection<ofertas_laborales> ofertas_laborales { get; set; } = new List<ofertas_laborales>();
}
