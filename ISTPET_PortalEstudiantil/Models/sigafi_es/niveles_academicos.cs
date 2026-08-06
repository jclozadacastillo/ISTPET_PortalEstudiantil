using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class niveles_academicos
{
    public int idNivelAcademico { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<grados_academicos> grados_academicos { get; set; } = new List<grados_academicos>();
}
