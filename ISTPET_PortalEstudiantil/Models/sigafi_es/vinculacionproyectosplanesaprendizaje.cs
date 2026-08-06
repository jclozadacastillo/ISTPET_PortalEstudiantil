using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectosplanesaprendizaje
{
    public int idProyectosPlanesAprendizaje { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public int? idProyectosResultadosAprendizaje { get; set; }

    public string? actividad { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public sbyte activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }

    public virtual vinculacionproyectosresultadosaprendizaje? idProyectosResultadosAprendizajeNavigation { get; set; }
}
