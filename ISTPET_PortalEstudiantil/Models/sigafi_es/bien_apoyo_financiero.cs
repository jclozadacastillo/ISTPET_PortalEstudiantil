using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_apoyo_financiero
{
    public int idApoyoFinanciero { get; set; }

    public int idResponsable { get; set; }

    public int idResolucionesTribunales { get; set; }

    public int idMatricula { get; set; }

    public string? observacion { get; set; }

    public sbyte esAceptada { get; set; }

    public DateTime? fechaAceptacion { get; set; }

    public sbyte esActivo { get; set; }

    public virtual matriculas idMatriculaNavigation { get; set; } = null!;

    public virtual bien_resoluciones_tribunales idResolucionesTribunalesNavigation { get; set; } = null!;

    public virtual usuarios idResponsableNavigation { get; set; } = null!;
}
