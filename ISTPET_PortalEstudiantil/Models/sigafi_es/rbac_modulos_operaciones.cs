using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class rbac_modulos_operaciones
{
    public int idModulosOperaciones { get; set; }

    public int idModulos { get; set; }

    public int idOperaciones { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual rbac_modulos idModulosNavigation { get; set; } = null!;

    public virtual rbac_operaciones idOperacionesNavigation { get; set; } = null!;

    public virtual ICollection<rbac_rol_modulo_operacion> rbac_rol_modulo_operacion { get; set; } = new List<rbac_rol_modulo_operacion>();
}
