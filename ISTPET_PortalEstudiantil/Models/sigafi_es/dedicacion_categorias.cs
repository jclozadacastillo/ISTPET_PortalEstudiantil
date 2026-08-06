using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class dedicacion_categorias
{
    public int idDedicacionCategorias { get; set; }

    public int idDedicacion { get; set; }

    public int idEscalafon { get; set; }

    public int? horasMinimas { get; set; }

    public int? horasMaximas { get; set; }

    public sbyte? esActivo { get; set; }

    public virtual ICollection<contratos> contratos { get; set; } = new List<contratos>();

    public virtual dedicacion idDedicacionNavigation { get; set; } = null!;

    public virtual escalafon idEscalafonNavigation { get; set; } = null!;

    public virtual ICollection<profesores_dedicacion> profesores_dedicacion { get; set; } = new List<profesores_dedicacion>();
}
