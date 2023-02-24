using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores_actividades
{
    public string idPeriodo { get; set; } = null!;

    public string idProfesor { get; set; } = null!;

    public int idSubcategoria { get; set; }

    public int? horas_semana { get; set; }

    public string? usuario { get; set; }

    public DateTime? fecha { get; set; }
}
