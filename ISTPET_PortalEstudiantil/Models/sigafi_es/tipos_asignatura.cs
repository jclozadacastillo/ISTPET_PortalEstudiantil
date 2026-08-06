using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipos_asignatura
{
    public int idtipo_asignatura { get; set; }

    public string? tipo_asignatura { get; set; }

    public string? abreviatura { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? no_definida { get; set; }

    public virtual ICollection<detallemallas> detallemallas { get; set; } = new List<detallemallas>();
}
