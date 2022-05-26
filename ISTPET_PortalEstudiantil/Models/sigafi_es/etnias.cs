using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class etnias
    {
        public int idEtnia { get; set; }
        public string etnia { get; set; }
        public byte? esIndigena { get; set; }
        public byte? noRegistra { get; set; }
    }
}
