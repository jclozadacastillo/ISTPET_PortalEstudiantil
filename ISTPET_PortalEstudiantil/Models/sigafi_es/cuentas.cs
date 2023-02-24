using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cuentas
{
    public int idCuenta { get; set; }

    public string cuenta { get; set; } = null!;

    public string numero_cuenta { get; set; } = null!;

    public bool activo { get; set; }

    public byte esingreso { get; set; }
}
