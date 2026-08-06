using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Detalle transaccional de la recuperación de horas de permisos personales
/// </summary>
public partial class recuperacion_tiempo
{
    public int id_recuperacion { get; set; }

    /// <summary>
    /// Referencia al permiso personal que se está recuperando
    /// </summary>
    public int id_permiso { get; set; }

    /// <summary>
    /// Fecha en la que el empleado recuperó el tiempo (ej. sábado)
    /// </summary>
    public DateTime fecha_recuperada { get; set; }

    /// <summary>
    /// Horas recuperadas en esta fecha
    /// </summary>
    public decimal horas { get; set; }

    /// <summary>
    /// Fecha de registro de la recuperación
    /// </summary>
    public DateTime fecha_registro { get; set; }

    /// <summary>
    /// Analista de TH que convalida
    /// </summary>
    public int usuario_th { get; set; }

    public virtual permisos id_permisoNavigation { get; set; } = null!;

    public virtual usuarios usuario_thNavigation { get; set; } = null!;
}
