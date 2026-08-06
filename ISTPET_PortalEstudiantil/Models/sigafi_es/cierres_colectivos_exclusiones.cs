using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

/// <summary>
/// Registro de personal exceptuado de los descuentos de cierres institucionales
/// </summary>
public partial class cierres_colectivos_exclusiones
{
    public int id_exclusion { get; set; }

    /// <summary>
    /// Cierre colectivo del que se le excluye
    /// </summary>
    public int id_cierre { get; set; }

    /// <summary>
    /// Profesor exento (ej. personal de contabilidad que trabaja)
    /// </summary>
    public string id_profesor { get; set; } = null!;

    public virtual cierres_colectivos id_cierreNavigation { get; set; } = null!;

    public virtual profesores id_profesorNavigation { get; set; } = null!;
}
