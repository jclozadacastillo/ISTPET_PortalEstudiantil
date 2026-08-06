using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class audit_logs
{
    public int id { get; set; }

    public string usuario { get; set; } = null!;

    public string accion { get; set; } = null!;

    public string? entidad_id { get; set; }

    public string? detalles { get; set; }

    public string? ip_origen { get; set; }

    public DateTime fecha_hora { get; set; }
}
