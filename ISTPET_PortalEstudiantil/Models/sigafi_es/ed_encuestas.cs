﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ed_encuestas
{
    public int idEncuesta { get; set; }

    public string? nombre { get; set; }

    public string? descripcion { get; set; }

    public sbyte? activo { get; set; }
}
