using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class periodos_matriculas_niveles
{
    public string idPeriodo { get; set; } = null!;

    public int idNivel { get; set; }

    public int idSeccion { get; set; }

    public sbyte? activo { get; set; }
}
