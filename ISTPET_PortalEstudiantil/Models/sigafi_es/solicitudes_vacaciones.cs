using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Solicitudes individuales de vacaciones extraordinarias o fuera de planificación
/// </summary>
public partial class solicitudes_vacaciones
{
    public int id_solicitud { get; set; }

    /// <summary>
    /// Profesor solicitante
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// Fecha de salida
    /// </summary>
    public DateTime fecha_inicio { get; set; }

    /// <summary>
    /// Fecha de retorno
    /// </summary>
    public DateTime fecha_fin { get; set; }

    /// <summary>
    /// Días ininterrumpidos calculados
    /// </summary>
    public int dias_solicitados { get; set; }

    /// <summary>
    /// 1 = Fuera de planificación, 0 = Dentro
    /// </summary>
    public bool es_fuera_planificacion { get; set; }

    /// <summary>
    /// Fecha de creación de la solicitud
    /// </summary>
    public DateTime fecha_solicitud { get; set; }

    /// <summary>
    /// Ruta del archivo PDF de la solicitud física firmada
    /// </summary>
    public string? ruta_documento_escrito { get; set; }

    /// <summary>
    /// Pendiente, AprobadaTH, AprobadaRL, Rechazada
    /// </summary>
    public string estado { get; set; } = null!;

    /// <summary>
    /// Analista de Talento Humano que pre-aprueba
    /// </summary>
    public int? usuario_th { get; set; }

    public DateTime? fecha_aprobacion_th { get; set; }

    /// <summary>
    /// Representante Legal que autoriza definitivamente
    /// </summary>
    public int? usuario_rl { get; set; }

    public DateTime? fecha_aprobacion_rl { get; set; }

    public string? motivo_rechazo { get; set; }

    public string motivo_solicitud { get; set; } = null!;

    public virtual profesores id_profesorNavigation { get; set; } = null!;

    public virtual usuarios? usuario_rlNavigation { get; set; }

    public virtual usuarios? usuario_thNavigation { get; set; }
}
