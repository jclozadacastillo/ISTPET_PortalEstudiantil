using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class bien_postulacion_requisitos_becas
{
    public int idPostulacionBecaDocumentos { get; set; }

    public int idParametroRequisitoBeca { get; set; }

    public string estadoDocumento { get; set; } = null!;

    public string? observacionBienestar { get; set; }

    public DateTime? fechaValidacionBienestar { get; set; }

    public DateTime fechaRegistro { get; set; }

    public sbyte esActivo { get; set; }

    public int idPostulacionesBecas { get; set; }

    public int? idUsuarioBienestar { get; set; }

    public sbyte? requisitoBool { get; set; }

    public int? requisitoAdjunto { get; set; }

    public virtual bien_parametro_requisito_beca idParametroRequisitoBecaNavigation { get; set; } = null!;

    public virtual bien_postulaciones_becas idPostulacionesBecasNavigation { get; set; } = null!;

    public virtual usuarios? idUsuarioBienestarNavigation { get; set; }

    public virtual adjuntos_imagenes? requisitoAdjuntoNavigation { get; set; }
}
