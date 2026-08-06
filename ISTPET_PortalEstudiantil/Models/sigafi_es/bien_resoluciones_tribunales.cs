using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_resoluciones_tribunales
{
    public int idResolucionesTribunales { get; set; }

    public int idPostulacionesBecas { get; set; }

    public int idUsuarioRegistra { get; set; }

    public string idPeriodo { get; set; } = null!;

    public string? resolucion { get; set; }

    public decimal porcentajeFinal { get; set; }

    public string? observacion { get; set; }

    public DateTime? fechaActualizacion { get; set; }

    public DateTime fechaRegistro { get; set; }

    public virtual ICollection<bien_apoyo_financiero> bien_apoyo_financiero { get; set; } = new List<bien_apoyo_financiero>();

    public virtual bien_votos_tribunales? bien_votos_tribunales { get; set; }

    public virtual periodos idPeriodoNavigation { get; set; } = null!;

    public virtual bien_postulaciones_becas idPostulacionesBecasNavigation { get; set; } = null!;

    public virtual usuarios idUsuarioRegistraNavigation { get; set; } = null!;
}
