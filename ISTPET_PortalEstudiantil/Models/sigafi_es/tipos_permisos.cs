using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Configuración parametrizable de tipos de permisos y licencias
/// </summary>
public partial class tipos_permisos
{
    public int id_tipo_permiso { get; set; }

    /// <summary>
    /// Nombre del permiso (ej. Médico, Calamidad, Personal)
    /// </summary>
    public string nombre { get; set; } = null!;

    /// <summary>
    /// HORAS o DIAS
    /// </summary>
    public string unidad { get; set; } = null!;

    /// <summary>
    /// 1 si es mandatorio adjuntar foto/pdf justificativo
    /// </summary>
    public bool requiere_adjunto { get; set; }

    /// <summary>
    /// 0 para deshabilitado/eliminado lógico
    /// </summary>
    public bool? activo { get; set; }

    public virtual ICollection<permisos> permisos { get; set; } = new List<permisos>();
}
