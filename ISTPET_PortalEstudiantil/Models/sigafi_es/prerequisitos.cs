using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class prerequisitos
{
    public int idDetalleMalla { get; set; }

    public int idAsignatura { get; set; }

    public sbyte? activa { get; set; }

    public virtual asignaturas idAsignaturaNavigation { get; set; } = null!;

    public virtual detallemallas idDetalleMallaNavigation { get; set; } = null!;
}
