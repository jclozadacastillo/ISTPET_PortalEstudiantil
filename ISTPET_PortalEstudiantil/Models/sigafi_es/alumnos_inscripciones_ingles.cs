﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class alumnos_inscripciones_ingles
{
    public string idAlumno { get; set; } = null!;

    public string idPeriodo { get; set; } = null!;

    public DateTime fechaRegistro { get; set; }

    public string? user_inscripcion { get; set; }

    public decimal? puntaje { get; set; }

    public int? idAsignatura { get; set; }

    public int? idMalla { get; set; }

    public string? observacion { get; set; }
}
