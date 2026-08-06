using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_parentezcos_alumno
{
    public int idParentezcoAlumno { get; set; }

    public int idParentezco { get; set; }

    public string idAlumno { get; set; } = null!;

    public int? idpaises { get; set; }

    public int? idNivelInstruccion { get; set; }

    public string nombre { get; set; } = null!;

    public decimal? ingresoMensualPromedio { get; set; }

    public sbyte esResponsableEconomico { get; set; }

    public sbyte contactoEmergencia { get; set; }

    public string? numeroContactoEmergencia { get; set; }

    public sbyte? esCarga { get; set; }

    public sbyte? tieneDiscapacidad { get; set; }

    public sbyte esActivo { get; set; }

    public virtual alumnos idAlumnoNavigation { get; set; } = null!;

    public virtual bien_nivel_instruccion? idNivelInstruccionNavigation { get; set; }

    public virtual bien_parentescos idParentezcoNavigation { get; set; } = null!;

    public virtual paises? idpaisesNavigation { get; set; }
}
