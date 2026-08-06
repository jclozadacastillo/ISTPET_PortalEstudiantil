using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class documentos_adjuntos
{
    public int iddocumentos_adjuntos { get; set; }

    public string idAlumno { get; set; } = null!;

    public int idtipos_documentos { get; set; }

    public string? nombre_archivo { get; set; }

    public string? ruta_archivo { get; set; }

    public DateTime? fecha_Subida { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public virtual tipos_documentos idtipos_documentosNavigation { get; set; } = null!;

    public virtual ICollection<postulaciones> postulaciones { get; set; } = new List<postulaciones>();
}
