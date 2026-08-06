using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class habilidades_requeridas
{
    public int idhabilidades_requeridas { get; set; }

    public int idofertas_laborales { get; set; }

    public int idhabilidades { get; set; }

    public string? nivel { get; set; }

    public sbyte? es_obligatoria { get; set; }

    public virtual habilidades idhabilidadesNavigation { get; set; } = null!;

    public virtual ofertas_laborales idofertas_laboralesNavigation { get; set; } = null!;
}
