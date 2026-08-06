using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionprogramas
{
    public int idPrograma { get; set; }

    public string? programa { get; set; }

    public string? descripcion { get; set; }

    public DateTime? fechaInicio { get; set; }

    public DateTime? fechaFin { get; set; }

    public sbyte? activo { get; set; }
}
