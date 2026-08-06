using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class rbac_usuario_rol
{
    public int idUsuarioRol { get; set; }

    public int idUsuario { get; set; }

    public int idRol { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual rbac_rol idRolNavigation { get; set; } = null!;

    public virtual usuarios idUsuarioNavigation { get; set; } = null!;
}
