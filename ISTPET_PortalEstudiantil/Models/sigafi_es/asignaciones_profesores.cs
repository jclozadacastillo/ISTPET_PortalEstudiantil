using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class asignaciones_profesores
{
    public string idProfesor { get; set; } = null!;

    public int idAsignatura { get; set; }

    public string idPeriodo { get; set; } = null!;

    public int idModalidad { get; set; }

    public int idSeccion { get; set; }

    public int idNivel { get; set; }

    public string paralelo { get; set; } = null!;

    public sbyte? activo { get; set; }

    public DateTime? fecha_grabar { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public string? codigo_asignacion { get; set; }

    public sbyte? entrega_acta { get; set; }

    public sbyte? ingresa_notas { get; set; }

    public string? user_asignaciones { get; set; }

    public DateTime? fecha_fin { get; set; }

    public DateTime? fecha_inicial { get; set; }

    public string? user_acta { get; set; }

    public int idAsignacion { get; set; }

    public sbyte? esActivaAsignacion { get; set; }
}
