using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class pd_categorias_terminos_condiciones
{
    public int idCategoria { get; set; }

    public string? categoria { get; set; }

    public sbyte? esAlumno { get; set; }

    public sbyte? esDocente { get; set; }

    public sbyte? esAdministrativo { get; set; }

    public sbyte? esExterno { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public sbyte? activo { get; set; }
}
