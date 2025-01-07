using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddautoriadesperiodos
{
    public int idAsignacion { get; set; }

    public string? idProfesor { get; set; }

    public string? designacion { get; set; }

    public int? idInstrumento { get; set; }

    public sbyte? activo { get; set; }
}
