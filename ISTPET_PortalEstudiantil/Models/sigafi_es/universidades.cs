using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class universidades
{
    public int idUniversidad { get; set; }

    public int idpaises { get; set; }

    public string? nombre { get; set; }

    public string? codigo_siees { get; set; }

    public virtual paises idpaisesNavigation { get; set; } = null!;

    public virtual ICollection<titulos_en_curso> titulos_en_curso { get; set; } = new List<titulos_en_curso>();

    public virtual ICollection<titulos_profesores> titulos_profesores { get; set; } = new List<titulos_profesores>();
}
