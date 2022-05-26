using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class categorias_actividades
    {
        public int idCategoria { get; set; }
        public string categoria { get; set; }
        public byte? esDocencia { get; set; }
        public byte? activa { get; set; }
    }
}
