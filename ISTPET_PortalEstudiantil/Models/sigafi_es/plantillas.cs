using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class plantillas
{
    public int idPlantilla { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public string? nombre { get; set; }

    public string? archivo { get; set; }

    public string? usuario { get; set; }

    public sbyte? activo { get; set; }

    public virtual ICollection<plantillasparametros> plantillasparametros { get; set; } = new List<plantillasparametros>();
}
