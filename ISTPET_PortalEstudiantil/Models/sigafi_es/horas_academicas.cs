using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class horas_academicas
{
    public int idHorasAcademicas { get; set; }

    public int idDedicacion { get; set; }

    public int? HorasMinimas { get; set; }

    public int? HorasMaximas { get; set; }

    public int? HorasMaximaSemana { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual dedicacion idDedicacionNavigation { get; set; } = null!;
}
