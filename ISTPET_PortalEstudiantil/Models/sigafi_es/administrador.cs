using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class administrador
{
    public string idAdministrador { get; set; } = null!;

    public string? NombresCompletos { get; set; }

    public string? ApellidosCompletos { get; set; }

    public string? password { get; set; }

    public sbyte? esAdministrador { get; set; }

    public DateTime? fecha_Asignacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public sbyte? esActivo { get; set; }

    public sbyte? primerIngreso { get; set; }
}
