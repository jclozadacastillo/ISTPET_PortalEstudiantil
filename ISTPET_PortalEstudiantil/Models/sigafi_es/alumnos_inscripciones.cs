﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class alumnos_inscripciones
{
    public int idInscripcion { get; set; }

    public string? idalumno { get; set; }

    public string? idPeriodo { get; set; }

    public int? idModalidad { get; set; }

    public int? idNivel { get; set; }

    public int? idSeccion { get; set; }

    public DateTime fechaRegistro { get; set; }

    public string? usuario { get; set; }

    public sbyte? activo { get; set; }

    public int? idMedio { get; set; }
}
