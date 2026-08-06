using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_motivos_beca
{
    public int idMotivosBeca { get; set; }

    public sbyte esActivo { get; set; }

    public sbyte? esDefault { get; set; }

    public int idTipoApoyoFinanciero { get; set; }

    public int idPorcentajeBeca { get; set; }

    public virtual ICollection<bien_postulaciones_becas> bien_postulaciones_becas { get; set; } = new List<bien_postulaciones_becas>();

    public virtual bien_porcentaje_beca idPorcentajeBecaNavigation { get; set; } = null!;

    public virtual bien_tipo_apoyo_financiero idTipoApoyoFinancieroNavigation { get; set; } = null!;
}
