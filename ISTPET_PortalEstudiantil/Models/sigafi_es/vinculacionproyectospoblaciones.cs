using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculacionproyectospoblaciones
{
    public int idProyectosPoblaciones { get; set; }

    public int? idProyectoVinculacion { get; set; }

    public string? nombre { get; set; }

    public string? direccion { get; set; }

    public string? telefono { get; set; }

    public string? email { get; set; }

    public string? contacto { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public sbyte activo { get; set; }

    public virtual vinculacionproyectos? idProyectoVinculacionNavigation { get; set; }
}
