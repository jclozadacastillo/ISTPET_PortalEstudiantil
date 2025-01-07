using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddcoevaluacionautoridad
{
    public int idTest { get; set; }

    public int? idInstrumento { get; set; }

    public string? idPeriodo { get; set; }

    public string? idProfesor { get; set; }

    public string? idEvaluador { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public DateTime? fechaTest { get; set; }

    public virtual seddinstrumentos? idInstrumentoNavigation { get; set; }

    public virtual ICollection<sedddetallecoevaluacionautoridad> sedddetallecoevaluacionautoridad { get; set; } = new List<sedddetallecoevaluacionautoridad>();
}
