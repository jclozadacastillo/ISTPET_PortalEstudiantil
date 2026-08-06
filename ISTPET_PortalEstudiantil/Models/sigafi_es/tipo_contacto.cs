using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipo_contacto
{
    public int idtipo_contacto { get; set; }

    public string? nombre_contacto { get; set; }

    public string? longitud_contacto { get; set; }

    public virtual ICollection<empresas_contactos> empresas_contactos { get; set; } = new List<empresas_contactos>();
}
