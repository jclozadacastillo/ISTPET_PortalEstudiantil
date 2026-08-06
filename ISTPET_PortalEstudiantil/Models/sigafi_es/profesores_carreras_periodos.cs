using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores_carreras_periodos
{
    public int idProfesoresCarrerasPeriodos { get; set; }

    public string idPeriodo { get; set; } = null!;

    public string idProfesor { get; set; } = null!;

    public int? idCarrera { get; set; }

    public sbyte? esActivo { get; set; }

    public sbyte? sonTodas { get; set; }

    public virtual carreras? idCarreraNavigation { get; set; }

    public virtual periodos idPeriodoNavigation { get; set; } = null!;

    public virtual profesores idProfesorNavigation { get; set; } = null!;
}
