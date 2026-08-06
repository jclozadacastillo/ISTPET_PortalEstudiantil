using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class vinculaciontiposobjetivos
{
    public int idTipoObjetivo { get; set; }

    public string? tipoObjetivo { get; set; }

    public sbyte? esGeneral { get; set; }

    public sbyte? activo { get; set; }
}
