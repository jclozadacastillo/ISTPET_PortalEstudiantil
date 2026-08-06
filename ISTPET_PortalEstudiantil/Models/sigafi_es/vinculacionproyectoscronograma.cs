using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectoscronograma
{
    public int idProyectosCronograma { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public DateTime? fechaInicioPlanificada { get; set; }

    public DateTime? fechaFinPlanificada { get; set; }

    public DateTime? fechaInicioCumplida { get; set; }

    public DateTime? fechaFinCumplida { get; set; }

    public string? actividad { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public sbyte activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
