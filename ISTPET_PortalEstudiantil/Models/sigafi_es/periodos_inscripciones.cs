using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class periodos_inscripciones
{
    public int idPeriodoInscripcion { get; set; }

    public string? idPeriodo { get; set; }

    public int? idModalidad { get; set; }

    public int? idNivel { get; set; }

    public int? idSeccion { get; set; }

    public DateTime? fechaInicio { get; set; }

    public DateTime? fechaFinal { get; set; }

    public DateTime fechaRegistro { get; set; }

    public sbyte? activo { get; set; }

    public ulong? conduccion { get; set; }
}
