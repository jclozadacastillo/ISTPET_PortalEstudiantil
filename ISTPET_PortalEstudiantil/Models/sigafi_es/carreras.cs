using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class carreras
{
    public int idCarrera { get; set; }

    public string? Carrera { get; set; }

    public DateTime? fechaCreacion { get; set; }

    public bool? activa { get; set; }

    public string? directorCarrera { get; set; }

    public int? numero_creditos { get; set; }

    public int? ordenCarrera { get; set; }

    public int? numero_alumnos { get; set; }

    public sbyte? revisaArrastres { get; set; }

    public string? codigo_cases { get; set; }

    public virtual ICollection<cursos> cursos { get; } = new List<cursos>();

    public virtual ICollection<mallas> mallas { get; } = new List<mallas>();
}
