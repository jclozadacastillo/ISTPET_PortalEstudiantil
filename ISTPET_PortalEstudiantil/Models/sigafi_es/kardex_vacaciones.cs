using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Transacciones del Kardex contable de vacaciones (Libro Mayor)
/// </summary>
public partial class kardex_vacaciones
{
    public int id_kardex { get; set; }

    /// <summary>
    /// Profesor al que se le afecta el saldo
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// Fecha en que se realiza la transacción
    /// </summary>
    public DateTime fecha_transaccion { get; set; }

    /// <summary>
    /// ASIGNACION_ANUAL, CONSUMO_VACACIONES, AJUSTE_ADMINISTRATIVO, PRESCRIPCION
    /// </summary>
    public string tipo_transaccion { get; set; } = null!;

    /// <summary>
    /// Días afectados: (+) Cargas anuales, (-) Descuentos por consumo o prescripción
    /// </summary>
    public decimal cantidad_dias { get; set; }

    /// <summary>
    /// Periodo anual correspondiente (ej. 2024-2025)
    /// </summary>
    public string periodo { get; set; } = null!;

    /// <summary>
    /// Detalle o justificación contable de la transacción
    /// </summary>
    public string detalle { get; set; } = null!;

    /// <summary>
    /// Usuario del sistema (TH o RL) que realiza el movimiento
    /// </summary>
    public int usuario_responsable { get; set; }

    public virtual profesores id_profesorNavigation { get; set; } = null!;

    public virtual usuarios usuario_responsableNavigation { get; set; } = null!;
}
