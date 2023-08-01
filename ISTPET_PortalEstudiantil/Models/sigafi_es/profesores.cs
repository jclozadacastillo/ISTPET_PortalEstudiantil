using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores
{
    public string idProfesor { get; set; } = null!;

    public string? tipodocumento { get; set; }

    public string? apellidos { get; set; }

    public string? nombres { get; set; }

    public string? direccion { get; set; }

    public string? telefono { get; set; }

    public string? celular { get; set; }

    public string? email { get; set; }

    public DateTime? fecha_nacimiento { get; set; }

    public string? sexo { get; set; }

    public string? nacionalidad { get; set; }

    public string? titulo { get; set; }

    public string? abreviatura { get; set; }

    public sbyte? activo { get; set; }

    public DateTime? fecha_ingreso { get; set; }

    public DateTime? fecha_retiro { get; set; }

    public string? clave { get; set; }

    public sbyte? practicas { get; set; }

    public string? tipo { get; set; }

    public string? foto { get; set; }
}
