using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class profesores_actividades
    {
        public string idPeriodo { get; set; }
        public string idProfesor { get; set; }
        public int idSubcategoria { get; set; }
        public int? horas_semana { get; set; }
        public string usuario { get; set; }
    }
}
