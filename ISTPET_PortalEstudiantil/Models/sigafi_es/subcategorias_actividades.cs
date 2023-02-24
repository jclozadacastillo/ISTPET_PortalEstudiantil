using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class subcategorias_actividades
{
    public int idSubcategoria { get; set; }

    public int? idCategoria { get; set; }

    public string? subcategoria { get; set; }

    public sbyte? esDocencia { get; set; }

    public sbyte? activa { get; set; }
}
