using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class etnias
{
    public int idEtnia { get; set; }

    public string? etnia { get; set; }

    public sbyte? esIndigena { get; set; }

    public sbyte? noRegistra { get; set; }
}
