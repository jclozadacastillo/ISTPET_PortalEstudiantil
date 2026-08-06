using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tiposangre
{
    public string codigoTipoSangre { get; set; } = null!;

    public string? grupo { get; set; }

    public sbyte? sitemaRH { get; set; }

    public virtual ICollection<profesores> profesores { get; set; } = new List<profesores>();
}
