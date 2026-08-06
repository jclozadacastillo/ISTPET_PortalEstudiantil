using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Plantillas dinámicas para la generación de reportes y actas en Word
/// </summary>
public partial class plantillas_documentos
{
    public int id_plantilla { get; set; }

    /// <summary>
    /// Código único de la plantilla (ej. ACTA_VACACIONES)
    /// </summary>
    public string codigo { get; set; } = null!;

    /// <summary>
    /// Nombre descriptivo del reporte
    /// </summary>
    public string nombre { get; set; } = null!;

    /// <summary>
    /// Texto enriquecido con variables {{...}}
    /// </summary>
    public string cuerpo { get; set; } = null!;

    public bool? activo { get; set; }

    public DateTime fecha_actualizacion { get; set; }
}
