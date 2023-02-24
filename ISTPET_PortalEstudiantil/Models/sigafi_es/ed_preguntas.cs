using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class ed_preguntas
{
    public int IdPregunta { get; set; }

    public int? idEncuesta { get; set; }

    public string? pregunta { get; set; }

    public int? orden { get; set; }

    public sbyte? activa { get; set; }

    public sbyte? esAbierta { get; set; }
}
