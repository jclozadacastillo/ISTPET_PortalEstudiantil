using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class asignaturas_complementos_formacion
{
    public int idAsignatura { get; set; }

    public int? idCarrera { get; set; }

    public string? asignatura { get; set; }

    public sbyte? activo { get; set; }
}
