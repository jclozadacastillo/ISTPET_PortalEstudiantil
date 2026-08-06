using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosalumnos
{
    public int idProyectoAlumno { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idMatricula { get; set; }

    public sbyte? activo { get; set; }

    public virtual matriculas? idMatriculaNavigation { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
