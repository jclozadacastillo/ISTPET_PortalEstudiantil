using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_datos_educacion
{
    public int idDatosEducacion { get; set; }

    public string nombreCurso { get; set; } = null!;

    public string? nombreInstitucion { get; set; }

    public sbyte esIstpet { get; set; }

    public string nivelEducacion { get; set; } = null!;

    public sbyte estaCursando { get; set; }

    public sbyte esPresencial { get; set; }

    public sbyte esBecado { get; set; }

    public string tipoEducacion { get; set; } = null!;

    public string idAlumno { get; set; } = null!;

    public virtual alumnos idAlumnoNavigation { get; set; } = null!;
}
