﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class restricciones
{
    public string idrestriccion { get; set; } = null!;

    public string? restriccion { get; set; }

    public ulong? activo { get; set; }
}
