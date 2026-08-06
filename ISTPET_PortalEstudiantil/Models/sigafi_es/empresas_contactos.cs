using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class empresas_contactos
{
    public int idempresas_contactos { get; set; }

    public string idempresa { get; set; } = null!;

    public int idtipo_contacto { get; set; }

    public string? valor { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public virtual empresas idempresaNavigation { get; set; } = null!;

    public virtual tipo_contacto idtipo_contactoNavigation { get; set; } = null!;
}
