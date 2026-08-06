using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class usuariosdepartamentossolicitudes
{
    public int idUsuarioDepartamentoSolicitud { get; set; }

    public int? idTipoSolicitud { get; set; }

    public int? idUsuarioSolicitud { get; set; }

    public sbyte? activo { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public DateTime? fechaBaja { get; set; }

    public virtual tipossolicitudes? idTipoSolicitudNavigation { get; set; }

    public virtual usuariossolicitudes? idUsuarioSolicitudNavigation { get; set; }
}
