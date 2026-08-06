using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Configuración de descansos y vacaciones obligatorias masivas institucionales
/// </summary>
public partial class cierres_colectivos
{
    public int id_cierre { get; set; }

    /// <summary>
    /// Nombre del cierre colectivo (ej. Cierre Fin de Año 2025)
    /// </summary>
    public string nombre { get; set; } = null!;

    /// <summary>
    /// Fecha de inicio del descanso colectivo
    /// </summary>
    public DateTime fecha_inicio { get; set; }

    /// <summary>
    /// Fecha de fin del descanso colectivo
    /// </summary>
    public DateTime fecha_fin { get; set; }

    /// <summary>
    /// Cantidad de días a descontar del ledger (ej. 12 días)
    /// </summary>
    public decimal dias_descuento { get; set; }

    /// <summary>
    /// Fecha de registro de la configuración
    /// </summary>
    public DateTime fecha_creacion { get; set; }

    /// <summary>
    /// Usuario de RRHH que lo configura (Llave foránea a usuarios)
    /// </summary>
    public int registrado_por_id { get; set; }

    public virtual ICollection<cierres_colectivos_exclusiones> cierres_colectivos_exclusiones { get; set; } = new List<cierres_colectivos_exclusiones>();

    public virtual usuarios registrado_por { get; set; } = null!;
}
