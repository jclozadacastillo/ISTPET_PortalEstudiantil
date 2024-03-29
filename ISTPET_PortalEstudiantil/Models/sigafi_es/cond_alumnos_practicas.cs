﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cond_alumnos_practicas
{
    public int idPractica { get; set; }

    public string idalumno { get; set; } = null!;

    public int idvehiculo { get; set; }

    public string idProfesor { get; set; } = null!;

    public string idPeriodo { get; set; } = null!;

    public string? dia { get; set; }

    public DateTime fecha { get; set; }

    public TimeSpan? hora_salida { get; set; }

    public TimeSpan? hora_llegada { get; set; }

    public TimeSpan? tiempo { get; set; }

    public bool? ensalida { get; set; }

    public bool? verificada { get; set; }

    public string? user_asigna { get; set; }

    public string? user_llegada { get; set; }

    public bool? cancelado { get; set; }
}
