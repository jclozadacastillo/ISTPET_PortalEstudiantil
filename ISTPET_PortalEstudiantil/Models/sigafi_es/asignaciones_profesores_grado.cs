using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class asignaciones_profesores_grado
{
    public string idProfesor { get; set; } = null!;

    public int idAsignatura { get; set; }

    public string idPeriodo { get; set; } = null!;

    public int idModalidad { get; set; }

    public int idSeccion { get; set; }

    public int idNivel { get; set; }

    public string paralelo { get; set; } = null!;

    public sbyte? activo { get; set; }
}
