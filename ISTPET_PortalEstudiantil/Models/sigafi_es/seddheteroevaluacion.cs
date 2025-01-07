using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddheteroevaluacion
{
    public int idTest { get; set; }

    public int? idInstrumento { get; set; }

    public string? idPeriodo { get; set; }

    public int? idAsignacion { get; set; }

    public int? idMatricula { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public virtual seddinstrumentos? idInstrumentoNavigation { get; set; }

    public virtual ICollection<sedddetalleheteroevaluacion> sedddetalleheteroevaluacion { get; set; } = new List<sedddetalleheteroevaluacion>();
}
