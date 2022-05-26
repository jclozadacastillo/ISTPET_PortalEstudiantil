using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class subcategorias_actividades
    {
        public int idSubcategoria { get; set; }
        public int? idCategoria { get; set; }
        public string subcategoria { get; set; }
        public byte? esDocencia { get; set; }
        public byte? activa { get; set; }
    }
}
