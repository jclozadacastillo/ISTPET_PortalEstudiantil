using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class asignaturas
{
    public int idAsignatura { get; set; }

    public string? asignatura { get; set; }

    public bool? anulada { get; set; }

    public string? codigo { get; set; }

    public virtual ICollection<calificaciones> calificaciones { get; set; } = new List<calificaciones>();

    public virtual ICollection<detallemallas> detallemallas { get; set; } = new List<detallemallas>();

    public virtual ICollection<prerequisitos> prerequisitos { get; set; } = new List<prerequisitos>();
}
