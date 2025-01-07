using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddinsitu
{
    public int idEvaluacion { get; set; }

    public int? idInstrumento { get; set; }

    public string? idPeriodo { get; set; }

    public string? idProfesor { get; set; }

    public DateTime fechaRegistro { get; set; }

    public decimal? calificacion { get; set; }

    public string? idEvaluador { get; set; }

    public DateTime? fechaActualizacion { get; set; }

    public virtual seddinstrumentos? idInstrumentoNavigation { get; set; }
}
