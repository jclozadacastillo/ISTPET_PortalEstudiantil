using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class solicitudescalificaciones
{
    public int idSolicitudCalificacion { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public DateTime? fechaHabilitado { get; set; }

    public int? idSolicitud { get; set; }

    public int? idParcial { get; set; }

    public int? idMatricula { get; set; }

    public int? idAsignatura { get; set; }

    public int? idNivel { get; set; }

    public string? idPeriodo { get; set; }

    public string? paralelo { get; set; }

    public DateTime? fechaCalificacion { get; set; }

    public string? idProfesor { get; set; }

    public decimal? calificacion { get; set; }

    public sbyte? activo { get; set; }

    public virtual asignaturas? idAsignaturaNavigation { get; set; }

    public virtual matriculas? idMatriculaNavigation { get; set; }

    public virtual cursos? idNivelNavigation { get; set; }

    public virtual parciales? idParcialNavigation { get; set; }

    public virtual solicitudes? idSolicitudNavigation { get; set; }
}
