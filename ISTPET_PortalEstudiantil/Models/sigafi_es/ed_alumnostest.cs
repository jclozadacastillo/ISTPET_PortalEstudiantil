﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ed_alumnostest
{
    public int idIngresoTest { get; set; }

    public int? idMatricula { get; set; }

    public int? idTest { get; set; }

    public string? idProfesor { get; set; }

    public DateTime fecha { get; set; }

    public sbyte? culminado { get; set; }

    public DateTime fecha_modificacion { get; set; }
}
