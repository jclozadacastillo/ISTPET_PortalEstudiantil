using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Registro de permisos y licencias por horas o días con soporte de adjuntos
/// </summary>
public partial class permisos
{
    public int id_permiso { get; set; }

    /// <summary>
    /// Empleado que solicita el permiso
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// Referencia al tipo de permiso configurado
    /// </summary>
    public int id_tipo_permiso { get; set; }

    /// <summary>
    /// Cantidad de horas de la ausencia (si es tipo HORAS)
    /// </summary>
    public decimal? horas { get; set; }

    /// <summary>
    /// Cantidad de días de la ausencia (si es tipo DIAS)
    /// </summary>
    public decimal? dias { get; set; }

    /// <summary>
    /// PENDIENTE_RECUPERACION, RECUPERADO, DESCONTADO, JUSTIFICADO
    /// </summary>
    public string estado { get; set; } = null!;

    /// <summary>
    /// Fecha del permiso/evento
    /// </summary>
    public DateTime fecha_suceso { get; set; }

    /// <summary>
    /// Fecha de registro
    /// </summary>
    public DateTime fecha_solicitud { get; set; }

    /// <summary>
    /// Justificación o descripción detallada
    /// </summary>
    public string motivo { get; set; } = null!;

    /// <summary>
    /// Ruta de archivo adjunto (Foto o PDF)
    /// </summary>
    public string? ruta_justificativo { get; set; }

    /// <summary>
    /// Fecha de carga del archivo justificativo
    /// </summary>
    public DateTime? fecha_entrega_justificativo { get; set; }

    /// <summary>
    /// Usuario de RRHH que aprueba/autoriza el permiso
    /// </summary>
    public int? aprobado_por_id { get; set; }

    /// <summary>
    /// Notas de RRHH sobre el acuerdo verbal de recuperación o justificación
    /// </summary>
    public string? notas_rrhh { get; set; }

    public virtual usuarios? aprobado_por { get; set; }

    public virtual profesores id_profesorNavigation { get; set; } = null!;

    public virtual tipos_permisos id_tipo_permisoNavigation { get; set; } = null!;

    public virtual ICollection<recuperacion_tiempo> recuperacion_tiempo { get; set; } = new List<recuperacion_tiempo>();
}
