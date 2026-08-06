using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class rbac_rol_modulo_operacion
{
    public int idRolModuloOperacion { get; set; }

    public int idModulosOperaciones { get; set; }

    public int idRol { get; set; }

    public DateTime? fecha_asignacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public DateTime? fecha_desactivacion { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual rbac_modulos_operaciones idModulosOperacionesNavigation { get; set; } = null!;

    public virtual rbac_rol idRolNavigation { get; set; } = null!;
}
