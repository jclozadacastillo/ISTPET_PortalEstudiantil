using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Historial de saldos y balances consolidados de vacaciones por periodo anual
/// </summary>
public partial class saldos_vacaciones
{
    public int id_saldo_vacaciones { get; set; }

    /// <summary>
    /// Cédula o ID del Profesor (Llave foránea a profesores)
    /// </summary>
    public string id_profesor { get; set; } = null!;

    /// <summary>
    /// Periodo anual correspondiente (ej. 2024-2025)
    /// </summary>
    public string periodo { get; set; } = null!;

    /// <summary>
    /// Días acumulados por derecho legal/ajustes
    /// </summary>
    public decimal dias_ganados { get; set; }

    /// <summary>
    /// Días de vacaciones gozados o descontados por permisos en este periodo
    /// </summary>
    public decimal dias_tomados { get; set; }

    /// <summary>
    /// Días transferidos de periodos anteriores no tomados
    /// </summary>
    public decimal dias_acumulados { get; set; }

    /// <summary>
    /// Fecha de última actualización
    /// </summary>
    public DateTime fecha_ultimo_calculo { get; set; }

    /// <summary>
    /// Indica si el saldo de este periodo está vigente
    /// </summary>
    public bool? activo { get; set; }

    public virtual profesores id_profesorNavigation { get; set; } = null!;
}
