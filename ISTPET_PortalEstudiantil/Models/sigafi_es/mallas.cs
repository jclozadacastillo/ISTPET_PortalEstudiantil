using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class mallas
{
    public int idMalla { get; set; }

    public int idCarrera { get; set; }

    public int? vigencia { get; set; }

    public string? descripcion { get; set; }

    public int? creditos_minimo { get; set; }

    public int? creditos_maximo { get; set; }

    public int? creditos_reprobatorio { get; set; }

    public bool? activa { get; set; }

    public virtual ICollection<cambiosmalla> cambiosmalla { get; set; } = new List<cambiosmalla>();

    public virtual ICollection<detallemallas> detallemallas { get; set; } = new List<detallemallas>();

    public virtual carreras idCarreraNavigation { get; set; } = null!;
}
