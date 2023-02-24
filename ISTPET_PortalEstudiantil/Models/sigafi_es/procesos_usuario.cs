using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class procesos_usuario
{
    public string? proceso { get; set; }

    public string? usuario { get; set; }

    public sbyte? consultar { get; set; }

    public sbyte? insertar { get; set; }

    public sbyte? modificar { get; set; }

    public sbyte? eliminar { get; set; }
}
