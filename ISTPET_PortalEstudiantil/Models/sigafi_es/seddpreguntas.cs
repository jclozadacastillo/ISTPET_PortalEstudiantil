using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddpreguntas
{
    public int idPregunta { get; set; }

    public string? pregunta { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<sedddetalleautoevaluacion> sedddetalleautoevaluacion { get; set; } = new List<sedddetalleautoevaluacion>();

    public virtual ICollection<sedddetallecoevaluacion> sedddetallecoevaluacion { get; set; } = new List<sedddetallecoevaluacion>();

    public virtual ICollection<sedddetallecoevaluacionautoridad> sedddetallecoevaluacionautoridad { get; set; } = new List<sedddetallecoevaluacionautoridad>();

    public virtual ICollection<sedddetalleheteroevaluacion> sedddetalleheteroevaluacion { get; set; } = new List<sedddetalleheteroevaluacion>();

    public virtual ICollection<seddinstrumentospreguntas> seddinstrumentospreguntas { get; set; } = new List<seddinstrumentospreguntas>();
}
