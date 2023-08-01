using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores_actas_parciales
{
    public int idAsignacion { get; set; }

    public int idParcial { get; set; }

    public sbyte? activo { get; set; }

    public DateTime fecha_grabar { get; set; }

    public DateTime fecha_modificacion { get; set; }

    public string? codigo_impresion { get; set; }

    public sbyte? entrega_acta { get; set; }

    public sbyte? ingresa_notas { get; set; }

    public string? usuario_graba { get; set; }

    public sbyte? activoAtraso { get; set; }

    public DateTime? fechaInicio { get; set; }

    public DateTime? fechaFin { get; set; }
}
