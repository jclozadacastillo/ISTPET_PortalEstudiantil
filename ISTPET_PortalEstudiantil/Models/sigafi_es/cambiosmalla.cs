using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cambiosmalla
{
    public int idCambioMalla { get; set; }

    public int idMalla { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Cambio { get; set; }

    public virtual mallas idMallaNavigation { get; set; } = null!;
}
