using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class financiamiento_beca
{
    public int idFinanciamiento { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<titulos_en_curso> titulos_en_curso { get; set; } = new List<titulos_en_curso>();
}
