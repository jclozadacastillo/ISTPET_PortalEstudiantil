using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class cargo_instituto
{
    public int idCargoInstituto { get; set; }

    public int idTipoFuncionario { get; set; }

    public string? nombre { get; set; }

    public int? disponibilidad_cargo { get; set; }

    public virtual tipo_funcionario idTipoFuncionarioNavigation { get; set; } = null!;
}
