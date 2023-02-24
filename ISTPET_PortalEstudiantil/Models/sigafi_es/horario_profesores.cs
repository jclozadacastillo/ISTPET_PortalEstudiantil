using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class horario_profesores
{
    public int idHorario { get; set; }

    public int? idAsignacion { get; set; }

    public int? idHora { get; set; }

    public int? idFecha { get; set; }

    public sbyte? asiste { get; set; }

    public sbyte? activo { get; set; }
}
