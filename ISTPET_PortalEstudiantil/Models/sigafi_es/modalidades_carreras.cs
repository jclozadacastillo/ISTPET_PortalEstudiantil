using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class modalidades_carreras
{
    public int idModalidadCarrera { get; set; }

    public int idCarrera { get; set; }

    public int idModalidad { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual carreras idCarreraNavigation { get; set; } = null!;

    public virtual modalidades idModalidadNavigation { get; set; } = null!;
}
