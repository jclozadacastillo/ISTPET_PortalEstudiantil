using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class postulaciones
{
    public int idPostulaciones { get; set; }

    public int idofertas_laborales { get; set; }

    public string idAlumno { get; set; } = null!;

    public int iddocumentos_adjuntos { get; set; }

    public DateTime? fecha_postulacion { get; set; }

    public string? estado { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public virtual documentos_adjuntos iddocumentos_adjuntosNavigation { get; set; } = null!;

    public virtual ofertas_laborales idofertas_laboralesNavigation { get; set; } = null!;
}
