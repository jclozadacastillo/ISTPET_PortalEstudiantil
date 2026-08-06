using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_requisitos_beca
{
    public int idRequistosBeca { get; set; }

    public string requisito { get; set; } = null!;

    public string tipoRequisito { get; set; } = null!;

    public sbyte esActivo { get; set; }

    public virtual ICollection<bien_parametro_requisito_beca> bien_parametro_requisito_beca { get; set; } = new List<bien_parametro_requisito_beca>();
}
