using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class titulos_profesores
{
    public int idTitulosProfesor { get; set; }

    public string idProfesor { get; set; } = null!;

    public string? titulo { get; set; }

    public int idUniversidad { get; set; }

    public int idGradoAcademico { get; set; }

    public string? codigo_senescyt { get; set; }

    public DateTime? fecha_obtencion { get; set; }

    public DateTime? fecha_registro { get; set; }

    public int idCampoDetalladoUnesco { get; set; }

    public string? archivoTitulo { get; set; }

    public virtual campo_detallado_unesco idCampoDetalladoUnescoNavigation { get; set; } = null!;

    public virtual grados_academicos idGradoAcademicoNavigation { get; set; } = null!;

    public virtual profesores idProfesorNavigation { get; set; } = null!;

    public virtual universidades idUniversidadNavigation { get; set; } = null!;
}
