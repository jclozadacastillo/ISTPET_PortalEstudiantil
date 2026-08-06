using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class alumnos_referencias
{
    public int idalumnos_referencias { get; set; }

    public string idAlumno { get; set; } = null!;

    public string? nombres_referencia { get; set; }

    public string? contacto { get; set; }

    public string? referencia_empresa { get; set; }

    public string? relacion { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }
}
