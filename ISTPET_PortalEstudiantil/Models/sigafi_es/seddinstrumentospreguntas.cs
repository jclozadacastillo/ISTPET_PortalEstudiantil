using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddinstrumentospreguntas
{
    public int idInstrumentoPregunta { get; set; }

    public int? idInstrumento { get; set; }

    public int? idPregunta { get; set; }

    public DateTime fechaRegistro { get; set; }

    public sbyte? activo { get; set; }

    public virtual seddinstrumentos? idInstrumentoNavigation { get; set; }

    public virtual seddpreguntas? idPreguntaNavigation { get; set; }
}
