using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class parametrostipossolicitudes
{
    public int idParametroTipoSolicitud { get; set; }

    public int? idTipoSolicitud { get; set; }

    public sbyte? periodo { get; set; }

    public sbyte? esPeriodoApertura { get; set; }

    public sbyte? esConduccion { get; set; }

    public sbyte? carrera { get; set; }

    public sbyte? nivel { get; set; }

    public sbyte? asignatura { get; set; }

    public sbyte? detalle { get; set; }

    public sbyte? esDetalleAutogenerado { get; set; }

    public string? detalleAutogenerado { get; set; }

    public sbyte? activo { get; set; }

    public sbyte? esCalificaciones { get; set; }

    public virtual tipossolicitudes? idTipoSolicitudNavigation { get; set; }
}
