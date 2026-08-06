using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class horario_detalle
{
    public int idHorario { get; set; }

    public int idAsignacion { get; set; }

    public int idFecha { get; set; }

    public int idhora { get; set; }

    public int? idEspacio { get; set; }

    public string? tipoBloque { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? claseReasignacion { get; set; }

    public bool? esRecuperacionPedagocia { get; set; }

    public string? observacion { get; set; }

    public int? idHorarioReasgincacion { get; set; }

    public virtual asignaciones_profesores idAsignacionNavigation { get; set; } = null!;

    public virtual espacios? idEspacioNavigation { get; set; }

    public virtual fechas_horarios idFechaNavigation { get; set; } = null!;

    public virtual horas_clases idhoraNavigation { get; set; } = null!;
}
