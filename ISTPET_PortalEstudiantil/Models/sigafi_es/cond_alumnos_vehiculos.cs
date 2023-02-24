using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cond_alumnos_vehiculos
{
    public int idAsignacion { get; set; }

    public string idAlumno { get; set; } = null!;

    public int idVehiculo { get; set; }

    public string idPeriodo { get; set; } = null!;

    public string? idProfesor { get; set; }

    public DateTime fechaAsignacion { get; set; }

    public DateTime? fechaInicio { get; set; }

    public DateTime? fechaFin { get; set; }

    public sbyte? activa { get; set; }

    public string? observacion { get; set; }
}
