using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class profesores
{
    public string idProfesor { get; set; } = null!;

    public string? tipodocumento { get; set; }

    public string? apellidos { get; set; }

    public string? nombres { get; set; }

    public string? primerApellido { get; set; }

    public string? segundoApellido { get; set; }

    public string? primerNombre { get; set; }

    public string? segundoNombre { get; set; }

    public int estadoCivil { get; set; }

    public string? direccion { get; set; }

    public string? callePrincipal { get; set; }

    public string? calleSecundaria { get; set; }

    public string? numeroCasa { get; set; }

    public string? telefono { get; set; }

    public string? celular { get; set; }

    public string? email { get; set; }

    public DateTime? fecha_nacimiento { get; set; }

    public string? sexo { get; set; }

    public string? clave { get; set; }

    public sbyte? practicas { get; set; }

    public string? tipo { get; set; }

    public string? nacionalidad { get; set; }

    public string? titulo { get; set; }

    public string? abreviatura { get; set; }

    public string? abreviatura_post { get; set; }

    public sbyte? activo { get; set; }

    public int idEtnia { get; set; }

    public int idNacionalidad { get; set; }

    public int idParroquiaNacimiento { get; set; }

    public string? emailInstitucional { get; set; }

    public DateTime? fecha_ingreso { get; set; }

    public DateTime? fechaIngresoIess { get; set; }

    public DateTime? fecha_retiro { get; set; }

    public int idParroquiaResidencia { get; set; }

    public string tipoSangre { get; set; } = null!;

    public string? codigoPostal { get; set; }

    public int idDiscapacidad { get; set; }

    public int? porcentajeDiscapacidad { get; set; }

    public string? numeroConadis { get; set; }

    public string? foto { get; set; }

    public sbyte? esReal { get; set; }

    public virtual ICollection<asignaciones_vacaciones> asignaciones_vacaciones { get; set; } = new List<asignaciones_vacaciones>();

    public virtual ICollection<certificados_experiencia_laboral> certificados_experiencia_laboral { get; set; } = new List<certificados_experiencia_laboral>();

    public virtual ICollection<cierres_colectivos_exclusiones> cierres_colectivos_exclusiones { get; set; } = new List<cierres_colectivos_exclusiones>();

    public virtual ICollection<contratos> contratos { get; set; } = new List<contratos>();

    public virtual ICollection<cursos_profesores> cursos_profesores { get; set; } = new List<cursos_profesores>();

    public virtual estadocivil estadoCivilNavigation { get; set; } = null!;

    public virtual discapacidades idDiscapacidadNavigation { get; set; } = null!;

    public virtual etnias idEtniaNavigation { get; set; } = null!;

    public virtual nacionalidades idNacionalidadNavigation { get; set; } = null!;

    public virtual parroquias idParroquiaNacimientoNavigation { get; set; } = null!;

    public virtual parroquias idParroquiaResidenciaNavigation { get; set; } = null!;

    public virtual ICollection<kardex_vacaciones> kardex_vacaciones { get; set; } = new List<kardex_vacaciones>();

    public virtual ICollection<permisos> permisos { get; set; } = new List<permisos>();

    public virtual ICollection<planificacion_vacaciones> planificacion_vacaciones { get; set; } = new List<planificacion_vacaciones>();

    public virtual ICollection<profesores_carreras_periodos> profesores_carreras_periodos { get; set; } = new List<profesores_carreras_periodos>();

    public virtual ICollection<profesores_dedicacion> profesores_dedicacion { get; set; } = new List<profesores_dedicacion>();

    public virtual ICollection<profesores_motivo_salida> profesores_motivo_salida { get; set; } = new List<profesores_motivo_salida>();

    public virtual ICollection<saldos_vacaciones> saldos_vacaciones { get; set; } = new List<saldos_vacaciones>();

    public virtual ICollection<solicitudes_licencias> solicitudes_licencias { get; set; } = new List<solicitudes_licencias>();

    public virtual ICollection<solicitudes_vacaciones> solicitudes_vacaciones { get; set; } = new List<solicitudes_vacaciones>();

    public virtual tiposangre tipoSangreNavigation { get; set; } = null!;

    public virtual ICollection<titulos_en_curso> titulos_en_curso { get; set; } = new List<titulos_en_curso>();

    public virtual ICollection<titulos_profesores> titulos_profesores { get; set; } = new List<titulos_profesores>();

    public virtual ICollection<vacaciones_ledger> vacaciones_ledger { get; set; } = new List<vacaciones_ledger>();
}
