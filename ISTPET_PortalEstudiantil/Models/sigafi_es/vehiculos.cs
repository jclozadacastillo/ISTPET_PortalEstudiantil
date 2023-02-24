using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vehiculos
{
    public int idVehiculo { get; set; }

    public int? idSubcategoria { get; set; }

    public string? numero_vehiculo { get; set; }

    public string? placa { get; set; }

    public string? marca { get; set; }

    public int? anio { get; set; }

    public int? idCategoria { get; set; }

    public sbyte? activo { get; set; }

    public string? observacion { get; set; }

    public string? chasis { get; set; }

    public string? motor { get; set; }

    public string? modelo { get; set; }
}
