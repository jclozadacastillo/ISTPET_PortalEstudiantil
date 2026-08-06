using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class grados_academicos
{
    public int idGradoAcademico { get; set; }

    public int idNivelAcademico { get; set; }

    public string? nombre { get; set; }

    public virtual niveles_academicos idNivelAcademicoNavigation { get; set; } = null!;

    public virtual ICollection<titulos_en_curso> titulos_en_curso { get; set; } = new List<titulos_en_curso>();

    public virtual ICollection<titulos_profesores> titulos_profesores { get; set; } = new List<titulos_profesores>();
}
