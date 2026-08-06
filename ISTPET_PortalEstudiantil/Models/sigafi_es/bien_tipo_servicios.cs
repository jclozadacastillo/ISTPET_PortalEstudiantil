using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_tipo_servicios
{
    public int idTipoServicio { get; set; }

    public string nombre { get; set; } = null!;

    public sbyte esActivo { get; set; }

    public virtual ICollection<bien_servicios_fichas> bien_servicios_fichas { get; set; } = new List<bien_servicios_fichas>();
}
