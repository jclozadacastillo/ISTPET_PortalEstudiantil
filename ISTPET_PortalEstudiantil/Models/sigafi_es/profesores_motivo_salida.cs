using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores_motivo_salida
{
    public string idProfesor { get; set; } = null!;

    public int idMotivoSalida { get; set; }

    public int idContratos { get; set; }

    public string? Observacion { get; set; }

    public string? ruta_archivo { get; set; }

    public DateTime? fecha_registro { get; set; }

    public DateTime? fecha_salida { get; set; }

    public virtual contratos idContratosNavigation { get; set; } = null!;

    public virtual motivo_salida idMotivoSalidaNavigation { get; set; } = null!;

    public virtual profesores idProfesorNavigation { get; set; } = null!;
}
