﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tiposdocumentosi
{
    public string tipoDocumento { get; set; } = null!;

    public string? documento { get; set; }

    public sbyte? activo { get; set; }
}
