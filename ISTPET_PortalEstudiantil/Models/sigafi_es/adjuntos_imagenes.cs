using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class adjuntos_imagenes
{
    public int idAdjuntos_Imagenes { get; set; }

    public string? NombreArchivos { get; set; }

    public string? Extension { get; set; }

    public string? MimeTypes { get; set; }

    public int? TamanioBytes { get; set; }

    public string? Ruta { get; set; }

    public virtual ICollection<bien_postulacion_requisitos_becas> bien_postulacion_requisitos_becas { get; set; } = new List<bien_postulacion_requisitos_becas>();

    public virtual ICollection<carreras_adjuntos> carreras_adjuntos { get; set; } = new List<carreras_adjuntos>();

    public virtual ICollection<plantilla_contrato> plantilla_contratoidFondoNavigation { get; set; } = new List<plantilla_contrato>();

    public virtual ICollection<plantilla_contrato> plantilla_contratoidSelloNavigation { get; set; } = new List<plantilla_contrato>();
}
