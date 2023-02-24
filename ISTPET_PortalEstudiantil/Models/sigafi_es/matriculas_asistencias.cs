using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class matriculas_asistencias
{
    public int idMatricula { get; set; }

    public int idFecha { get; set; }

    public bool? noAsiste { get; set; }

    public bool? atraso { get; set; }

    public string? observacion { get; set; }

    public string? usuario { get; set; }

    public DateTime fecha_creacion { get; set; }

    public DateTime fecha_actualizacion { get; set; }

    public string? usuario_actualiza { get; set; }
}
