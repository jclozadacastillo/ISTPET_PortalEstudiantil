using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Planificación institucional anual de vacaciones coordinada por TH
/// </summary>
public partial class planificacion_vacaciones
{
    public int id_planificacion { get; set; }

    /// <summary>
    /// Empleado planificado
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// Periodo vacacional de la planificación
    /// </summary>
    public string periodo { get; set; } = null!;

    /// <summary>
    /// Fecha de inicio del periodo planificado
    /// </summary>
    public DateTime fecha_inicio { get; set; }

    /// <summary>
    /// Fecha de fin del periodo planificado
    /// </summary>
    public DateTime fecha_fin { get; set; }

    /// <summary>
    /// Total de días calendario planificados
    /// </summary>
    public int dias_planificados { get; set; }

    /// <summary>
    /// Borrador, Presentada, Aprobada, Rechazada
    /// </summary>
    public string estado { get; set; } = null!;

    /// <summary>
    /// Fecha de registro
    /// </summary>
    public DateTime fecha_planificacion { get; set; }

    /// <summary>
    /// Usuario de TH que registra (Llave foránea a usuarios)
    /// </summary>
    public int usuario_creo { get; set; }

    /// <summary>
    /// Representante Legal que autoriza (Llave foránea a usuarios)
    /// </summary>
    public int? usuario_autorizo { get; set; }

    /// <summary>
    /// Fecha de autorización
    /// </summary>
    public DateTime? fecha_autorizacion { get; set; }

    /// <summary>
    /// Observaciones administrativas
    /// </summary>
    public string? observaciones { get; set; }

    public virtual profesores id_profesorNavigation { get; set; } = null!;

    public virtual usuarios? usuario_autorizoNavigation { get; set; }

    public virtual usuarios usuario_creoNavigation { get; set; } = null!;
}
