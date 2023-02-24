using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class matriculas_examen_conduccion
{
    public int idMatricula { get; set; }

    public int idCategoria { get; set; }

    public int? nota { get; set; }

    public string? observacion { get; set; }

    public string? usuario { get; set; }

    public DateTime? fechaExamen { get; set; }

    public DateTime fechaIngreso { get; set; }

    public string? instructor { get; set; }
}
