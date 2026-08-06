using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class experiencias_laborales
{
    public int idexperiencias_laborales { get; set; }

    public string? idAlumno { get; set; }

    public string? empresa_nombre { get; set; }

    public string? puesto_nombre { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public DateTime? fecha_fin { get; set; }

    public string? descripcion { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public virtual alumnos? idAlumnoNavigation { get; set; }
}
