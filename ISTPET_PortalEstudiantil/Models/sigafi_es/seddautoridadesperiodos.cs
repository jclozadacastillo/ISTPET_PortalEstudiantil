﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddautoridadesperiodos
{
    public int idAsignacion { get; set; }

    public int? idCarrera { get; set; }

    public string? idPeriodo { get; set; }

    public string? idProfesor { get; set; }

    public string? designacion { get; set; }

    public sbyte? activo { get; set; }
}
