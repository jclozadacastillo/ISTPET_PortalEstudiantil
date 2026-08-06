using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class aceptaciones_usuarios
{
    public int idAceptacionUsuario { get; set; }

    public string? idUsuario { get; set; }

    public int? idTermino { get; set; }

    public string? sistema { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public string? ipOrigen { get; set; }

    public string? dispositivo { get; set; }
}
