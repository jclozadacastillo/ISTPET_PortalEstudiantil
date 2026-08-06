using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class certificados_experiencia_laboral
{
    public int idcertificados_experiencia_laboral { get; set; }

    public string idProfesor { get; set; } = null!;

    public DateTime fecha_emision { get; set; }

    public sbyte generado_automaticamente { get; set; }

    public string? ruta { get; set; }

    public sbyte esActivo { get; set; }

    public virtual profesores idProfesorNavigation { get; set; } = null!;
}
