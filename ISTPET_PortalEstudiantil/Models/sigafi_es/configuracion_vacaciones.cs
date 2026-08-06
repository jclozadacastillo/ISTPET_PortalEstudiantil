using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Configuración de reglas generales de vacaciones (días por ley, límites)
/// </summary>
public partial class configuracion_vacaciones
{
    public int id_config { get; set; }

    /// <summary>
    /// Identificador único del parámetro
    /// </summary>
    public string clave { get; set; } = null!;

    /// <summary>
    /// Valor del parámetro
    /// </summary>
    public string valor { get; set; } = null!;

    /// <summary>
    /// Notas del parámetro
    /// </summary>
    public string? descripcion { get; set; }
}
