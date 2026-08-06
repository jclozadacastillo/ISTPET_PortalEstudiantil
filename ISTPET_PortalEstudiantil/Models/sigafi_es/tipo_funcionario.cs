using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class tipo_funcionario
{
    public int idTipoFuncionario { get; set; }

    public string? nombre { get; set; }

    public ulong? esDocente { get; set; }

    public virtual ICollection<cargo_instituto> cargo_instituto { get; set; } = new List<cargo_instituto>();
}
