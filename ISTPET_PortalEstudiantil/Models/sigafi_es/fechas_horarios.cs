using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class fechas_horarios
{
    public int idFecha { get; set; }

    public DateTime? fecha { get; set; }

    public sbyte? finsemana { get; set; }

    public string? dia { get; set; }
}
