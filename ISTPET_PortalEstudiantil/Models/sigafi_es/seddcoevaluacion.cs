using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddcoevaluacion
{
    public int idTest { get; set; }

    public int? idInstrumento { get; set; }

    public string? idPeriodo { get; set; }

    public int? idAsignacion { get; set; }

    public string? idProfesor { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public DateTime? fechaTest { get; set; }

    public virtual seddinstrumentos? idInstrumentoNavigation { get; set; }

    public virtual ICollection<sedddetallecoevaluacion> sedddetallecoevaluacion { get; set; } = new List<sedddetallecoevaluacion>();
}
