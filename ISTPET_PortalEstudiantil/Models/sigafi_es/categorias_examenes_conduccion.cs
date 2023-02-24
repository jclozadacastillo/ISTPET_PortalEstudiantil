using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class categorias_examenes_conduccion
{
    public int IdCategoria { get; set; }

    public string? categoria { get; set; }

    public sbyte? tieneNota { get; set; }

    public sbyte? activa { get; set; }
}
