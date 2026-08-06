using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Libro Diario contable de transacciones de saldo de vacaciones (Odoo-Style)
/// </summary>
public partial class vacaciones_ledger
{
    public int id_ledger { get; set; }

    /// <summary>
    /// Profesor al que afecta la transacción
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// ACREDITACION, GOCE, DESCUENTO_PERMISO, CADUCIDAD, BONIFICACION_SEPT, AJUSTE_CREDITO, AJUSTE_DEBITO
    /// </summary>
    public string tipo_transaccion { get; set; } = null!;

    /// <summary>
    /// Crédito (+) o Débito (-) en días de vacaciones
    /// </summary>
    public decimal dias { get; set; }

    /// <summary>
    /// Fecha y hora de la transacción
    /// </summary>
    public DateTime fecha { get; set; }

    /// <summary>
    /// Periodo anual al que corresponde (ej. 2025-2026)
    /// </summary>
    public string periodo { get; set; } = null!;

    /// <summary>
    /// Detalle o descripción de la transacción
    /// </summary>
    public string detalle { get; set; } = null!;

    /// <summary>
    /// Usuario de RRHH (TH o RL) que ejecutó el registro
    /// </summary>
    public int? registrado_por_id { get; set; }

    public virtual profesores id_profesorNavigation { get; set; } = null!;

    public virtual usuarios? registrado_por { get; set; }
}
