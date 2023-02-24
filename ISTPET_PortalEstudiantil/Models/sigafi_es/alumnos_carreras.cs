using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class alumnos_carreras
{
    public string idAlumno { get; set; } = null!;

    public int idCarrera { get; set; }

    public sbyte? convalidacion { get; set; }

    public string? carrera_convalidada { get; set; }

    public string? institucion_convalidada { get; set; }

    public int? creditos_convalidados { get; set; }

    public sbyte? pasantias { get; set; }

    public decimal? nota_pasantia { get; set; }

    public int? creditos_pasantia { get; set; }

    public sbyte? trabajo_grado { get; set; }

    public decimal? nota_documento { get; set; }

    public decimal? nota_defensa { get; set; }

    public decimal? nota_tesis { get; set; }

    public int? creditos_titulo { get; set; }
}
