using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class formaciones_academicas
{
    public int idformaciones_academicas { get; set; }

    public string idAlumno { get; set; } = null!;

    public string? Institucion_nombre { get; set; }

    public string? titulo { get; set; }

    public string? abreviatura { get; set; }

    public string? numero_registro { get; set; }

    public string? area_estudio { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public DateTime? fecha_fin { get; set; }

    public DateTime? fecha_creacion { get; set; }

    public DateTime? fecha_modificacion { get; set; }
}
