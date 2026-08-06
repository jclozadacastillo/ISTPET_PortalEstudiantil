using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_tipo_vivienda
{
    public int idTipoVivienda { get; set; }

    public string detalle { get; set; } = null!;

    public virtual ICollection<bien_ficha_socioeconomica> bien_ficha_socioeconomica { get; set; } = new List<bien_ficha_socioeconomica>();
}
