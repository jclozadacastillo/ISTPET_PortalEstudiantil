using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vehiculos_operacion
{
    public int idVehiculo { get; set; }

    public int? id_tipo_licencia { get; set; }

    public string? id_instructor_fijo { get; set; }

    public string? estado_mecanico { get; set; }

    public virtual vehiculos idVehiculoNavigation { get; set; } = null!;
}
