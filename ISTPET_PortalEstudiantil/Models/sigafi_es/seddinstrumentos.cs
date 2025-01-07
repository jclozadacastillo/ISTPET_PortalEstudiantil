﻿using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class seddinstrumentos
{
    public int idInstrumento { get; set; }

    public int? idCategoria { get; set; }

    public string? Instrumento { get; set; }

    public string? codigo { get; set; }

    public int? porcentaje { get; set; }

    public sbyte? activo { get; set; }

    public virtual categorias_actividades? idCategoriaNavigation { get; set; }

    public virtual ICollection<seddautoevaluacion> seddautoevaluacion { get; set; } = new List<seddautoevaluacion>();

    public virtual ICollection<seddcoevaluacion> seddcoevaluacion { get; set; } = new List<seddcoevaluacion>();

    public virtual ICollection<seddcoevaluacionautoridad> seddcoevaluacionautoridad { get; set; } = new List<seddcoevaluacionautoridad>();

    public virtual ICollection<seddheteroevaluacion> seddheteroevaluacion { get; set; } = new List<seddheteroevaluacion>();

    public virtual ICollection<seddinsitu> seddinsitu { get; set; } = new List<seddinsitu>();

    public virtual ICollection<seddinstrumentospreguntas> seddinstrumentospreguntas { get; set; } = new List<seddinstrumentospreguntas>();
}
