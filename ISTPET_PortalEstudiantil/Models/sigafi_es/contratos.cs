using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class contratos
{
    public int idContratos { get; set; }

    public int idInstitucionesInstituto { get; set; }

    public string idProfesor { get; set; } = null!;

    public int idDedicacionCategorias { get; set; }

    public int? idTiposContratos { get; set; }

    public int? idRelacionIes { get; set; }

    public int? iddepartamentos { get; set; }

    public int? idCargoInstituto { get; set; }

    public string? numeroContrato { get; set; }

    public sbyte? esAdendum { get; set; }

    public string? contratoVinculado { get; set; }

    public DateTime? fecha_registro { get; set; }

    public DateTime? fecha_inicio { get; set; }

    public DateTime? fecha_final { get; set; }

    public sbyte? esActivo { get; set; }

    public string? archivoContrato { get; set; }

    public string? archivoLegalizado { get; set; }

    public string? archivoFiniquito { get; set; }

    public string? archivoLegalizadoSalida { get; set; }

    public sbyte? ingreso_concurso { get; set; }

    public string usuario_creo { get; set; } = null!;

    public string? usuarios_modifico { get; set; }

    public DateTime? fecha_modifico { get; set; }

    public virtual ICollection<contratos_asignaturas> contratos_asignaturas { get; set; } = new List<contratos_asignaturas>();

    public virtual ICollection<contratos_facturas> contratos_facturas { get; set; } = new List<contratos_facturas>();

    public virtual ICollection<extras_contratos> extras_contratos { get; set; } = new List<extras_contratos>();

    public virtual dedicacion_categorias idDedicacionCategoriasNavigation { get; set; } = null!;

    public virtual instituciones_instituto idInstitucionesInstitutoNavigation { get; set; } = null!;

    public virtual profesores idProfesorNavigation { get; set; } = null!;

    public virtual ICollection<profesores_motivo_salida> profesores_motivo_salida { get; set; } = new List<profesores_motivo_salida>();

    public virtual ICollection<sueldos_contratos> sueldos_contratos { get; set; } = new List<sueldos_contratos>();
}
