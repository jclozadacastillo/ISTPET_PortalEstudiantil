using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class asignaciones_propedeutico
{
    public int idCarrera { get; set; }

    public int idAsignatura { get; set; }

    public sbyte? activa { get; set; }
}
