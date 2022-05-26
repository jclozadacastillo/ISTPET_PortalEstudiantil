using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class categorias_examenes_conduccion
    {
        public int IdCategoria { get; set; }
        public string categoria { get; set; }
        public byte? tieneNota { get; set; }
        public byte? activa { get; set; }
    }
}
