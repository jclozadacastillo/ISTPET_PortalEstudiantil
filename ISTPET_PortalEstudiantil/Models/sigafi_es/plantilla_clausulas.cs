using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class plantilla_clausulas
{
    public int idPlantillasClausulas { get; set; }

    public int idPlantillaContrato { get; set; }

    public int idClausulas { get; set; }

    public string? texto { get; set; }

    public int? orden { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual clausulas idClausulasNavigation { get; set; } = null!;

    public virtual plantilla_contrato idPlantillaContratoNavigation { get; set; } = null!;
}
