using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class sedddetallecoevaluacionautoridad
{
    public int idDetalle { get; set; }

    public int? idTest { get; set; }

    public int? idPregunta { get; set; }

    public int? respuesta { get; set; }

    public virtual seddpreguntas? idPreguntaNavigation { get; set; }

    public virtual seddcoevaluacionautoridad? idTestNavigation { get; set; }
}
