using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class titulos_en_curso
{
    public int idTitulosProfesorCurso { get; set; }

    public string idProfesor { get; set; } = null!;

    public string? titulo { get; set; }

    public int idUniversidad { get; set; }

    public int idGradoAcademico { get; set; }

    public int idCampoDetalladoUnesco { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public sbyte? tieneBeca { get; set; }

    public int? porcentajeBeca { get; set; }

    public int? idTipoBeca { get; set; }

    public decimal? montoBeca { get; set; }

    public int? idFinanciamiento { get; set; }

    public string? nombreOtro { get; set; }

    public virtual campo_detallado_unesco idCampoDetalladoUnescoNavigation { get; set; } = null!;

    public virtual financiamiento_beca? idFinanciamientoNavigation { get; set; }

    public virtual grados_academicos idGradoAcademicoNavigation { get; set; } = null!;

    public virtual profesores idProfesorNavigation { get; set; } = null!;

    public virtual tipos_becas? idTipoBecaNavigation { get; set; }

    public virtual universidades idUniversidadNavigation { get; set; } = null!;
}
