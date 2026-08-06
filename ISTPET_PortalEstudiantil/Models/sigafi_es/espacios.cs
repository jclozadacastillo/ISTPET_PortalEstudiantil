using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class espacios
{
    public int idEspacio { get; set; }

    public string codigo { get; set; } = null!;

    public string nombre { get; set; } = null!;

    public string tipo { get; set; } = null!;

    public int capacidad { get; set; }

    public int? idCarrera { get; set; }

    public string? edificio { get; set; }

    public int piso { get; set; }

    public sbyte activo { get; set; }

    public sbyte? requiereReserva { get; set; }

    public string? imagen_referencia { get; set; }

    public sbyte esAsincrono { get; set; }

    public virtual ICollection<horario_detalle> horario_detalle { get; set; } = new List<horario_detalle>();

    public virtual carreras? idCarreraNavigation { get; set; }
}
