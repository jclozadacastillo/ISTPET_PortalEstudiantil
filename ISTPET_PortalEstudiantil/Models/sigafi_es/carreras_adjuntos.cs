using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class carreras_adjuntos
{
    public int idCarrerasAdjuntos { get; set; }

    public int idCarrera { get; set; }

    public int idAdjuntos_Imagenes { get; set; }

    public virtual adjuntos_imagenes idAdjuntos_ImagenesNavigation { get; set; } = null!;

    public virtual carreras idCarreraNavigation { get; set; } = null!;
}
