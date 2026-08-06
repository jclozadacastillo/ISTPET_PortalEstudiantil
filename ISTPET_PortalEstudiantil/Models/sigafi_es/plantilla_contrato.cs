using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class plantilla_contrato
{
    public int idPlantillaContrato { get; set; }

    public int idDedicacion { get; set; }

    public int idTiposContratos { get; set; }

    public int idInstitucionesInstituto { get; set; }

    public int idSello { get; set; }

    public int idFondo { get; set; }

    public string? titulo { get; set; }

    public string? cuerpo { get; set; }

    public int? version { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public sbyte? esActivo { get; set; }

    public sbyte? esDocente { get; set; }

    public virtual dedicacion idDedicacionNavigation { get; set; } = null!;

    public virtual adjuntos_imagenes idFondoNavigation { get; set; } = null!;

    public virtual instituciones_instituto idInstitucionesInstitutoNavigation { get; set; } = null!;

    public virtual adjuntos_imagenes idSelloNavigation { get; set; } = null!;

    public virtual tipos_contratos idTiposContratosNavigation { get; set; } = null!;

    public virtual ICollection<plantilla_clausulas> plantilla_clausulas { get; set; } = new List<plantilla_clausulas>();
}
