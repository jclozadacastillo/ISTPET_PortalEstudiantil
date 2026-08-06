using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class usuariossolicitudes
{
    public int idUsuarioSolicitud { get; set; }

    public string? usuario { get; set; }

    public string? clave { get; set; }

    public sbyte? resetear { get; set; }

    public string? email { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? Administrador { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<usuariosdepartamentossolicitudes> usuariosdepartamentossolicitudes { get; set; } = new List<usuariosdepartamentossolicitudes>();
}
