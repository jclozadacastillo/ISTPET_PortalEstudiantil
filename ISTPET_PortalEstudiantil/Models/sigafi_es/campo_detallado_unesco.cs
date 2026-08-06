using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class campo_detallado_unesco
{
    public int idCampoDetalladoUnesco { get; set; }

    public int? idCampospecificoUnesco { get; set; }

    public string? nombreDetallado { get; set; }

    public string? codigoDetallado { get; set; }

    public sbyte? activo { get; set; }

    public virtual campo_especifico_unesco? idCampospecificoUnescoNavigation { get; set; }

    public virtual ICollection<titulos_en_curso> titulos_en_curso { get; set; } = new List<titulos_en_curso>();

    public virtual ICollection<titulos_profesores> titulos_profesores { get; set; } = new List<titulos_profesores>();

    public virtual ICollection<vinculacionproyectos> vinculacionproyectos { get; set; } = new List<vinculacionproyectos>();
}
