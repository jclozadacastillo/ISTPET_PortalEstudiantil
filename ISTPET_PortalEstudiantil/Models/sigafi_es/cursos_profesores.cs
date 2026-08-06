using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cursos_profesores
{
    public int idCursoProfesor { get; set; }

    public string idProfesor { get; set; } = null!;

    public string? nombre_curso { get; set; }

    public string? Institucion { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public DateTime? fecha_finalizacion { get; set; }

    public int? numero_horas { get; set; }

    public sbyte? esValido { get; set; }

    public string? archivoCurso { get; set; }

    public virtual profesores idProfesorNavigation { get; set; } = null!;
}
