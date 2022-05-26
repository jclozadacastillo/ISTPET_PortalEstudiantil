using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class matriculas
    {
        public matriculas()
        {
            calificaciones = new HashSet<calificaciones>();
        }

        public int idMatricula { get; set; }
        public string idAlumno { get; set; }
        public int idNivel { get; set; }
        public int idSeccion { get; set; }
        public int idModalidad { get; set; }
        public string idPeriodo { get; set; }
        public string paralelo { get; set; }
        public bool? arrastres { get; set; }
        public int? folio { get; set; }
        public decimal? beca_matricula { get; set; }
        public decimal? beca_colegiatura { get; set; }
        public bool? retirado { get; set; }
        public DateTime? fechaRetiro { get; set; }
        public string observacion { get; set; }
        public bool? convalidacion { get; set; }
        public string carrera_convalidada { get; set; }
        public int? numero_permiso { get; set; }
        public string user_matricula { get; set; }
        public byte? valida { get; set; }
        public byte? esOyente { get; set; }
        public string documentoFactura { get; set; }

        public virtual alumnos idAlumnoNavigation { get; set; }
        public virtual modalidades idModalidadNavigation { get; set; }
        public virtual cursos idNivelNavigation { get; set; }
        public virtual periodos idPeriodoNavigation { get; set; }
        public virtual secciones idSeccionNavigation { get; set; }
        public virtual ICollection<calificaciones> calificaciones { get; set; }
    }
}
