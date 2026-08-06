using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Asignaciones individuales directas de vacaciones programadas por RRHH
/// </summary>
public partial class asignaciones_vacaciones
{
    public int id_asignacion { get; set; }

    /// <summary>
    /// Profesor asignado
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// Fecha de inicio del descanso
    /// </summary>
    public DateTime fecha_inicio { get; set; }

    /// <summary>
    /// Fecha de finalización del descanso
    /// </summary>
    public DateTime fecha_fin { get; set; }

    /// <summary>
    /// Total de días calendario calculados a descontar
    /// </summary>
    public int dias_asignados { get; set; }

    /// <summary>
    /// Fecha de registro de la asignación
    /// </summary>
    public DateTime fecha_creacion { get; set; }

    /// <summary>
    /// Usuario de RRHH que realiza el registro directo
    /// </summary>
    public int registrado_por_id { get; set; }

    /// <summary>
    /// Justificación o notas de Talento Humano
    /// </summary>
    public string observacion_rrhh { get; set; } = null!;

    public virtual profesores id_profesorNavigation { get; set; } = null!;

    public virtual usuarios registrado_por { get; set; } = null!;
}
