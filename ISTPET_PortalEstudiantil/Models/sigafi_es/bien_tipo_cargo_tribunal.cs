using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_tipo_cargo_tribunal
{
    public int idTipoCargoTribunal { get; set; }

    public string detalle { get; set; } = null!;

    public sbyte? esRector { get; set; }

    public virtual ICollection<bien_tribunal> bien_tribunal { get; set; } = new List<bien_tribunal>();

    public virtual ICollection<bien_votos_tribunales> bien_votos_tribunales { get; set; } = new List<bien_votos_tribunales>();
}
