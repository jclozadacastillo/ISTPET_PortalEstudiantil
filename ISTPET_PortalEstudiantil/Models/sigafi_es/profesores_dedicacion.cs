using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores_dedicacion
{
    public int idProfesoresDedicacion { get; set; }

    public string idProfesor { get; set; } = null!;

    public int idDedicacionCategorias { get; set; }

    public string idPeriodo { get; set; } = null!;

    public sbyte? esActivo { get; set; }

    public virtual dedicacion_categorias idDedicacionCategoriasNavigation { get; set; } = null!;

    public virtual periodos idPeriodoNavigation { get; set; } = null!;

    public virtual profesores idProfesorNavigation { get; set; } = null!;
}
