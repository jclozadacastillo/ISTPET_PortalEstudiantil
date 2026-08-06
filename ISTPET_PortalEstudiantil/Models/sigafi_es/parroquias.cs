using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class parroquias
{
    public int idParroquias { get; set; }

    public int idciudades { get; set; }

    public string? nombre { get; set; }

    public virtual ICollection<alumnos> alumnos { get; set; } = new List<alumnos>();

    public virtual ciudades idciudadesNavigation { get; set; } = null!;

    public virtual ICollection<profesores> profesoresidParroquiaNacimientoNavigation { get; set; } = new List<profesores>();

    public virtual ICollection<profesores> profesoresidParroquiaResidenciaNavigation { get; set; } = new List<profesores>();
}
