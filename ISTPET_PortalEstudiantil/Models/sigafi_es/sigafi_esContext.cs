using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class sigafi_esContext : DbContext
{
    public sigafi_esContext()
    {
    }

    public sigafi_esContext(DbContextOptions<sigafi_esContext> options)
        : base(options)
    {
    }

    public virtual DbSet<aceptaciones_usuarios> aceptaciones_usuarios { get; set; }

    public virtual DbSet<adjuntos_imagenes> adjuntos_imagenes { get; set; }

    public virtual DbSet<administrador> administrador { get; set; }

    public virtual DbSet<agenda_academica> agenda_academica { get; set; }

    public virtual DbSet<alumnos> alumnos { get; set; }

    public virtual DbSet<alumnos_acta_conduccion> alumnos_acta_conduccion { get; set; }

    public virtual DbSet<alumnos_carreras> alumnos_carreras { get; set; }

    public virtual DbSet<alumnos_habilidades> alumnos_habilidades { get; set; }

    public virtual DbSet<alumnos_inscripciones> alumnos_inscripciones { get; set; }

    public virtual DbSet<alumnos_inscripciones_ingles> alumnos_inscripciones_ingles { get; set; }

    public virtual DbSet<alumnos_referencias> alumnos_referencias { get; set; }

    public virtual DbSet<alumnos_restricciones> alumnos_restricciones { get; set; }

    public virtual DbSet<alumnos_sucesos> alumnos_sucesos { get; set; }

    public virtual DbSet<alumnos_titulos> alumnos_titulos { get; set; }

    public virtual DbSet<asignacion_instructores_vehiculos> asignacion_instructores_vehiculos { get; set; }

    public virtual DbSet<asignaciones_profesores> asignaciones_profesores { get; set; }

    public virtual DbSet<asignaciones_profesores_grado> asignaciones_profesores_grado { get; set; }

    public virtual DbSet<asignaciones_propedeutico> asignaciones_propedeutico { get; set; }

    public virtual DbSet<asignaciones_vacaciones> asignaciones_vacaciones { get; set; }

    public virtual DbSet<asignaturas> asignaturas { get; set; }

    public virtual DbSet<asignaturas_complementos_formacion> asignaturas_complementos_formacion { get; set; }

    public virtual DbSet<asignaturas_propedeutico> asignaturas_propedeutico { get; set; }

    public virtual DbSet<audit_logs> audit_logs { get; set; }

    public virtual DbSet<auditoria_pagos> auditoria_pagos { get; set; }

    public virtual DbSet<bien_apoyo> bien_apoyo { get; set; }

    public virtual DbSet<bien_apoyo_financiero> bien_apoyo_financiero { get; set; }

    public virtual DbSet<bien_convocatorias_becas> bien_convocatorias_becas { get; set; }

    public virtual DbSet<bien_datos_economicos> bien_datos_economicos { get; set; }

    public virtual DbSet<bien_datos_educacion> bien_datos_educacion { get; set; }

    public virtual DbSet<bien_detalle_vivienda> bien_detalle_vivienda { get; set; }

    public virtual DbSet<bien_ficha_socioeconomica> bien_ficha_socioeconomica { get; set; }

    public virtual DbSet<bien_genero_alumno> bien_genero_alumno { get; set; }

    public virtual DbSet<bien_motivos_beca> bien_motivos_beca { get; set; }

    public virtual DbSet<bien_nivel_instruccion> bien_nivel_instruccion { get; set; }

    public virtual DbSet<bien_parametro_requisito_beca> bien_parametro_requisito_beca { get; set; }

    public virtual DbSet<bien_parentescos> bien_parentescos { get; set; }

    public virtual DbSet<bien_parentezcos_alumno> bien_parentezcos_alumno { get; set; }

    public virtual DbSet<bien_porcentaje_beca> bien_porcentaje_beca { get; set; }

    public virtual DbSet<bien_postulacion_requisitos_becas> bien_postulacion_requisitos_becas { get; set; }

    public virtual DbSet<bien_postulaciones_becas> bien_postulaciones_becas { get; set; }

    public virtual DbSet<bien_requisitos_beca> bien_requisitos_beca { get; set; }

    public virtual DbSet<bien_resoluciones_tribunales> bien_resoluciones_tribunales { get; set; }

    public virtual DbSet<bien_servicios_fichas> bien_servicios_fichas { get; set; }

    public virtual DbSet<bien_tipo_apoyo_financiero> bien_tipo_apoyo_financiero { get; set; }

    public virtual DbSet<bien_tipo_cargo_tribunal> bien_tipo_cargo_tribunal { get; set; }

    public virtual DbSet<bien_tipo_convocatoria> bien_tipo_convocatoria { get; set; }

    public virtual DbSet<bien_tipo_servicios> bien_tipo_servicios { get; set; }

    public virtual DbSet<bien_tipo_vivienda> bien_tipo_vivienda { get; set; }

    public virtual DbSet<bien_tribunal> bien_tribunal { get; set; }

    public virtual DbSet<bien_votos_tribunales> bien_votos_tribunales { get; set; }

    public virtual DbSet<calificaciones> calificaciones { get; set; }

    public virtual DbSet<calificaciones_complementos_formacion> calificaciones_complementos_formacion { get; set; }

    public virtual DbSet<calificaciones_conduccion> calificaciones_conduccion { get; set; }

    public virtual DbSet<calificaciones_grado> calificaciones_grado { get; set; }

    public virtual DbSet<calificaciones_propedeutico> calificaciones_propedeutico { get; set; }

    public virtual DbSet<cambiosmalla> cambiosmalla { get; set; }

    public virtual DbSet<campo_amplio_unesco> campo_amplio_unesco { get; set; }

    public virtual DbSet<campo_detallado_unesco> campo_detallado_unesco { get; set; }

    public virtual DbSet<campo_especifico_unesco> campo_especifico_unesco { get; set; }

    public virtual DbSet<cargo_instituto> cargo_instituto { get; set; }

    public virtual DbSet<cargos_ofertas> cargos_ofertas { get; set; }

    public virtual DbSet<carreras> carreras { get; set; }

    public virtual DbSet<carreras_adjuntos> carreras_adjuntos { get; set; }

    public virtual DbSet<categoria_contratos> categoria_contratos { get; set; }

    public virtual DbSet<categoria_vehiculos> categoria_vehiculos { get; set; }

    public virtual DbSet<categorias_actividades> categorias_actividades { get; set; }

    public virtual DbSet<categorias_examenes_conduccion> categorias_examenes_conduccion { get; set; }

    public virtual DbSet<categorias_terminos_condiciones> categorias_terminos_condiciones { get; set; }

    public virtual DbSet<categoriassolicitudes> categoriassolicitudes { get; set; }

    public virtual DbSet<certificados_experiencia_laboral> certificados_experiencia_laboral { get; set; }

    public virtual DbSet<cierres_colectivos> cierres_colectivos { get; set; }

    public virtual DbSet<cierres_colectivos_exclusiones> cierres_colectivos_exclusiones { get; set; }

    public virtual DbSet<ciudades> ciudades { get; set; }

    public virtual DbSet<clausulas> clausulas { get; set; }

    public virtual DbSet<cliente_factura> cliente_factura { get; set; }

    public virtual DbSet<complementos_formacion> complementos_formacion { get; set; }

    public virtual DbSet<cond_alumnos_horarios> cond_alumnos_horarios { get; set; }

    public virtual DbSet<cond_alumnos_practicas> cond_alumnos_practicas { get; set; }

    public virtual DbSet<cond_alumnos_vehiculos> cond_alumnos_vehiculos { get; set; }

    public virtual DbSet<cond_practicas_horarios_alumnos> cond_practicas_horarios_alumnos { get; set; }

    public virtual DbSet<configsharepoint> configsharepoint { get; set; }

    public virtual DbSet<configuracion_vacaciones> configuracion_vacaciones { get; set; }

    public virtual DbSet<contratos> contratos { get; set; }

    public virtual DbSet<contratos_asignaturas> contratos_asignaturas { get; set; }

    public virtual DbSet<contratos_facturas> contratos_facturas { get; set; }

    public virtual DbSet<credito_alumno> credito_alumno { get; set; }

    public virtual DbSet<credito_alumno_detalle> credito_alumno_detalle { get; set; }

    public virtual DbSet<cron_cronograma> cron_cronograma { get; set; }

    public virtual DbSet<cron_detalle_cronograma> cron_detalle_cronograma { get; set; }

    public virtual DbSet<cron_dias_especiales> cron_dias_especiales { get; set; }

    public virtual DbSet<cron_tipo_dia_especial> cron_tipo_dia_especial { get; set; }

    public virtual DbSet<cron_tipo_proceso> cron_tipo_proceso { get; set; }

    public virtual DbSet<cuentas> cuentas { get; set; }

    public virtual DbSet<cursos> cursos { get; set; }

    public virtual DbSet<cursos_profesores> cursos_profesores { get; set; }

    public virtual DbSet<dedicacion> dedicacion { get; set; }

    public virtual DbSet<dedicacion_categorias> dedicacion_categorias { get; set; }

    public virtual DbSet<departamentos> departamentos { get; set; }

    public virtual DbSet<departamentossolicitudes> departamentossolicitudes { get; set; }

    public virtual DbSet<detalle_pagos> detalle_pagos { get; set; }

    public virtual DbSet<detalle_sistema_evaluacion> detalle_sistema_evaluacion { get; set; }

    public virtual DbSet<detallemallas> detallemallas { get; set; }

    public virtual DbSet<detalles_documentos_pagos> detalles_documentos_pagos { get; set; }

    public virtual DbSet<detalles_ofertas> detalles_ofertas { get; set; }

    public virtual DbSet<discapacidades> discapacidades { get; set; }

    public virtual DbSet<documentos_adjuntos> documentos_adjuntos { get; set; }

    public virtual DbSet<ed_alumnostest> ed_alumnostest { get; set; }

    public virtual DbSet<ed_encuestas> ed_encuestas { get; set; }

    public virtual DbSet<ed_fechasevaluacion> ed_fechasevaluacion { get; set; }

    public virtual DbSet<ed_preguntas> ed_preguntas { get; set; }

    public virtual DbSet<ed_respuestastest> ed_respuestastest { get; set; }

    public virtual DbSet<ed_respuestastestab> ed_respuestastestab { get; set; }

    public virtual DbSet<empresas> empresas { get; set; }

    public virtual DbSet<empresas_contactos> empresas_contactos { get; set; }

    public virtual DbSet<escalafon> escalafon { get; set; }

    public virtual DbSet<espacios> espacios { get; set; }

    public virtual DbSet<especies> especies { get; set; }

    public virtual DbSet<especies_extras> especies_extras { get; set; }

    public virtual DbSet<estadocivil> estadocivil { get; set; }

    public virtual DbSet<estadossolicitados> estadossolicitados { get; set; }

    public virtual DbSet<etnias> etnias { get; set; }

    public virtual DbSet<experiencias_laborales> experiencias_laborales { get; set; }

    public virtual DbSet<extras_contratos> extras_contratos { get; set; }

    public virtual DbSet<fechas_grados> fechas_grados { get; set; }

    public virtual DbSet<fechas_horarios> fechas_horarios { get; set; }

    public virtual DbSet<fechas_pagos> fechas_pagos { get; set; }

    public virtual DbSet<fechas_pagos_cuotas> fechas_pagos_cuotas { get; set; }

    public virtual DbSet<fechas_semanas> fechas_semanas { get; set; }

    public virtual DbSet<financiamiento_beca> financiamiento_beca { get; set; }

    public virtual DbSet<formaciones_academicas> formaciones_academicas { get; set; }

    public virtual DbSet<gest_audit_acciones> gest_audit_acciones { get; set; }

    public virtual DbSet<gest_audit_registros> gest_audit_registros { get; set; }

    public virtual DbSet<gest_password_resets> gest_password_resets { get; set; }

    public virtual DbSet<grados_academicos> grados_academicos { get; set; }

    public virtual DbSet<habilidades> habilidades { get; set; }

    public virtual DbSet<habilidades_requeridas> habilidades_requeridas { get; set; }

    public virtual DbSet<horario_detalle> horario_detalle { get; set; }

    public virtual DbSet<horario_profesores> horario_profesores { get; set; }

    public virtual DbSet<horas_academicas> horas_academicas { get; set; }

    public virtual DbSet<horas_clases> horas_clases { get; set; }

    public virtual DbSet<instituciones> instituciones { get; set; }

    public virtual DbSet<instituciones_instituto> instituciones_instituto { get; set; }

    public virtual DbSet<jornadas_ofertas> jornadas_ofertas { get; set; }

    public virtual DbSet<kardex_vacaciones> kardex_vacaciones { get; set; }

    public virtual DbSet<logsmigraciones> logsmigraciones { get; set; }

    public virtual DbSet<mallas> mallas { get; set; }

    public virtual DbSet<mallas_periodos> mallas_periodos { get; set; }

    public virtual DbSet<matriculas> matriculas { get; set; }

    public virtual DbSet<matriculas_asistencias> matriculas_asistencias { get; set; }

    public virtual DbSet<matriculas_examen_conduccion> matriculas_examen_conduccion { get; set; }

    public virtual DbSet<medios_contacto> medios_contacto { get; set; }

    public virtual DbSet<modalidades> modalidades { get; set; }

    public virtual DbSet<modalidades_carreras> modalidades_carreras { get; set; }

    public virtual DbSet<modalidades_ofertas> modalidades_ofertas { get; set; }

    public virtual DbSet<motivo_salida> motivo_salida { get; set; }

    public virtual DbSet<nacionalidades> nacionalidades { get; set; }

    public virtual DbSet<niveles_academicos> niveles_academicos { get; set; }

    public virtual DbSet<ofertas_carreras> ofertas_carreras { get; set; }

    public virtual DbSet<ofertas_laborales> ofertas_laborales { get; set; }

    public virtual DbSet<ofertas_requisitos> ofertas_requisitos { get; set; }

    public virtual DbSet<pagos> pagos { get; set; }

    public virtual DbSet<paises> paises { get; set; }

    public virtual DbSet<parametros> parametros { get; set; }

    public virtual DbSet<parametrostipossolicitudes> parametrostipossolicitudes { get; set; }

    public virtual DbSet<parciales> parciales { get; set; }

    public virtual DbSet<parciales_modalidades> parciales_modalidades { get; set; }

    public virtual DbSet<parciales_modalidades_fechas> parciales_modalidades_fechas { get; set; }

    public virtual DbSet<parroquias> parroquias { get; set; }

    public virtual DbSet<pd_aceptaciones_usuarios> pd_aceptaciones_usuarios { get; set; }

    public virtual DbSet<pd_categorias_terminos_condiciones> pd_categorias_terminos_condiciones { get; set; }

    public virtual DbSet<pd_terminos_condiciones> pd_terminos_condiciones { get; set; }

    public virtual DbSet<periodos> periodos { get; set; }

    public virtual DbSet<periodos_inscripciones> periodos_inscripciones { get; set; }

    public virtual DbSet<periodos_matriculas_niveles> periodos_matriculas_niveles { get; set; }

    public virtual DbSet<permisos> permisos { get; set; }

    public virtual DbSet<planificacion_vacaciones> planificacion_vacaciones { get; set; }

    public virtual DbSet<plantilla_clausulas> plantilla_clausulas { get; set; }

    public virtual DbSet<plantilla_contrato> plantilla_contrato { get; set; }

    public virtual DbSet<plantillas> plantillas { get; set; }

    public virtual DbSet<plantillas_documentos> plantillas_documentos { get; set; }

    public virtual DbSet<plantillasparametros> plantillasparametros { get; set; }

    public virtual DbSet<postulaciones> postulaciones { get; set; }

    public virtual DbSet<prerequisitos> prerequisitos { get; set; }

    public virtual DbSet<procesos_usuario> procesos_usuario { get; set; }

    public virtual DbSet<profesores> profesores { get; set; }

    public virtual DbSet<profesores_actas_parciales> profesores_actas_parciales { get; set; }

    public virtual DbSet<profesores_actividades> profesores_actividades { get; set; }

    public virtual DbSet<profesores_carreras_periodos> profesores_carreras_periodos { get; set; }

    public virtual DbSet<profesores_dedicacion> profesores_dedicacion { get; set; }

    public virtual DbSet<profesores_motivo_salida> profesores_motivo_salida { get; set; }

    public virtual DbSet<provincias> provincias { get; set; }

    public virtual DbSet<rbac_modulos> rbac_modulos { get; set; }

    public virtual DbSet<rbac_modulos_operaciones> rbac_modulos_operaciones { get; set; }

    public virtual DbSet<rbac_operaciones> rbac_operaciones { get; set; }

    public virtual DbSet<rbac_refresh_tokens> rbac_refresh_tokens { get; set; }

    public virtual DbSet<rbac_rol> rbac_rol { get; set; }

    public virtual DbSet<rbac_rol_modulo_operacion> rbac_rol_modulo_operacion { get; set; }

    public virtual DbSet<rbac_sistema> rbac_sistema { get; set; }

    public virtual DbSet<rbac_usuario_rol> rbac_usuario_rol { get; set; }

    public virtual DbSet<recuperacion_tiempo> recuperacion_tiempo { get; set; }

    public virtual DbSet<relacion_ies> relacion_ies { get; set; }

    public virtual DbSet<respuestassolicitudes> respuestassolicitudes { get; set; }

    public virtual DbSet<restricciones> restricciones { get; set; }

    public virtual DbSet<saldos_vacaciones> saldos_vacaciones { get; set; }

    public virtual DbSet<secciones> secciones { get; set; }

    public virtual DbSet<sectores_empresas> sectores_empresas { get; set; }

    public virtual DbSet<seddautoevaluacion> seddautoevaluacion { get; set; }

    public virtual DbSet<seddautoriadesperiodos> seddautoriadesperiodos { get; set; }

    public virtual DbSet<seddautoridadescarrerasperiodos> seddautoridadescarrerasperiodos { get; set; }

    public virtual DbSet<seddcoevaluacion> seddcoevaluacion { get; set; }

    public virtual DbSet<seddcoevaluacionautoridad> seddcoevaluacionautoridad { get; set; }

    public virtual DbSet<sedddetalleautoevaluacion> sedddetalleautoevaluacion { get; set; }

    public virtual DbSet<sedddetallecoevaluacion> sedddetallecoevaluacion { get; set; }

    public virtual DbSet<sedddetallecoevaluacionautoridad> sedddetallecoevaluacionautoridad { get; set; }

    public virtual DbSet<sedddetalleheteroevaluacion> sedddetalleheteroevaluacion { get; set; }

    public virtual DbSet<seddheteroevaluacion> seddheteroevaluacion { get; set; }

    public virtual DbSet<seddinsitu> seddinsitu { get; set; }

    public virtual DbSet<seddinstrumentos> seddinstrumentos { get; set; }

    public virtual DbSet<seddinstrumentospreguntas> seddinstrumentospreguntas { get; set; }

    public virtual DbSet<seddpreguntas> seddpreguntas { get; set; }

    public virtual DbSet<seedevaluadoresinsitu> seedevaluadoresinsitu { get; set; }

    public virtual DbSet<semanas_horarios> semanas_horarios { get; set; }

    public virtual DbSet<sistema_titulacion> sistema_titulacion { get; set; }

    public virtual DbSet<solicitudes> solicitudes { get; set; }

    public virtual DbSet<solicitudes_licencias> solicitudes_licencias { get; set; }

    public virtual DbSet<solicitudes_vacaciones> solicitudes_vacaciones { get; set; }

    public virtual DbSet<solicitudescalificaciones> solicitudescalificaciones { get; set; }

    public virtual DbSet<solicitudeslogs> solicitudeslogs { get; set; }

    public virtual DbSet<subcategoria_vehiculos> subcategoria_vehiculos { get; set; }

    public virtual DbSet<subcategorias_actividades> subcategorias_actividades { get; set; }

    public virtual DbSet<sueldos_contratos> sueldos_contratos { get; set; }

    public virtual DbSet<terminos_condiciones> terminos_condiciones { get; set; }

    public virtual DbSet<tipo_contacto> tipo_contacto { get; set; }

    public virtual DbSet<tipo_funcionario> tipo_funcionario { get; set; }

    public virtual DbSet<tipos_asignatura> tipos_asignatura { get; set; }

    public virtual DbSet<tipos_becas> tipos_becas { get; set; }

    public virtual DbSet<tipos_contratos> tipos_contratos { get; set; }

    public virtual DbSet<tipos_documentos> tipos_documentos { get; set; }

    public virtual DbSet<tipos_ofertas> tipos_ofertas { get; set; }

    public virtual DbSet<tipos_permisos> tipos_permisos { get; set; }

    public virtual DbSet<tiposangre> tiposangre { get; set; }

    public virtual DbSet<tiposdocumentosi> tiposdocumentosi { get; set; }

    public virtual DbSet<tipossolicitudes> tipossolicitudes { get; set; }

    public virtual DbSet<titulos> titulos { get; set; }

    public virtual DbSet<titulos_en_curso> titulos_en_curso { get; set; }

    public virtual DbSet<titulos_profesores> titulos_profesores { get; set; }

    public virtual DbSet<universidades> universidades { get; set; }

    public virtual DbSet<usuarios> usuarios { get; set; }

    public virtual DbSet<usuarios_web> usuarios_web { get; set; }

    public virtual DbSet<usuariosdepartamentossolicitudes> usuariosdepartamentossolicitudes { get; set; }

    public virtual DbSet<usuariossolicitudes> usuariossolicitudes { get; set; }

    public virtual DbSet<vacaciones_ledger> vacaciones_ledger { get; set; }

    public virtual DbSet<vehiculos> vehiculos { get; set; }

    public virtual DbSet<vehiculos_operacion> vehiculos_operacion { get; set; }

    public virtual DbSet<vinculacionarea> vinculacionarea { get; set; }

    public virtual DbSet<vinculacioncategoriasobjetivosoportunidades> vinculacioncategoriasobjetivosoportunidades { get; set; }

    public virtual DbSet<vinculacioncategoriasresultadosaprendizajes> vinculacioncategoriasresultadosaprendizajes { get; set; }

    public virtual DbSet<vinculacionestadosproyectos> vinculacionestadosproyectos { get; set; }

    public virtual DbSet<vinculacionhabilidadesblandas> vinculacionhabilidadesblandas { get; set; }

    public virtual DbSet<vinculacionimpactosproyectos> vinculacionimpactosproyectos { get; set; }

    public virtual DbSet<vinculacionlineasaccion> vinculacionlineasaccion { get; set; }

    public virtual DbSet<vinculacionobjetivosoportunidades> vinculacionobjetivosoportunidades { get; set; }

    public virtual DbSet<vinculacionobjetivospedis> vinculacionobjetivospedis { get; set; }

    public virtual DbSet<vinculacionpoblaciondirecta> vinculacionpoblaciondirecta { get; set; }

    public virtual DbSet<vinculacionpoblacionexterna> vinculacionpoblacionexterna { get; set; }

    public virtual DbSet<vinculacionpoblacionindirecta> vinculacionpoblacionindirecta { get; set; }

    public virtual DbSet<vinculacionprogramas> vinculacionprogramas { get; set; }

    public virtual DbSet<vinculacionproyectos> vinculacionproyectos { get; set; }

    public virtual DbSet<vinculacionproyectosalumnos> vinculacionproyectosalumnos { get; set; }

    public virtual DbSet<vinculacionproyectoscarreras> vinculacionproyectoscarreras { get; set; }

    public virtual DbSet<vinculacionproyectoscarrerasdetalle> vinculacionproyectoscarrerasdetalle { get; set; }

    public virtual DbSet<vinculacionproyectoscronograma> vinculacionproyectoscronograma { get; set; }

    public virtual DbSet<vinculacionproyectosentidades> vinculacionproyectosentidades { get; set; }

    public virtual DbSet<vinculacionproyectoshabilidadesblandas> vinculacionproyectoshabilidadesblandas { get; set; }

    public virtual DbSet<vinculacionproyectosimpactos> vinculacionproyectosimpactos { get; set; }

    public virtual DbSet<vinculacionproyectosmateriales> vinculacionproyectosmateriales { get; set; }

    public virtual DbSet<vinculacionproyectosobjetivos> vinculacionproyectosobjetivos { get; set; }

    public virtual DbSet<vinculacionproyectosobjetivosoportunidades> vinculacionproyectosobjetivosoportunidades { get; set; }

    public virtual DbSet<vinculacionproyectosobjetivospedis> vinculacionproyectosobjetivospedis { get; set; }

    public virtual DbSet<vinculacionproyectosperiodos> vinculacionproyectosperiodos { get; set; }

    public virtual DbSet<vinculacionproyectosplanesaprendizaje> vinculacionproyectosplanesaprendizaje { get; set; }

    public virtual DbSet<vinculacionproyectosplantrabajo> vinculacionproyectosplantrabajo { get; set; }

    public virtual DbSet<vinculacionproyectospoblaciones> vinculacionproyectospoblaciones { get; set; }

    public virtual DbSet<vinculacionproyectospresupuestos> vinculacionproyectospresupuestos { get; set; }

    public virtual DbSet<vinculacionproyectosprofesores> vinculacionproyectosprofesores { get; set; }

    public virtual DbSet<vinculacionproyectosresponsables> vinculacionproyectosresponsables { get; set; }

    public virtual DbSet<vinculacionproyectosresultadosaprendizaje> vinculacionproyectosresultadosaprendizaje { get; set; }

    public virtual DbSet<vinculacionsubarea> vinculacionsubarea { get; set; }

    public virtual DbSet<vinculacionsubareaespecifica> vinculacionsubareaespecifica { get; set; }

    public virtual DbSet<vinculaciontiposobjetivos> vinculaciontiposobjetivos { get; set; }

    public virtual DbSet<vinculaciontipospoblaciones> vinculaciontipospoblaciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("name=sigafi_es");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<aceptaciones_usuarios>(entity =>
        {
            entity.HasKey(e => e.idAceptacionUsuario).HasName("PRIMARY");

            entity.Property(e => e.dispositivo).HasMaxLength(200);
            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.idUsuario).HasMaxLength(14);
            entity.Property(e => e.ipOrigen).HasMaxLength(50);
            entity.Property(e => e.sistema).HasMaxLength(100);
        });

        modelBuilder.Entity<adjuntos_imagenes>(entity =>
        {
            entity.HasKey(e => e.idAdjuntos_Imagenes).HasName("PRIMARY");

            entity.Property(e => e.Extension).HasMaxLength(90);
            entity.Property(e => e.MimeTypes).HasMaxLength(90);
            entity.Property(e => e.NombreArchivos).HasMaxLength(90);
            entity.Property(e => e.Ruta).HasMaxLength(255);
        });

        modelBuilder.Entity<administrador>(entity =>
        {
            entity.HasKey(e => e.idAdministrador).HasName("PRIMARY");

            entity.Property(e => e.idAdministrador).HasMaxLength(16);
            entity.Property(e => e.ApellidosCompletos).HasMaxLength(120);
            entity.Property(e => e.NombresCompletos).HasMaxLength(120);
            entity.Property(e => e.fecha_Asignacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");
            entity.Property(e => e.password).HasMaxLength(90);
            entity.Property(e => e.primerIngreso).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<agenda_academica>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.evento).HasMaxLength(250);
            entity.Property(e => e.fecha_desde).HasColumnType("date");
            entity.Property(e => e.fecha_hasta).HasColumnType("date");
            entity.Property(e => e.idperiodo).HasMaxLength(7);
        });

        modelBuilder.Entity<alumnos>(entity =>
        {
            entity.HasKey(e => e.idAlumno).HasName("PRIMARY");

            entity.HasIndex(e => e.IdEstadoCivil, "fk_alumnos_estadoCivil_idx");

            entity.HasIndex(e => e.idGeneroAlumno, "fk_alumnos_genero_idx");

            entity.HasIndex(e => e.idNacionalidadEtnica, "fk_alumnos_nacionalidad_idx");

            entity.HasIndex(e => e.idParroquiaResidencia, "fk_alumnos_parroquiaResidencia_idx");

            entity.Property(e => e.idAlumno)
                .HasMaxLength(14)
                .HasDefaultValueSql("''");
            entity.Property(e => e.apellidoMaterno).HasMaxLength(30);
            entity.Property(e => e.apellidoPaterno).HasMaxLength(30);
            entity.Property(e => e.archivofoto).HasMaxLength(100);
            entity.Property(e => e.barrio_residencia).HasMaxLength(150);
            entity.Property(e => e.carnet_conadis).HasMaxLength(20);
            entity.Property(e => e.celular).HasMaxLength(20);
            entity.Property(e => e.ciudad_Nacimiento).HasMaxLength(30);
            entity.Property(e => e.ciudad_residencia).HasMaxLength(100);
            entity.Property(e => e.direccion).HasMaxLength(60);
            entity.Property(e => e.email).HasMaxLength(40);
            entity.Property(e => e.email_institucional).HasMaxLength(100);
            entity.Property(e => e.fecha_Inscripcion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fecha_Nacimiento).HasColumnType("date");
            entity.Property(e => e.idNivel).HasDefaultValueSql("'1'");
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.nacionalidad).HasMaxLength(50);
            entity.Property(e => e.nacionalidad_madre).HasMaxLength(150);
            entity.Property(e => e.nacionalidad_padre).HasMaxLength(30);
            entity.Property(e => e.nombre_madre).HasMaxLength(150);
            entity.Property(e => e.nombre_padre).HasMaxLength(150);
            entity.Property(e => e.ocupacion_madre).HasMaxLength(150);
            entity.Property(e => e.ocupacion_padre).HasMaxLength(150);
            entity.Property(e => e.parroquia_nacimiento).HasMaxLength(100);
            entity.Property(e => e.parroquia_residencia).HasMaxLength(150);
            entity.Property(e => e.password).HasMaxLength(20);
            entity.Property(e => e.primerIngreso).HasDefaultValueSql("'1'");
            entity.Property(e => e.primerNombre).HasMaxLength(30);
            entity.Property(e => e.provincia_Nacimiento).HasMaxLength(40);
            entity.Property(e => e.segundoNombre).HasMaxLength(30);
            entity.Property(e => e.sexo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.telefono).HasMaxLength(20);
            entity.Property(e => e.tipoDocumento)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.tipoInstitucion).HasMaxLength(255);
            entity.Property(e => e.tipo_sangre).HasMaxLength(6);
            entity.Property(e => e.tituloColegio).HasMaxLength(200);
            entity.Property(e => e.user_alumno).HasMaxLength(20);

            entity.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.alumnos)
                .HasForeignKey(d => d.IdEstadoCivil)
                .HasConstraintName("fk_alumnos_estadoCivil");

            entity.HasOne(d => d.idGeneroAlumnoNavigation).WithMany(p => p.alumnos)
                .HasForeignKey(d => d.idGeneroAlumno)
                .HasConstraintName("fk_alumnos_genero");

            entity.HasOne(d => d.idNacionalidadEtnicaNavigation).WithMany(p => p.alumnos)
                .HasForeignKey(d => d.idNacionalidadEtnica)
                .HasConstraintName("fk_alumnos_nacionalidad");

            entity.HasOne(d => d.idParroquiaResidenciaNavigation).WithMany(p => p.alumnos)
                .HasForeignKey(d => d.idParroquiaResidencia)
                .HasConstraintName("fk_alumnos_parroquiaResidencia");
        });

        modelBuilder.Entity<alumnos_acta_conduccion>(entity =>
        {
            entity.HasKey(e => new { e.idalumno, e.idperiodo }).HasName("PRIMARY");

            entity.Property(e => e.idalumno).HasMaxLength(14);
            entity.Property(e => e.idperiodo).HasMaxLength(7);
            entity.Property(e => e.fecha_grado).HasColumnType("date");
        });

        modelBuilder.Entity<alumnos_carreras>(entity =>
        {
            entity.HasKey(e => new { e.idAlumno, e.idCarrera }).HasName("PRIMARY");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.carrera_convalidada).HasMaxLength(100);
            entity.Property(e => e.convalidacion).HasDefaultValueSql("'0'");
            entity.Property(e => e.creditos_convalidados).HasDefaultValueSql("'0'");
            entity.Property(e => e.creditos_pasantia).HasDefaultValueSql("'0'");
            entity.Property(e => e.institucion_convalidada).HasMaxLength(100);
            entity.Property(e => e.nota_defensa)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_documento)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_pasantia)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_tesis)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.pasantias).HasDefaultValueSql("'0'");
            entity.Property(e => e.trabajo_grado).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<alumnos_habilidades>(entity =>
        {
            entity.HasKey(e => e.idalumnos_habilidades).HasName("PRIMARY");

            entity.HasIndex(e => e.idhabilidades, "idhabilidades");

            entity.Property(e => e.fecha_creacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.nivel).HasColumnType("enum('basico','intermedio','avanzado')");

            entity.HasOne(d => d.idhabilidadesNavigation).WithMany(p => p.alumnos_habilidades)
                .HasForeignKey(d => d.idhabilidades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("alumnos_habilidades_ibfk_1");
        });

        modelBuilder.Entity<alumnos_inscripciones>(entity =>
        {
            entity.HasKey(e => e.idInscripcion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idalumno).HasMaxLength(14);
            entity.Property(e => e.usuario).HasMaxLength(20);
        });

        modelBuilder.Entity<alumnos_inscripciones_ingles>(entity =>
        {
            entity.HasKey(e => new { e.idAlumno, e.idPeriodo }).HasName("PRIMARY");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.fechaRegistro)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.user_inscripcion).HasMaxLength(20);
        });

        modelBuilder.Entity<alumnos_referencias>(entity =>
        {
            entity.HasKey(e => e.idalumnos_referencias).HasName("PRIMARY");

            entity.Property(e => e.contacto).HasMaxLength(255);
            entity.Property(e => e.fecha_creacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.nombres_referencia).HasMaxLength(255);
            entity.Property(e => e.referencia_empresa).HasMaxLength(150);
            entity.Property(e => e.relacion).HasMaxLength(100);
        });

        modelBuilder.Entity<alumnos_restricciones>(entity =>
        {
            entity.HasKey(e => new { e.idalumno, e.idrestriccion }).HasName("PRIMARY");

            entity.Property(e => e.idalumno).HasMaxLength(14);
            entity.Property(e => e.idrestriccion).HasMaxLength(5);
        });

        modelBuilder.Entity<alumnos_sucesos>(entity =>
        {
            entity.HasKey(e => e.idSuceso).HasName("PRIMARY");

            entity.Property(e => e.fechaRegistro)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.observacion).HasMaxLength(200);
            entity.Property(e => e.usuario)
                .HasMaxLength(100)
                .HasDefaultValueSql("'current_user'");
        });

        modelBuilder.Entity<alumnos_titulos>(entity =>
        {
            entity.HasKey(e => new { e.idAlumno, e.idTitulo }).HasName("PRIMARY");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.fecha)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fecha_acta).HasColumnType("date");
            entity.Property(e => e.nota_complexivo)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_defensa)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_final)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_trabajo)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.numero_acta).HasMaxLength(20);
            entity.Property(e => e.primer_vocal).HasMaxLength(100);
            entity.Property(e => e.promedio_estudios)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.puntaje_total)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.rector).HasMaxLength(100);
            entity.Property(e => e.secretaria).HasMaxLength(100);
            entity.Property(e => e.segundo_vocal).HasMaxLength(100);
            entity.Property(e => e.tercer_vocal).HasMaxLength(100);
            entity.Property(e => e.titulo_tesis).HasMaxLength(400);
            entity.Property(e => e.total_asignaturas).HasDefaultValueSql("'0'");
            entity.Property(e => e.total_creditos).HasDefaultValueSql("'0'");
            entity.Property(e => e.total_horas).HasDefaultValueSql("'0'");
            entity.Property(e => e.vicerrector).HasMaxLength(100);
        });

        modelBuilder.Entity<asignacion_instructores_vehiculos>(entity =>
        {
            entity.HasKey(e => e.idAsignacion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fecha_asignacion).HasColumnType("date");
            entity.Property(e => e.fecha_salidad).HasColumnType("date");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.observacion).HasMaxLength(200);
            entity.Property(e => e.usuario_asigna).HasMaxLength(20);
            entity.Property(e => e.usuario_desactiva).HasMaxLength(20);
        });

        modelBuilder.Entity<asignaciones_profesores>(entity =>
        {
            entity.HasKey(e => new { e.idProfesor, e.idAsignatura, e.idPeriodo, e.idModalidad, e.idSeccion, e.idNivel, e.paralelo }).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignacion, "idAsignacion").IsUnique();

            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.paralelo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigo_asignacion).HasMaxLength(10);
            entity.Property(e => e.contabilizarHoraDocente).HasDefaultValueSql("'1'");
            entity.Property(e => e.entrega_acta).HasDefaultValueSql("'0'");
            entity.Property(e => e.esActivaAsignacion).HasDefaultValueSql("'1'");
            entity.Property(e => e.extraCurricular).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha_fin).HasColumnType("date");
            entity.Property(e => e.fecha_grabar).HasColumnType("datetime");
            entity.Property(e => e.fecha_inicial).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("datetime");
            entity.Property(e => e.horasPracticoExperimental)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.idAsignacion).ValueGeneratedOnAdd();
            entity.Property(e => e.ingresa_notas).HasDefaultValueSql("'0'");
            entity.Property(e => e.numeroHoras).HasPrecision(10);
            entity.Property(e => e.user_acta).HasMaxLength(25);
            entity.Property(e => e.user_asignaciones).HasMaxLength(25);
        });

        modelBuilder.Entity<asignaciones_profesores_grado>(entity =>
        {
            entity.HasKey(e => new { e.idProfesor, e.idAsignatura, e.idPeriodo, e.idModalidad, e.idSeccion, e.idNivel, e.paralelo }).HasName("PRIMARY");

            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.paralelo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<asignaciones_propedeutico>(entity =>
        {
            entity.HasKey(e => new { e.idCarrera, e.idAsignatura }).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<asignaciones_vacaciones>(entity =>
        {
            entity.HasKey(e => e.id_asignacion).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Asignaciones individuales directas de vacaciones programadas por RRHH"));

            entity.HasIndex(e => e.id_profesor, "fk_asignaciones_vac_profesores");

            entity.HasIndex(e => e.registrado_por_id, "fk_asignaciones_vac_usuarios");

            entity.Property(e => e.dias_asignados).HasComment("Total de días calendario calculados a descontar");
            entity.Property(e => e.fecha_creacion)
                .HasComment("Fecha de registro de la asignación")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_fin)
                .HasComment("Fecha de finalización del descanso")
                .HasColumnType("date");
            entity.Property(e => e.fecha_inicio)
                .HasComment("Fecha de inicio del descanso")
                .HasColumnType("date");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Profesor asignado");
            entity.Property(e => e.observacion_rrhh)
                .HasComment("Justificación o notas de Talento Humano")
                .HasColumnType("text");
            entity.Property(e => e.registrado_por_id).HasComment("Usuario de RRHH que realiza el registro directo");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.asignaciones_vacaciones)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asignaciones_vac_profesores");

            entity.HasOne(d => d.registrado_por).WithMany(p => p.asignaciones_vacaciones)
                .HasForeignKey(d => d.registrado_por_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asignaciones_vac_usuarios");
        });

        modelBuilder.Entity<asignaturas>(entity =>
        {
            entity.HasKey(e => e.idAsignatura).HasName("PRIMARY");

            entity.Property(e => e.asignatura).HasMaxLength(200);
            entity.Property(e => e.codigo).HasMaxLength(30);
            entity.Property(e => e.extraCurricular).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<asignaturas_complementos_formacion>(entity =>
        {
            entity.HasKey(e => e.idAsignatura).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.asignatura).HasMaxLength(100);
        });

        modelBuilder.Entity<asignaturas_propedeutico>(entity =>
        {
            entity.HasKey(e => e.idAsignatura).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.asignatura).HasMaxLength(50);
        });

        modelBuilder.Entity<audit_logs>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.HasIndex(e => e.accion, "idx_audit_accion");

            entity.HasIndex(e => e.fecha_hora, "idx_audit_fecha");

            entity.HasIndex(e => e.usuario, "idx_audit_usuario");

            entity.Property(e => e.accion).HasMaxLength(50);
            entity.Property(e => e.detalles).HasColumnType("text");
            entity.Property(e => e.entidad_id).HasMaxLength(100);
            entity.Property(e => e.fecha_hora)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.ip_origen).HasMaxLength(45);
            entity.Property(e => e.usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<auditoria_pagos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.cuenta).HasMaxLength(50);
            entity.Property(e => e.fecha)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.numero_deposito).HasMaxLength(20);
            entity.Property(e => e.usuario).HasMaxLength(20);
        });

        modelBuilder.Entity<bien_apoyo>(entity =>
        {
            entity.HasKey(e => e.idBienApoyo).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(50);
        });

        modelBuilder.Entity<bien_apoyo_financiero>(entity =>
        {
            entity.HasKey(e => e.idApoyoFinanciero).HasName("PRIMARY");

            entity.HasIndex(e => e.idResolucionesTribunales, "fk_bien_ayudas_economicas_bien_resoluciones_tribunales1_idx");

            entity.HasIndex(e => e.idMatricula, "fk_bien_ayudas_economicas_matriculas1_idx");

            entity.HasIndex(e => e.idResponsable, "fk_bien_ayudas_economicas_usuarios1_idx");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaAceptacion).HasColumnType("date");
            entity.Property(e => e.observacion).HasMaxLength(100);

            entity.HasOne(d => d.idMatriculaNavigation).WithMany(p => p.bien_apoyo_financiero)
                .HasForeignKey(d => d.idMatricula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_ayudas_economicas_matriculas1");

            entity.HasOne(d => d.idResolucionesTribunalesNavigation).WithMany(p => p.bien_apoyo_financiero)
                .HasForeignKey(d => d.idResolucionesTribunales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_ayudas_economicas_bien_resoluciones_tribunales1");

            entity.HasOne(d => d.idResponsableNavigation).WithMany(p => p.bien_apoyo_financiero)
                .HasForeignKey(d => d.idResponsable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_apoyo_financiero_usarioResponsable1");
        });

        modelBuilder.Entity<bien_convocatorias_becas>(entity =>
        {
            entity.HasKey(e => e.idConvocatoriasBecas).HasName("PRIMARY");

            entity.HasIndex(e => e.idDetalleCronograma, "fk_bien_convocatorias_becas_cron_detalle_cronograma1_idx");

            entity.HasIndex(e => e.idTipoConvocatoria, "fk_bien_tipo_convocatoria_beca_idx");

            entity.Property(e => e.fechaFin).HasColumnType("date");
            entity.Property(e => e.fechaInicio).HasColumnType("date");

            entity.HasOne(d => d.idDetalleCronogramaNavigation).WithMany(p => p.bien_convocatorias_becas)
                .HasForeignKey(d => d.idDetalleCronograma)
                .HasConstraintName("fk_bien_convocatorias_becas_cron_detalle_cronograma1");

            entity.HasOne(d => d.idTipoConvocatoriaNavigation).WithMany(p => p.bien_convocatorias_becas)
                .HasForeignKey(d => d.idTipoConvocatoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_tipo_convocatoria_beca");
        });

        modelBuilder.Entity<bien_datos_economicos>(entity =>
        {
            entity.HasKey(e => e.idFichaSocioEconomica).HasName("PRIMARY");

            entity.HasIndex(e => e.idFichaSocioEconomica, "fk_recibeBono_bien_ficha_socioeconomica1_idx");

            entity.Property(e => e.empleaIngresos).HasMaxLength(255);
            entity.Property(e => e.ingresosPropios).HasPrecision(10);
            entity.Property(e => e.nombreBono).HasMaxLength(50);
            entity.Property(e => e.tipoActividadEconomica)
                .HasDefaultValueSql("'estudia'")
                .HasColumnType("enum('estudia','trabaja','ambos','ninguna')");

            entity.HasOne(d => d.idFichaSocioEconomicaNavigation).WithOne(p => p.bien_datos_economicos)
                .HasForeignKey<bien_datos_economicos>(d => d.idFichaSocioEconomica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recibeBono_bien_ficha_socioeconomica1");
        });

        modelBuilder.Entity<bien_datos_educacion>(entity =>
        {
            entity.HasKey(e => e.idDatosEducacion).HasName("PRIMARY");

            entity.HasIndex(e => e.idAlumno, "fk_bien_datos_educacion_alumnos1_idx");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.nivelEducacion).HasColumnType("enum('tercer','cuarto','otro')");
            entity.Property(e => e.nombreCurso).HasMaxLength(100);
            entity.Property(e => e.nombreInstitucion).HasMaxLength(150);
            entity.Property(e => e.tipoEducacion).HasColumnType("enum('publica','privada')");

            entity.HasOne(d => d.idAlumnoNavigation).WithMany(p => p.bien_datos_educacion)
                .HasForeignKey(d => d.idAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_datos_educacion_alumnos1");
        });

        modelBuilder.Entity<bien_detalle_vivienda>(entity =>
        {
            entity.HasKey(e => e.idAlumno).HasName("PRIMARY");

            entity.HasIndex(e => e.idFichaSocioEconomica, "fk_bien_detalle_vivienda_bien_detalle_alumno1_idx");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.ingresoPromedioHogar).HasPrecision(10);
            entity.Property(e => e.referencia).HasMaxLength(255);
            entity.Property(e => e.tipoDeVivienda).HasMaxLength(45);

            entity.HasOne(d => d.idFichaSocioEconomicaNavigation).WithMany(p => p.bien_detalle_vivienda)
                .HasForeignKey(d => d.idFichaSocioEconomica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_detalle_vivienda_bien_detalle_alumno1");
        });

        modelBuilder.Entity<bien_ficha_socioeconomica>(entity =>
        {
            entity.HasKey(e => e.idFichaSocioEconomica).HasName("PRIMARY");

            entity.HasIndex(e => e.idAlumno, "fk_bien_ficha_socioeconomica_alumnos1_idx");

            entity.HasIndex(e => e.idTipoVivienda, "fk_bien_ficha_socioeconomica_bien_tipo_vivienda1_idx");

            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.razonActualizacion).HasMaxLength(45);
            entity.Property(e => e.ultimaFechaActualizacion).HasMaxLength(45);

            entity.HasOne(d => d.idAlumnoNavigation).WithMany(p => p.bien_ficha_socioeconomica)
                .HasForeignKey(d => d.idAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_ficha_socioeconomica_alumnos1");

            entity.HasOne(d => d.idTipoViviendaNavigation).WithMany(p => p.bien_ficha_socioeconomica)
                .HasForeignKey(d => d.idTipoVivienda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_ficha_socioeconomica_bien_tipo_vivienda1");
        });

        modelBuilder.Entity<bien_genero_alumno>(entity =>
        {
            entity.HasKey(e => e.idGeneroAlumno).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(30);
        });

        modelBuilder.Entity<bien_motivos_beca>(entity =>
        {
            entity.HasKey(e => e.idMotivosBeca).HasName("PRIMARY");

            entity.HasIndex(e => e.idPorcentajeBeca, "fk_bien_motivos_beca_bien_porcentaje_beca1_idx");

            entity.HasIndex(e => e.idTipoApoyoFinanciero, "fk_bien_motivos_beca_bien_tipo_apoyo_financiero1_idx");

            entity.HasIndex(e => new { e.idPorcentajeBeca, e.idTipoApoyoFinanciero, e.esActivo }, "uq_motivo_porcetaje_default").IsUnique();

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idPorcentajeBecaNavigation).WithMany(p => p.bien_motivos_beca)
                .HasForeignKey(d => d.idPorcentajeBeca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_motivos_beca_bien_porcentaje_beca1");

            entity.HasOne(d => d.idTipoApoyoFinancieroNavigation).WithMany(p => p.bien_motivos_beca)
                .HasForeignKey(d => d.idTipoApoyoFinanciero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_motivos_beca_bien_tipo_apoyo_financiero1");
        });

        modelBuilder.Entity<bien_nivel_instruccion>(entity =>
        {
            entity.HasKey(e => e.idNivelInstruccion).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(50);
        });

        modelBuilder.Entity<bien_parametro_requisito_beca>(entity =>
        {
            entity.HasKey(e => e.idParametroRequisitoBeca).HasName("PRIMARY");

            entity.HasIndex(e => e.idRequistosBeca, "fk_bien_parametro_requisito_beca_bien_requisitos_beca1_idx");

            entity.HasIndex(e => e.idTipoApoyoFinanciero, "fk_bien_parametro_requisito_beca_bien_tipo_apoyo_financiero_idx");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idRequistosBecaNavigation).WithMany(p => p.bien_parametro_requisito_beca)
                .HasForeignKey(d => d.idRequistosBeca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_parametro_requisito_beca_bien_requisitos_beca1");

            entity.HasOne(d => d.idTipoApoyoFinancieroNavigation).WithMany(p => p.bien_parametro_requisito_beca)
                .HasForeignKey(d => d.idTipoApoyoFinanciero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_parametro_requisito_beca_bien_tipo_apoyo_financiero1");
        });

        modelBuilder.Entity<bien_parentescos>(entity =>
        {
            entity.HasKey(e => e.idParentezco).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<bien_parentezcos_alumno>(entity =>
        {
            entity.HasKey(e => e.idParentezcoAlumno).HasName("PRIMARY");

            entity.HasIndex(e => e.idNivelInstruccion, "fk_bien_parentezcos_alumno_bien_nivel_instruccion1_idx");

            entity.HasIndex(e => e.idpaises, "fk_bien_parentezcos_alumno_paises1_idx");

            entity.HasIndex(e => e.idAlumno, "fk_bien_parentezcos_fichas_personas_alumnos1_idx");

            entity.HasIndex(e => e.idParentezco, "fk_bien_parentezcos_fichas_personas_bien_parentescos1_idx");

            entity.Property(e => e.esCarga).HasDefaultValueSql("'0'");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.ingresoMensualPromedio).HasPrecision(10);
            entity.Property(e => e.nombre).HasMaxLength(90);
            entity.Property(e => e.numeroContactoEmergencia).HasMaxLength(45);
            entity.Property(e => e.tieneDiscapacidad).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idAlumnoNavigation).WithMany(p => p.bien_parentezcos_alumno)
                .HasForeignKey(d => d.idAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_parentezcos_fichas_personas_alumnos1");

            entity.HasOne(d => d.idNivelInstruccionNavigation).WithMany(p => p.bien_parentezcos_alumno)
                .HasForeignKey(d => d.idNivelInstruccion)
                .HasConstraintName("fk_bien_parentezcos_alumno_bien_nivel_instruccion1");

            entity.HasOne(d => d.idParentezcoNavigation).WithMany(p => p.bien_parentezcos_alumno)
                .HasForeignKey(d => d.idParentezco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_parentezcos_fichas_personas_bien_parentescos1");

            entity.HasOne(d => d.idpaisesNavigation).WithMany(p => p.bien_parentezcos_alumno)
                .HasForeignKey(d => d.idpaises)
                .HasConstraintName("fk_bien_parentezcos_alumno_paises1");
        });

        modelBuilder.Entity<bien_porcentaje_beca>(entity =>
        {
            entity.HasKey(e => e.idPorcentajeBeca).HasName("PRIMARY");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.porcentaje).HasPrecision(10);
        });

        modelBuilder.Entity<bien_postulacion_requisitos_becas>(entity =>
        {
            entity.HasKey(e => e.idPostulacionBecaDocumentos).HasName("PRIMARY");

            entity.HasIndex(e => e.requisitoAdjunto, "fk_bien_postulacion_becas_documentos_adjuntos_imagenes1_idx");

            entity.HasIndex(e => e.idParametroRequisitoBeca, "fk_bien_postulacion_becas_documentos_bien_parametro_requisi_idx");

            entity.HasIndex(e => e.idPostulacionesBecas, "fk_bien_postulacion_becas_documentos_bien_postulaciones_bec_idx");

            entity.HasIndex(e => e.idUsuarioBienestar, "fk_bien_postulacion_becas_documentos_usuarios1_idx");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.estadoDocumento).HasColumnType("enum('pendiente','aprobado','rechazado')");
            entity.Property(e => e.fechaRegistro)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fechaValidacionBienestar).HasColumnType("datetime");
            entity.Property(e => e.observacionBienestar).HasMaxLength(150);

            entity.HasOne(d => d.idParametroRequisitoBecaNavigation).WithMany(p => p.bien_postulacion_requisitos_becas)
                .HasForeignKey(d => d.idParametroRequisitoBeca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_postulacion_becas_documentos_bien_parametro_requisito1");

            entity.HasOne(d => d.idPostulacionesBecasNavigation).WithMany(p => p.bien_postulacion_requisitos_becas)
                .HasForeignKey(d => d.idPostulacionesBecas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_postulacion_becas_documentos_bien_postulaciones_bec1");

            entity.HasOne(d => d.idUsuarioBienestarNavigation).WithMany(p => p.bien_postulacion_requisitos_becas)
                .HasForeignKey(d => d.idUsuarioBienestar)
                .HasConstraintName("fk_bien_postulacion_becas_documentos_usuarios1");

            entity.HasOne(d => d.requisitoAdjuntoNavigation).WithMany(p => p.bien_postulacion_requisitos_becas)
                .HasForeignKey(d => d.requisitoAdjunto)
                .HasConstraintName("fk_bien_postulacion_becas_documentos_adjuntos_imagenes1");
        });

        modelBuilder.Entity<bien_postulaciones_becas>(entity =>
        {
            entity.HasKey(e => e.idPostulacionesBecas).HasName("PRIMARY");

            entity.HasIndex(e => e.idConvocatoriasBecas, "fk_bien_postulaciones_becas_bien_convocatorias_becas1_idx");

            entity.HasIndex(e => e.idMotivosBeca, "fk_bien_postulaciones_becas_bien_motivos_beca1_idx");

            entity.HasIndex(e => e.idMatricula, "fk_bien_postulaciones_becas_matriculas1_idx");

            entity.HasIndex(e => e.idUsuarioBienestar, "fk_bien_postulaciones_becas_usuarios1_idx");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.estadoBienestar).HasColumnType("enum('pendiente','en_revision','aprobada','rechazada','desistida')");
            entity.Property(e => e.fechaActualizado)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.fechaRegistro).HasColumnType("date");
            entity.Property(e => e.fechaValidacionBienestar).HasColumnType("datetime");
            entity.Property(e => e.observacionBienestar).HasColumnType("text");

            entity.HasOne(d => d.idConvocatoriasBecasNavigation).WithMany(p => p.bien_postulaciones_becas)
                .HasForeignKey(d => d.idConvocatoriasBecas)
                .HasConstraintName("fk_bien_postulaciones_becas_bien_convocatorias_becas1");

            entity.HasOne(d => d.idMatriculaNavigation).WithMany(p => p.bien_postulaciones_becas)
                .HasForeignKey(d => d.idMatricula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_postulaciones_becas_matriculas1");

            entity.HasOne(d => d.idMotivosBecaNavigation).WithMany(p => p.bien_postulaciones_becas)
                .HasForeignKey(d => d.idMotivosBeca)
                .HasConstraintName("fk_bien_postulaciones_becas_motivobeca");

            entity.HasOne(d => d.idUsuarioBienestarNavigation).WithMany(p => p.bien_postulaciones_becas)
                .HasForeignKey(d => d.idUsuarioBienestar)
                .HasConstraintName("fk_bien_postulaciones_becas_usuarioBienestar");
        });

        modelBuilder.Entity<bien_requisitos_beca>(entity =>
        {
            entity.HasKey(e => e.idRequistosBeca).HasName("PRIMARY");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.requisito).HasMaxLength(250);
            entity.Property(e => e.tipoRequisito).HasColumnType("enum('adjunto','bool')");
        });

        modelBuilder.Entity<bien_resoluciones_tribunales>(entity =>
        {
            entity.HasKey(e => e.idResolucionesTribunales).HasName("PRIMARY");

            entity.HasIndex(e => e.idPostulacionesBecas, "fk_bien_resoluciones_tribunales_bien_postulaciones_becas1_idx");

            entity.HasIndex(e => e.idPeriodo, "fk_bien_resoluciones_tribunales_periodos1_idx");

            entity.HasIndex(e => e.idUsuarioRegistra, "fk_bien_resoluciones_tribunales_usuarios1_idx");

            entity.HasIndex(e => new { e.idPostulacionesBecas, e.resolucion, e.idPeriodo }, "index5").IsUnique();

            entity.Property(e => e.fechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.observacion).HasColumnType("text");
            entity.Property(e => e.porcentajeFinal).HasPrecision(10);
            entity.Property(e => e.resolucion).HasColumnType("enum('aprobada','anulada','rechazada','votacion')");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.bien_resoluciones_tribunales)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_resoluciones_tribunales_periodos1");

            entity.HasOne(d => d.idPostulacionesBecasNavigation).WithMany(p => p.bien_resoluciones_tribunales)
                .HasForeignKey(d => d.idPostulacionesBecas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_resoluciones_tribunales_postulaciones");

            entity.HasOne(d => d.idUsuarioRegistraNavigation).WithMany(p => p.bien_resoluciones_tribunales)
                .HasForeignKey(d => d.idUsuarioRegistra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_resoluciones_tribunales_usuarioRegisra");
        });

        modelBuilder.Entity<bien_servicios_fichas>(entity =>
        {
            entity.HasKey(e => e.idServicioFicha).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoServicio, "fk_detalle_servicio_vivienda_bien_detalle_servicios1_idx");

            entity.HasIndex(e => e.idFichaSocioEconomica, "fk_detalle_servicio_vivienda_bien_ficha_socioeconomica1_idx");

            entity.Property(e => e.tieneServicio).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idFichaSocioEconomicaNavigation).WithMany(p => p.bien_servicios_fichas)
                .HasForeignKey(d => d.idFichaSocioEconomica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_detalle_servicio_vivienda_bien_ficha_socioeconomica1");

            entity.HasOne(d => d.idTipoServicioNavigation).WithMany(p => p.bien_servicios_fichas)
                .HasForeignKey(d => d.idTipoServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_detalle_servicio_vivienda_bien_detalle_servicios1");
        });

        modelBuilder.Entity<bien_tipo_apoyo_financiero>(entity =>
        {
            entity.HasKey(e => e.idTipoApoyoFinanciero).HasName("PRIMARY");

            entity.HasIndex(e => e.idBienApoyo, "fk_bien_tipo_apoyo_financiero_bien_apoyo1_idx");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.nombreApoyo).HasMaxLength(100);

            entity.HasOne(d => d.idBienApoyoNavigation).WithMany(p => p.bien_tipo_apoyo_financiero)
                .HasForeignKey(d => d.idBienApoyo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_tipo_apoyo_financiero_bien_apoyo1");
        });

        modelBuilder.Entity<bien_tipo_cargo_tribunal>(entity =>
        {
            entity.HasKey(e => e.idTipoCargoTribunal).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(50);
        });

        modelBuilder.Entity<bien_tipo_convocatoria>(entity =>
        {
            entity.HasKey(e => e.idTipoConvocatoria).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(255);
            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<bien_tipo_servicios>(entity =>
        {
            entity.HasKey(e => e.idTipoServicio).HasName("PRIMARY");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.nombre).HasMaxLength(30);
        });

        modelBuilder.Entity<bien_tipo_vivienda>(entity =>
        {
            entity.HasKey(e => e.idTipoVivienda).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(45);
        });

        modelBuilder.Entity<bien_tribunal>(entity =>
        {
            entity.HasKey(e => e.idUsuario).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoCargoTribunal, "fk_bien_tribunal_tipocargo1_idx");

            entity.HasIndex(e => e.idUsuario, "fk_bien_tribunal_usuarios1_idx");

            entity.HasIndex(e => e.esActivo, "index4").IsUnique();

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.fechaCreacion).HasColumnType("datetime");

            entity.HasOne(d => d.idTipoCargoTribunalNavigation).WithMany(p => p.bien_tribunal)
                .HasForeignKey(d => d.idTipoCargoTribunal)
                .HasConstraintName("fk_bien_tribunal_tipocargo1");

            entity.HasOne(d => d.idUsuarioNavigation).WithOne(p => p.bien_tribunal)
                .HasForeignKey<bien_tribunal>(d => d.idUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_tribunal_usuarios1");
        });

        modelBuilder.Entity<bien_votos_tribunales>(entity =>
        {
            entity.HasKey(e => e.idVotosTribunales).HasName("PRIMARY");

            entity.HasIndex(e => e.idResolucionesTribunales, "fk_bien_votos_tribunales_bien_resoluciones_tribunales1_idx");

            entity.HasIndex(e => e.idCargoOcupado, "fk_bien_votos_tribunales_bien_tipo_cargo_tribunal1");

            entity.HasIndex(e => e.idUsuarioTribunal, "fk_bien_votos_tribunales_bien_tribunal1_idx");

            entity.HasIndex(e => e.idResolucionesTribunales, "index4").IsUnique();

            entity.Property(e => e.estado).HasColumnType("enum('aprobado','pendiente','rechazado')");
            entity.Property(e => e.fechaCreacion)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.observaciones).HasMaxLength(255);

            entity.HasOne(d => d.idCargoOcupadoNavigation).WithMany(p => p.bien_votos_tribunales)
                .HasForeignKey(d => d.idCargoOcupado)
                .HasConstraintName("fk_bien_votos_tribunales_bien_tipo_cargo_tribunal1");

            entity.HasOne(d => d.idResolucionesTribunalesNavigation).WithOne(p => p.bien_votos_tribunales)
                .HasForeignKey<bien_votos_tribunales>(d => d.idResolucionesTribunales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_votos_tribunales_bien_resoluciones_tribunales1");

            entity.HasOne(d => d.idUsuarioTribunalNavigation).WithMany(p => p.bien_votos_tribunales)
                .HasForeignKey(d => d.idUsuarioTribunal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bien_votos_tribunales_bien_tribunal1");
        });

        modelBuilder.Entity<calificaciones>(entity =>
        {
            entity.HasKey(e => new { e.idAsignatura, e.idMatricula }).HasName("PRIMARY");

            entity.HasIndex(e => e.idMatricula, "R_30");

            entity.Property(e => e.aprobado).HasDefaultValueSql("'0'");
            entity.Property(e => e.codigoSolicitud).HasMaxLength(20);
            entity.Property(e => e.ef1)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ef2)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ep1)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.ep2)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.examen)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.faltasi1).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasi2).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasi3).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasi4).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasj1).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasj2).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasj3).HasDefaultValueSql("'0'");
            entity.Property(e => e.faltasj4).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaMaximaRemedial).HasColumnType("date");
            entity.Property(e => e.horas_asistidas).HasDefaultValueSql("'0'");
            entity.Property(e => e.nota1)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota2)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota3)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota4)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota5)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.nota_final)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.paralelo).HasMaxLength(10);
            entity.Property(e => e.pierde_faltas).HasDefaultValueSql("'0'");
            entity.Property(e => e.promedio_final)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.promedio_parcial)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.remedial).HasDefaultValueSql("'0'");
            entity.Property(e => e.remedial_final)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.remedial_parcial)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.tipo).HasMaxLength(4);

            entity.HasOne(d => d.idAsignaturaNavigation).WithMany(p => p.calificaciones)
                .HasForeignKey(d => d.idAsignatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("calificaciones_ibfk_1");

            entity.HasOne(d => d.idMatriculaNavigation).WithMany(p => p.calificaciones)
                .HasForeignKey(d => d.idMatricula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("calificaciones_ibfk_2");
        });

        modelBuilder.Entity<calificaciones_complementos_formacion>(entity =>
        {
            entity.HasKey(e => new { e.idAlumno, e.idComplemento, e.idAsignatura }).HasName("PRIMARY");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.aprobado).HasDefaultValueSql("'0'");
            entity.Property(e => e.notaFinal)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<calificaciones_conduccion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.aprobado).HasDefaultValueSql("'0'");
            entity.Property(e => e.observacion).HasMaxLength(200);
        });

        modelBuilder.Entity<calificaciones_grado>(entity =>
        {
            entity.HasKey(e => new { e.idMatricula, e.idAsignatura }).HasName("PRIMARY");

            entity.Property(e => e.aprobado).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha_evaluacion).HasColumnType("date");
            entity.Property(e => e.nota)
                .HasPrecision(4)
                .HasDefaultValueSql("'0.00'");
        });

        modelBuilder.Entity<calificaciones_propedeutico>(entity =>
        {
            entity.HasKey(e => new { e.idAlumno, e.idAsignatura, e.idPeriodo }).HasName("PRIMARY");

            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.aprobado).HasDefaultValueSql("'0'");
            entity.Property(e => e.nota1).HasPrecision(10);
            entity.Property(e => e.observacion).HasMaxLength(50);
        });

        modelBuilder.Entity<cambiosmalla>(entity =>
        {
            entity.HasKey(e => e.idCambioMalla).HasName("PRIMARY");

            entity.HasIndex(e => e.idMalla, "R_16");

            entity.Property(e => e.Cambio).HasMaxLength(100);
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.idMallaNavigation).WithMany(p => p.cambiosmalla)
                .HasForeignKey(d => d.idMalla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cambiosmalla_ibfk_1");
        });

        modelBuilder.Entity<campo_amplio_unesco>(entity =>
        {
            entity.HasKey(e => e.idCampoAmplioUnesco).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigoAmplio).HasMaxLength(10);
            entity.Property(e => e.nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<campo_detallado_unesco>(entity =>
        {
            entity.HasKey(e => e.idCampoDetalladoUnesco).HasName("PRIMARY");

            entity.HasIndex(e => e.idCampospecificoUnesco, "idCampospecificoUnesco");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigoDetallado).HasMaxLength(10);
            entity.Property(e => e.nombreDetallado).HasMaxLength(100);

            entity.HasOne(d => d.idCampospecificoUnescoNavigation).WithMany(p => p.campo_detallado_unesco)
                .HasForeignKey(d => d.idCampospecificoUnesco)
                .HasConstraintName("campo_detallado_unesco_ibfk_1");
        });

        modelBuilder.Entity<campo_especifico_unesco>(entity =>
        {
            entity.HasKey(e => e.idCampospecificoUnesco).HasName("PRIMARY");

            entity.HasIndex(e => e.idCampoAmplioUnesco, "idCampoAmplioUnesco");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigoEspecifico).HasMaxLength(10);
            entity.Property(e => e.nombreEspecifico).HasMaxLength(100);

            entity.HasOne(d => d.idCampoAmplioUnescoNavigation).WithMany(p => p.campo_especifico_unesco)
                .HasForeignKey(d => d.idCampoAmplioUnesco)
                .HasConstraintName("campo_especifico_unesco_ibfk_1");
        });

        modelBuilder.Entity<cargo_instituto>(entity =>
        {
            entity.HasKey(e => e.idCargoInstituto).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoFuncionario, "fk_cargo_instituto_tipo_funcionario1_idx");

            entity.Property(e => e.nombre).HasMaxLength(90);

            entity.HasOne(d => d.idTipoFuncionarioNavigation).WithMany(p => p.cargo_instituto)
                .HasForeignKey(d => d.idTipoFuncionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cargo_instituto_tipo_funcionario1");
        });

        modelBuilder.Entity<cargos_ofertas>(entity =>
        {
            entity.HasKey(e => e.idcargos_ofertas).HasName("PRIMARY");

            entity.Property(e => e.nombre_cargo).HasMaxLength(100);
        });

        modelBuilder.Entity<carreras>(entity =>
        {
            entity.HasKey(e => e.idCarrera).HasName("PRIMARY");

            entity.Property(e => e.Carrera).HasMaxLength(100);
            entity.Property(e => e.aliasCarrera).HasMaxLength(5);
            entity.Property(e => e.codigo_cases).HasMaxLength(20);
            entity.Property(e => e.directorCarrera).HasMaxLength(100);
            entity.Property(e => e.esInstituto).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaCreacion).HasColumnType("date");
            entity.Property(e => e.ordenCarrera).HasDefaultValueSql("'0'");
            entity.Property(e => e.revisaArrastres).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<carreras_adjuntos>(entity =>
        {
            entity.HasKey(e => e.idCarrerasAdjuntos).HasName("PRIMARY");

            entity.HasIndex(e => e.idAdjuntos_Imagenes, "idAdjuntos_Imagenes");

            entity.HasIndex(e => e.idCarrera, "idCarrera");

            entity.HasOne(d => d.idAdjuntos_ImagenesNavigation).WithMany(p => p.carreras_adjuntos)
                .HasForeignKey(d => d.idAdjuntos_Imagenes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("carreras_adjuntos_ibfk_2");

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.carreras_adjuntos)
                .HasForeignKey(d => d.idCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("carreras_adjuntos_ibfk_1");
        });

        modelBuilder.Entity<categoria_contratos>(entity =>
        {
            entity.HasKey(e => e.idCategoriaContratos).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(90);
        });

        modelBuilder.Entity<categoria_vehiculos>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasName("PRIMARY");

            entity.Property(e => e.categoria).HasMaxLength(100);
        });

        modelBuilder.Entity<categorias_actividades>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.categoria).HasMaxLength(100);
            entity.Property(e => e.esDocencia).HasDefaultValueSql("'0'");
            entity.Property(e => e.porcentaje).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<categorias_examenes_conduccion>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.categoria).HasMaxLength(100);
            entity.Property(e => e.tieneNota).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<categorias_terminos_condiciones>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.categoria).HasMaxLength(50);
            entity.Property(e => e.esAdministrativo).HasDefaultValueSql("'0'");
            entity.Property(e => e.esAlumno).HasDefaultValueSql("'0'");
            entity.Property(e => e.esDocente).HasDefaultValueSql("'0'");
            entity.Property(e => e.esExterno).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaRegistro).HasColumnType("date");
        });

        modelBuilder.Entity<categoriassolicitudes>(entity =>
        {
            entity.HasKey(e => e.idCategoriaSolicitud).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.categoria).HasMaxLength(100);
        });

        modelBuilder.Entity<certificados_experiencia_laboral>(entity =>
        {
            entity.HasKey(e => e.idcertificados_experiencia_laboral).HasName("PRIMARY");

            entity.HasIndex(e => e.idProfesor, "fk_certificados_experiencia_laboral_profesores1_idx");

            entity.Property(e => e.esActivo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fecha_emision)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.ruta).HasMaxLength(500);

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.certificados_experiencia_laboral)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_certificados_experiencia_laboral_profesores1");
        });

        modelBuilder.Entity<cierres_colectivos>(entity =>
        {
            entity.HasKey(e => e.id_cierre).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Configuración de descansos y vacaciones obligatorias masivas institucionales"));

            entity.HasIndex(e => e.registrado_por_id, "fk_cierres_colectivos_usuarios");

            entity.Property(e => e.dias_descuento)
                .HasPrecision(4)
                .HasDefaultValueSql("'12.00'")
                .HasComment("Cantidad de días a descontar del ledger (ej. 12 días)");
            entity.Property(e => e.fecha_creacion)
                .HasComment("Fecha de registro de la configuración")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_fin)
                .HasComment("Fecha de fin del descanso colectivo")
                .HasColumnType("date");
            entity.Property(e => e.fecha_inicio)
                .HasComment("Fecha de inicio del descanso colectivo")
                .HasColumnType("date");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .HasComment("Nombre del cierre colectivo (ej. Cierre Fin de Año 2025)");
            entity.Property(e => e.registrado_por_id).HasComment("Usuario de RRHH que lo configura (Llave foránea a usuarios)");

            entity.HasOne(d => d.registrado_por).WithMany(p => p.cierres_colectivos)
                .HasForeignKey(d => d.registrado_por_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cierres_colectivos_usuarios");
        });

        modelBuilder.Entity<cierres_colectivos_exclusiones>(entity =>
        {
            entity.HasKey(e => e.id_exclusion).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Registro de personal exceptuado de los descuentos de cierres institucionales"));

            entity.HasIndex(e => e.id_profesor, "fk_exclusiones_profesores");

            entity.HasIndex(e => new { e.id_cierre, e.id_profesor }, "uk_cierre_profesor").IsUnique();

            entity.Property(e => e.id_cierre).HasComment("Cierre colectivo del que se le excluye");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Profesor exento (ej. personal de contabilidad que trabaja)");

            entity.HasOne(d => d.id_cierreNavigation).WithMany(p => p.cierres_colectivos_exclusiones)
                .HasForeignKey(d => d.id_cierre)
                .HasConstraintName("fk_exclusiones_cierres");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.cierres_colectivos_exclusiones)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_exclusiones_profesores");
        });

        modelBuilder.Entity<ciudades>(entity =>
        {
            entity.HasKey(e => e.idciudades).HasName("PRIMARY");

            entity.HasIndex(e => e.idprovincias, "fk_cuidades_provincias1_idx");

            entity.Property(e => e.nombre).HasMaxLength(100);

            entity.HasOne(d => d.idprovinciasNavigation).WithMany(p => p.ciudades)
                .HasForeignKey(d => d.idprovincias)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cuidades_provincias1");
        });

        modelBuilder.Entity<clausulas>(entity =>
        {
            entity.HasKey(e => e.idClausulas).HasName("PRIMARY");

            entity.Property(e => e.nombre_clausula).HasMaxLength(150);
        });

        modelBuilder.Entity<cliente_factura>(entity =>
        {
            entity.HasKey(e => e.documentoFactura).HasName("PRIMARY");

            entity.Property(e => e.documentoFactura).HasMaxLength(14);
            entity.Property(e => e.direccion).HasMaxLength(100);
            entity.Property(e => e.email).HasMaxLength(60);
            entity.Property(e => e.fechaCreacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.nombre).HasMaxLength(100);
            entity.Property(e => e.telefono).HasMaxLength(10);
            entity.Property(e => e.tipoDocumento).HasMaxLength(1);
        });

        modelBuilder.Entity<complementos_formacion>(entity =>
        {
            entity.HasKey(e => e.idComplemento).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.complemento).HasMaxLength(60);
        });

        modelBuilder.Entity<cond_alumnos_horarios>(entity =>
        {
            entity.HasKey(e => e.idAsignacionHorario).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.asiste).HasDefaultValueSql("'0'");
            entity.Property(e => e.observacion).HasMaxLength(100);
        });

        modelBuilder.Entity<cond_alumnos_practicas>(entity =>
        {
            entity.HasKey(e => e.idPractica).HasName("PRIMARY");

            entity.Property(e => e.cancelado).HasDefaultValueSql("'0'");
            entity.Property(e => e.dia).HasMaxLength(15);
            entity.Property(e => e.ensalida).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha).HasColumnType("date");
            entity.Property(e => e.hora_llegada).HasColumnType("time");
            entity.Property(e => e.hora_salida).HasColumnType("time");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.idalumno).HasMaxLength(14);
            entity.Property(e => e.observaciones).HasColumnType("text");
            entity.Property(e => e.tiempo).HasColumnType("time");
            entity.Property(e => e.user_asigna).HasMaxLength(20);
            entity.Property(e => e.user_llegada).HasMaxLength(20);
            entity.Property(e => e.verificada).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<cond_alumnos_vehiculos>(entity =>
        {
            entity.HasKey(e => e.idAsignacion).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaAsignacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fechaFin).HasColumnType("date");
            entity.Property(e => e.fechaInicio).HasColumnType("date");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.observacion).HasMaxLength(200);
        });

        modelBuilder.Entity<cond_practicas_horarios_alumnos>(entity =>
        {
            entity.HasKey(e => new { e.idPractica, e.idAsignacionHorario }).HasName("PRIMARY");
        });

        modelBuilder.Entity<configsharepoint>(entity =>
        {
            entity.HasKey(e => e.idSharePoint).HasName("PRIMARY");

            entity.Property(e => e.AppID).HasMaxLength(255);
            entity.Property(e => e.ClientID).HasMaxLength(225);
            entity.Property(e => e.ClientSecret).HasMaxLength(255);
            entity.Property(e => e.DriveID).HasMaxLength(255);
            entity.Property(e => e.FechaActualizado).HasColumnType("date");
            entity.Property(e => e.FechaCreado).HasColumnType("date");
            entity.Property(e => e.ListID).HasMaxLength(255);
            entity.Property(e => e.RedirectURL).HasMaxLength(255);
            entity.Property(e => e.SiteID).HasMaxLength(255);
            entity.Property(e => e.SiteName).HasMaxLength(100);
            entity.Property(e => e.TenanID).HasMaxLength(255);
            entity.Property(e => e.TenantName).HasMaxLength(100);
            entity.Property(e => e.correo).HasMaxLength(255);
            entity.Property(e => e.password).HasMaxLength(255);
        });

        modelBuilder.Entity<configuracion_vacaciones>(entity =>
        {
            entity.HasKey(e => e.id_config).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Configuración de reglas generales de vacaciones (días por ley, límites)"));

            entity.HasIndex(e => e.clave, "uk_clave").IsUnique();

            entity.Property(e => e.clave)
                .HasMaxLength(50)
                .HasComment("Identificador único del parámetro");
            entity.Property(e => e.descripcion)
                .HasMaxLength(255)
                .HasComment("Notas del parámetro");
            entity.Property(e => e.valor)
                .HasMaxLength(100)
                .HasComment("Valor del parámetro");
        });

        modelBuilder.Entity<contratos>(entity =>
        {
            entity.HasKey(e => e.idContratos).HasName("PRIMARY");

            entity.HasIndex(e => e.idCargoInstituto, "fk_contratos_cargo_instituto1_idx");

            entity.HasIndex(e => e.idDedicacionCategorias, "fk_contratos_dedicacion_categorias1_idx");

            entity.HasIndex(e => e.iddepartamentos, "fk_contratos_departamentos1_idx");

            entity.HasIndex(e => e.idInstitucionesInstituto, "fk_contratos_instituciones_instituto1_idx");

            entity.HasIndex(e => e.idProfesor, "fk_contratos_profesores1_idx");

            entity.HasIndex(e => e.idRelacionIes, "fk_contratos_relacion_ies1_idx");

            entity.HasIndex(e => e.idTiposContratos, "fk_contratos_tipos_contratos1_idx");

            entity.HasIndex(e => e.usuario_creo, "fk_contratos_usuarios1_idx");

            entity.HasIndex(e => e.usuarios_modifico, "fk_contratos_usuarios2_idx");

            entity.Property(e => e.archivoContrato).HasColumnType("text");
            entity.Property(e => e.archivoFiniquito).HasMaxLength(900);
            entity.Property(e => e.archivoLegalizado).HasMaxLength(900);
            entity.Property(e => e.archivoLegalizadoSalida).HasMaxLength(900);
            entity.Property(e => e.contratoVinculado).HasMaxLength(255);
            entity.Property(e => e.fecha_final).HasColumnType("date");
            entity.Property(e => e.fecha_inicio).HasColumnType("date");
            entity.Property(e => e.fecha_modifico).HasColumnType("date");
            entity.Property(e => e.fecha_registro).HasColumnType("date");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.numeroContrato).HasMaxLength(90);
            entity.Property(e => e.usuario_creo).HasMaxLength(50);
            entity.Property(e => e.usuarios_modifico).HasMaxLength(50);

            entity.HasOne(d => d.idDedicacionCategoriasNavigation).WithMany(p => p.contratos)
                .HasForeignKey(d => d.idDedicacionCategorias)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_dedicacion_categorias1");

            entity.HasOne(d => d.idInstitucionesInstitutoNavigation).WithMany(p => p.contratos)
                .HasForeignKey(d => d.idInstitucionesInstituto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_instituciones_instituto1");

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.contratos)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_profesores1");
        });

        modelBuilder.Entity<contratos_asignaturas>(entity =>
        {
            entity.HasKey(e => e.idContratosAsignaturas).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignacion, "fk_contratos_asignaturas_asignacion1_idx");

            entity.HasIndex(e => e.idAsignatura, "fk_contratos_asignaturas_asignaturas1_idx");

            entity.HasIndex(e => e.idContratos, "fk_contratos_asignaturas_contratos1_idx");

            entity.HasIndex(e => e.idPeriodo, "fk_contratos_asignaturas_periodos1_idx");

            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.paralelo).HasMaxLength(45);
            entity.Property(e => e.valorHora).HasPrecision(10);

            entity.HasOne(d => d.idAsignaturaNavigation).WithMany(p => p.contratos_asignaturas)
                .HasForeignKey(d => d.idAsignatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_asignaturas_asignaturas1");

            entity.HasOne(d => d.idContratosNavigation).WithMany(p => p.contratos_asignaturas)
                .HasForeignKey(d => d.idContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_asignaturas_contratos1");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.contratos_asignaturas)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_asignaturas_periodos1");
        });

        modelBuilder.Entity<contratos_facturas>(entity =>
        {
            entity.HasKey(e => e.idFacturasContratos).HasName("PRIMARY");

            entity.HasIndex(e => e.idContratos, "fk_contratos_facturas_contratos1_idx");

            entity.Property(e => e.numeroFactura).HasMaxLength(500);
            entity.Property(e => e.periodoFactura).HasColumnType("date");
            entity.Property(e => e.valorFacturado).HasPrecision(10);

            entity.HasOne(d => d.idContratosNavigation).WithMany(p => p.contratos_facturas)
                .HasForeignKey(d => d.idContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contratos_facturas_contratos1");
        });

        modelBuilder.Entity<credito_alumno>(entity =>
        {
            entity.HasKey(e => new { e.idMatricula, e.idEspecie }).HasName("PRIMARY");

            entity.HasIndex(e => e.idCredito, "idCredito");

            entity.Property(e => e.beca).HasPrecision(8);
            entity.Property(e => e.credito_inicial).HasPrecision(8);
            entity.Property(e => e.fechaMigracion).HasColumnType("datetime");
            entity.Property(e => e.idCredito).ValueGeneratedOnAdd();
            entity.Property(e => e.idDeudaApi).HasMaxLength(150);
            entity.Property(e => e.migradoContabilidad).HasDefaultValueSql("'0'");
            entity.Property(e => e.saldo).HasPrecision(8);
            entity.Property(e => e.saldo_beca).HasPrecision(8);
            entity.Property(e => e.valor_cuotas).HasPrecision(8);
        });

        modelBuilder.Entity<credito_alumno_detalle>(entity =>
        {
            entity.HasKey(e => e.idCreditoAlumnoDetalle).HasName("PRIMARY");

            entity.HasIndex(e => e.idCredito, "fk_credito_alumno_detalle_credito_idx");

            entity.Property(e => e.cancelado).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha_pago).HasColumnType("date");
            entity.Property(e => e.valorAbonado).HasPrecision(10);
            entity.Property(e => e.valorCuota).HasPrecision(10);
        });

        modelBuilder.Entity<cron_cronograma>(entity =>
        {
            entity.HasKey(e => e.idCronograma).HasName("PRIMARY");

            entity.HasIndex(e => e.idPeriodo, "fk_cron_cronograma_periodos1_idx");

            entity.Property(e => e.detalle).HasMaxLength(90);
            entity.Property(e => e.esActivo)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.cron_cronograma)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cron_cronograma_periodos1");
        });

        modelBuilder.Entity<cron_detalle_cronograma>(entity =>
        {
            entity.HasKey(e => e.idDetalleCronograma).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoProceso, "fk_cron_detalle_cronograma_cron_tipo_proceso1_idx");

            entity.HasIndex(e => e.idCronograma, "fk_dc_cronograma");

            entity.Property(e => e.fechaExtension).HasColumnType("datetime");
            entity.Property(e => e.fechaFin).HasColumnType("datetime");
            entity.Property(e => e.fechaInicio).HasColumnType("datetime");
            entity.Property(e => e.observaciones).HasMaxLength(255);

            entity.HasOne(d => d.idCronogramaNavigation).WithMany(p => p.cron_detalle_cronograma)
                .HasForeignKey(d => d.idCronograma)
                .HasConstraintName("fk_dc_cronograma");

            entity.HasOne(d => d.idTipoProcesoNavigation).WithMany(p => p.cron_detalle_cronograma)
                .HasForeignKey(d => d.idTipoProceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cron_detalle_cronograma_cron_tipo_proceso1");
        });

        modelBuilder.Entity<cron_dias_especiales>(entity =>
        {
            entity.HasKey(e => e.idDiasEspeciales).HasName("PRIMARY");

            entity.HasIndex(e => e.idCronograma, "fk_cron_dias_especiales_cron_cronograma1_idx");

            entity.HasIndex(e => e.idTipoDiaEspecial, "fk_cron_dias_especiales_cron_tipo_dia_especial1_idx");

            entity.Property(e => e.fecha).HasColumnType("datetime");

            entity.HasOne(d => d.idCronogramaNavigation).WithMany(p => p.cron_dias_especiales)
                .HasForeignKey(d => d.idCronograma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cron_dias_especiales_cron_cronograma1");

            entity.HasOne(d => d.idTipoDiaEspecialNavigation).WithMany(p => p.cron_dias_especiales)
                .HasForeignKey(d => d.idTipoDiaEspecial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cron_dias_especiales_cron_tipo_dia_especial1");
        });

        modelBuilder.Entity<cron_tipo_dia_especial>(entity =>
        {
            entity.HasKey(e => e.idTipoDiaEspecial).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(150);
            entity.Property(e => e.fechaOriginal).HasColumnType("date");
        });

        modelBuilder.Entity<cron_tipo_proceso>(entity =>
        {
            entity.HasKey(e => e.idTipoProceso).HasName("PRIMARY");

            entity.Property(e => e.audiencia)
                .HasDefaultValueSql("'profesores'")
                .HasColumnType("enum('alumnos','profesores','todos')");
            entity.Property(e => e.detalle).HasMaxLength(100);
            entity.Property(e => e.esActivo)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.esInformativo).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<cuentas>(entity =>
        {
            entity.HasKey(e => e.idCuenta).HasName("PRIMARY");

            entity.Property(e => e.cuenta).HasMaxLength(100);
            entity.Property(e => e.numero_cuenta).HasMaxLength(20);
            entity.Property(e => e.tipo_pago).HasMaxLength(2);
        });

        modelBuilder.Entity<cursos>(entity =>
        {
            entity.HasKey(e => e.idNivel).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "R_5");

            entity.Property(e => e.Nivel).HasMaxLength(20);
            entity.Property(e => e.aliasCurso).HasMaxLength(5);
            entity.Property(e => e.esRecuperacion).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.cursos)
                .HasForeignKey(d => d.idCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cursos_ibfk_1");
        });

        modelBuilder.Entity<cursos_profesores>(entity =>
        {
            entity.HasKey(e => e.idCursoProfesor).HasName("PRIMARY");

            entity.HasIndex(e => e.idProfesor, "fk_cursos_profesores_profesores1_idx");

            entity.Property(e => e.Institucion).HasMaxLength(200);
            entity.Property(e => e.archivoCurso).HasMaxLength(255);
            entity.Property(e => e.fecha_finalizacion).HasColumnType("date");
            entity.Property(e => e.fecha_inicio).HasColumnType("date");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.nombre_curso).HasMaxLength(255);

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.cursos_profesores)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cursos_profesores_profesores1");
        });

        modelBuilder.Entity<dedicacion>(entity =>
        {
            entity.HasKey(e => e.idDedicacion).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(90);
        });

        modelBuilder.Entity<dedicacion_categorias>(entity =>
        {
            entity.HasKey(e => e.idDedicacionCategorias).HasName("PRIMARY");

            entity.HasIndex(e => e.idDedicacion, "fk_dedicacion_categorias_dedicacion1_idx");

            entity.HasIndex(e => e.idEscalafon, "fk_dedicacion_categorias_escalafon1_idx");

            entity.HasOne(d => d.idDedicacionNavigation).WithMany(p => p.dedicacion_categorias)
                .HasForeignKey(d => d.idDedicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dedicacion_categorias_dedicacion1");

            entity.HasOne(d => d.idEscalafonNavigation).WithMany(p => p.dedicacion_categorias)
                .HasForeignKey(d => d.idEscalafon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dedicacion_categorias_escalafon1");
        });

        modelBuilder.Entity<departamentos>(entity =>
        {
            entity.HasKey(e => e.iddepartamentos).HasName("PRIMARY");

            entity.Property(e => e.abreviacion).HasMaxLength(45);
            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.nombre_departamento).HasMaxLength(90);
        });

        modelBuilder.Entity<departamentossolicitudes>(entity =>
        {
            entity.HasKey(e => e.idDepartamentoSolicitud).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.departamento).HasMaxLength(60);
        });

        modelBuilder.Entity<detalle_pagos>(entity =>
        {
            entity.HasKey(e => new { e.idPago, e.idEspecie }).HasName("PRIMARY");

            entity.HasIndex(e => e.idEspecie, "R_36");

            entity.Property(e => e.descuento).HasPrecision(8);
            entity.Property(e => e.fechaMigracion).HasColumnType("datetime");
            entity.Property(e => e.migradoContabilidad).HasDefaultValueSql("'0'");
            entity.Property(e => e.valor).HasPrecision(8);

            entity.HasOne(d => d.idEspecieNavigation).WithMany(p => p.detalle_pagos)
                .HasForeignKey(d => d.idEspecie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_pagos_ibfk_2");

            entity.HasOne(d => d.idPagoNavigation).WithMany(p => p.detalle_pagos)
                .HasForeignKey(d => d.idPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalle_pagos_ibfk_1");
        });

        modelBuilder.Entity<detalle_sistema_evaluacion>(entity =>
        {
            entity.HasKey(e => new { e.idperiodo, e.idcarrera, e.idsistemaevaluacion }).HasName("PRIMARY");

            entity.Property(e => e.idperiodo).HasMaxLength(7);
        });

        modelBuilder.Entity<detallemallas>(entity =>
        {
            entity.HasKey(e => e.idDetalleMalla).HasName("PRIMARY");

            entity.HasIndex(e => e.idMalla, "R_12");

            entity.HasIndex(e => e.idAsignatura, "R_13");

            entity.HasIndex(e => e.idNivel, "R_17");

            entity.HasIndex(e => e.idtipo_asignatura, "fk_detallemallas_tipos_asignatura1_idx");

            entity.Property(e => e.horasDocente).HasDefaultValueSql("'0'");
            entity.Property(e => e.horasPracticoExperimental)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.tipo).HasMaxLength(100);

            entity.HasOne(d => d.idAsignaturaNavigation).WithMany(p => p.detallemallas)
                .HasForeignKey(d => d.idAsignatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallemallas_ibfk_2");

            entity.HasOne(d => d.idMallaNavigation).WithMany(p => p.detallemallas)
                .HasForeignKey(d => d.idMalla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallemallas_ibfk_1");

            entity.HasOne(d => d.idNivelNavigation).WithMany(p => p.detallemallas)
                .HasForeignKey(d => d.idNivel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detallemallas_ibfk_3");

            entity.HasOne(d => d.idtipo_asignaturaNavigation).WithMany(p => p.detallemallas)
                .HasForeignKey(d => d.idtipo_asignatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_detallemallas_tipos_asignatura1");
        });

        modelBuilder.Entity<detalles_documentos_pagos>(entity =>
        {
            entity.HasKey(e => new { e.iddocumentopago, e.idpago }).HasName("PRIMARY");

            entity.HasIndex(e => e.idpago, "FK_detalles_documentos_pagos_2");

            entity.Property(e => e.valor).HasPrecision(8);

            entity.HasOne(d => d.idpagoNavigation).WithMany(p => p.detalles_documentos_pagos)
                .HasForeignKey(d => d.idpago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalles_documentos_pagos_2");
        });

        modelBuilder.Entity<detalles_ofertas>(entity =>
        {
            entity.HasKey(e => e.iddetalles_ofertas).HasName("PRIMARY");

            entity.HasIndex(e => e.idjornadas_ofertas, "idjornadas_ofertas");

            entity.HasIndex(e => e.idmodalidades_ofertas, "idmodalidades_ofertas");

            entity.HasIndex(e => new { e.idofertas_laborales, e.idjornadas_ofertas, e.idmodalidades_ofertas }, "modalidadofertas").IsUnique();

            entity.HasOne(d => d.idjornadas_ofertasNavigation).WithMany(p => p.detalles_ofertas)
                .HasForeignKey(d => d.idjornadas_ofertas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalles_ofertas_ibfk_1");

            entity.HasOne(d => d.idmodalidades_ofertasNavigation).WithMany(p => p.detalles_ofertas)
                .HasForeignKey(d => d.idmodalidades_ofertas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalles_ofertas_ibfk_2");

            entity.HasOne(d => d.idofertas_laboralesNavigation).WithMany(p => p.detalles_ofertas)
                .HasForeignKey(d => d.idofertas_laborales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalles_ofertas_ibfk_3");
        });

        modelBuilder.Entity<discapacidades>(entity =>
        {
            entity.HasKey(e => e.idDiscapacidad).HasName("PRIMARY");

            entity.Property(e => e.discapacidad).HasMaxLength(30);
            entity.Property(e => e.esDefecto).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<documentos_adjuntos>(entity =>
        {
            entity.HasKey(e => e.iddocumentos_adjuntos).HasName("PRIMARY");

            entity.HasIndex(e => e.idtipos_documentos, "idtipos_documentos");

            entity.Property(e => e.fecha_Subida).HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.nombre_archivo).HasMaxLength(255);
            entity.Property(e => e.ruta_archivo).HasMaxLength(255);

            entity.HasOne(d => d.idtipos_documentosNavigation).WithMany(p => p.documentos_adjuntos)
                .HasForeignKey(d => d.idtipos_documentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("documentos_adjuntos_ibfk_1");
        });

        modelBuilder.Entity<ed_alumnostest>(entity =>
        {
            entity.HasKey(e => e.idIngresoTest).HasName("PRIMARY");

            entity.Property(e => e.culminado).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
        });

        modelBuilder.Entity<ed_encuestas>(entity =>
        {
            entity.HasKey(e => e.idEncuesta).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.descripcion).HasMaxLength(255);
            entity.Property(e => e.nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<ed_fechasevaluacion>(entity =>
        {
            entity.HasKey(e => new { e.idPeriodo, e.idModalidad }).HasName("PRIMARY");

            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.fecha_final).HasColumnType("date");
            entity.Property(e => e.fecha_inicio).HasColumnType("date");
        });

        modelBuilder.Entity<ed_preguntas>(entity =>
        {
            entity.HasKey(e => e.IdPregunta).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.esAbierta).HasDefaultValueSql("'0'");
            entity.Property(e => e.pregunta).HasMaxLength(250);
        });

        modelBuilder.Entity<ed_respuestastest>(entity =>
        {
            entity.HasKey(e => new { e.idIngresoTest, e.idPregunta }).HasName("PRIMARY");

            entity.Property(e => e.aVeces).HasDefaultValueSql("'0'");
            entity.Property(e => e.casiNunca).HasDefaultValueSql("'0'");
            entity.Property(e => e.casiSiempre).HasDefaultValueSql("'0'");
            entity.Property(e => e.siempre).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<ed_respuestastestab>(entity =>
        {
            entity.HasKey(e => new { e.idIngresoTest, e.idPregunta }).HasName("PRIMARY");

            entity.Property(e => e.respuesta).HasMaxLength(100);
        });

        modelBuilder.Entity<empresas>(entity =>
        {
            entity.HasKey(e => e.idempresa).HasName("PRIMARY");

            entity.HasIndex(e => e.idsectores_empresas, "idsectores_empresas");

            entity.Property(e => e.idempresa).HasMaxLength(15);
            entity.Property(e => e.EsActivo).HasDefaultValueSql("'0'");
            entity.Property(e => e.ciudad_empresa).HasMaxLength(100);
            entity.Property(e => e.comentario_verificacion).HasColumnType("text");
            entity.Property(e => e.direccion_empresa).HasMaxLength(100);
            entity.Property(e => e.email_empresa).HasMaxLength(90);
            entity.Property(e => e.estado_verificacion)
                .HasDefaultValueSql("'pendiente'")
                .HasColumnType("enum('pendiente','verificado','rechazado')");
            entity.Property(e => e.fecha_Inscripcion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_verificacion).HasColumnType("date");
            entity.Property(e => e.nombre_empresa).HasMaxLength(255);
            entity.Property(e => e.pais_empresa).HasMaxLength(100);
            entity.Property(e => e.password).HasMaxLength(90);
            entity.Property(e => e.telefono_empresa).HasMaxLength(20);
            entity.Property(e => e.tipoDocumento)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.user_empresa).HasMaxLength(90);

            entity.HasOne(d => d.idsectores_empresasNavigation).WithMany(p => p.empresas)
                .HasForeignKey(d => d.idsectores_empresas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empresas_ibfk_1");
        });

        modelBuilder.Entity<empresas_contactos>(entity =>
        {
            entity.HasKey(e => e.idempresas_contactos).HasName("PRIMARY");

            entity.HasIndex(e => e.idempresa, "idempresa");

            entity.HasIndex(e => e.idtipo_contacto, "idtipo_contacto");

            entity.Property(e => e.fecha_creacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");
            entity.Property(e => e.idempresa).HasMaxLength(15);
            entity.Property(e => e.valor).HasMaxLength(255);

            entity.HasOne(d => d.idempresaNavigation).WithMany(p => p.empresas_contactos)
                .HasForeignKey(d => d.idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empresas_contactos_ibfk_2");

            entity.HasOne(d => d.idtipo_contactoNavigation).WithMany(p => p.empresas_contactos)
                .HasForeignKey(d => d.idtipo_contacto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empresas_contactos_ibfk_1");
        });

        modelBuilder.Entity<escalafon>(entity =>
        {
            entity.HasKey(e => e.idEscalafon).HasName("PRIMARY");

            entity.HasIndex(e => e.idCategoriaContratos, "fk_escalafon_categoria_contratos1_idx");

            entity.Property(e => e.Nombre).HasMaxLength(90);

            entity.HasOne(d => d.idCategoriaContratosNavigation).WithMany(p => p.escalafon)
                .HasForeignKey(d => d.idCategoriaContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_escalafon_categoria_contratos1");
        });

        modelBuilder.Entity<espacios>(entity =>
        {
            entity.HasKey(e => e.idEspacio).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "fk_espacios_carreras1_idx");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigo).HasMaxLength(15);
            entity.Property(e => e.edificio).HasMaxLength(50);
            entity.Property(e => e.imagen_referencia)
                .HasMaxLength(500)
                .HasColumnName("imagen referencia");
            entity.Property(e => e.nombre).HasMaxLength(100);
            entity.Property(e => e.tipo).HasColumnType("enum('aula','laboratorio','taller','virtual','aula interactiva')");

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.espacios)
                .HasForeignKey(d => d.idCarrera)
                .HasConstraintName("fk_espacios_carreras1");
        });

        modelBuilder.Entity<especies>(entity =>
        {
            entity.HasKey(e => e.idEspecie).HasName("PRIMARY");

            entity.Property(e => e.codigo_financiero).HasMaxLength(8);
            entity.Property(e => e.codigo_referencia).HasMaxLength(10);
            entity.Property(e => e.especie).HasMaxLength(100);
            entity.Property(e => e.extraordinaria).HasPrecision(8);
            entity.Property(e => e.idNivel).HasDefaultValueSql("'0'");
            entity.Property(e => e.idperiodo).HasMaxLength(7);
            entity.Property(e => e.sufijo).HasMaxLength(5);
            entity.Property(e => e.valor).HasPrecision(8);
        });

        modelBuilder.Entity<especies_extras>(entity =>
        {
            entity.HasKey(e => new { e.idmatricula, e.idespecie, e.fecha_registro }).HasName("PRIMARY");

            entity.Property(e => e.fecha_registro).HasColumnType("date");
            entity.Property(e => e.fecha_limite_pago).HasColumnType("date");
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.pagado).HasPrecision(8);
            entity.Property(e => e.tipo).HasMaxLength(45);
            entity.Property(e => e.valor).HasPrecision(8);
        });

        modelBuilder.Entity<estadocivil>(entity =>
        {
            entity.HasKey(e => e.idestadoCivil).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(45);
        });

        modelBuilder.Entity<estadossolicitados>(entity =>
        {
            entity.HasKey(e => e.idEstadoSolicitud).HasName("PRIMARY");

            entity.Property(e => e.esAnulada).HasDefaultValueSql("'0'");
            entity.Property(e => e.esEnRevision).HasDefaultValueSql("'0'");
            entity.Property(e => e.esFinalizado).HasDefaultValueSql("'0'");
            entity.Property(e => e.esPendiente).HasDefaultValueSql("'0'");
            entity.Property(e => e.esReasignada).HasDefaultValueSql("'0'");
            entity.Property(e => e.esTerminal).HasDefaultValueSql("'0'");
            entity.Property(e => e.estado).HasMaxLength(30);
            entity.Property(e => e.orden).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<etnias>(entity =>
        {
            entity.HasKey(e => e.idEtnia).HasName("PRIMARY");

            entity.Property(e => e.etnia).HasMaxLength(30);
            entity.Property(e => e.noRegistra).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<experiencias_laborales>(entity =>
        {
            entity.HasKey(e => e.idexperiencias_laborales).HasName("PRIMARY");

            entity.HasIndex(e => e.idAlumno, "idAlumno");

            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.empresa_nombre).HasMaxLength(255);
            entity.Property(e => e.fecha_creacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_fin).HasColumnType("date");
            entity.Property(e => e.fecha_inicio).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.puesto_nombre).HasMaxLength(255);

            entity.HasOne(d => d.idAlumnoNavigation).WithMany(p => p.experiencias_laborales)
                .HasForeignKey(d => d.idAlumno)
                .HasConstraintName("experiencias_laborales_ibfk_1");
        });

        modelBuilder.Entity<extras_contratos>(entity =>
        {
            entity.HasKey(e => e.idExtraContratos).HasName("PRIMARY");

            entity.HasIndex(e => e.idContratos, "fk_extras_contratos_contratos1_idx");

            entity.Property(e => e.fecha_finalizacion).HasColumnType("date");
            entity.Property(e => e.fecha_inicioextra).HasColumnType("date");
            entity.Property(e => e.fecha_registro).HasColumnType("date");
            entity.Property(e => e.motivo).HasMaxLength(100);
            entity.Property(e => e.usuarioRegistra).HasMaxLength(45);
            entity.Property(e => e.valor_extra).HasPrecision(10);

            entity.HasOne(d => d.idContratosNavigation).WithMany(p => p.extras_contratos)
                .HasForeignKey(d => d.idContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_extras_contratos_contratos1");
        });

        modelBuilder.Entity<fechas_grados>(entity =>
        {
            entity.HasKey(e => new { e.idperiodo, e.idnivel, e.idseccion, e.paralelo }).HasName("PRIMARY");

            entity.Property(e => e.idperiodo).HasMaxLength(7);
            entity.Property(e => e.paralelo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.fecha_grado).HasColumnType("date");
        });

        modelBuilder.Entity<fechas_horarios>(entity =>
        {
            entity.HasKey(e => e.idFecha).HasName("PRIMARY");

            entity.HasIndex(e => e.fecha, "ix_fechas_horarios_fecha");

            entity.Property(e => e.dia).HasMaxLength(15);
            entity.Property(e => e.fecha).HasColumnType("date");
            entity.Property(e => e.finsemana).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<fechas_pagos>(entity =>
        {
            entity.HasKey(e => e.idFecha).HasName("PRIMARY");

            entity.Property(e => e.fecha).HasColumnType("date");
        });

        modelBuilder.Entity<fechas_pagos_cuotas>(entity =>
        {
            entity.HasKey(e => e.idFecha).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "fk_fechas_pagos_cuotas_carreras1_idx");

            entity.HasIndex(e => e.idModalidad, "fk_fechas_pagos_cuotas_modalidades1_idx");

            entity.HasIndex(e => e.idPeriodo, "fk_fechas_pagos_cuotas_periodos_idx");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigo_referencia).HasMaxLength(10);
            entity.Property(e => e.fecha).HasColumnType("date");
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.fechas_pagos_cuotas)
                .HasForeignKey(d => d.idCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fechas_pagos_cuotas_carreras1");

            entity.HasOne(d => d.idModalidadNavigation).WithMany(p => p.fechas_pagos_cuotas)
                .HasForeignKey(d => d.idModalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fechas_pagos_cuotas_modalidades1");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.fechas_pagos_cuotas)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fechas_pagos_cuotas_periodos");
        });

        modelBuilder.Entity<fechas_semanas>(entity =>
        {
            entity.HasKey(e => e.idFechasSemanas).HasName("PRIMARY");

            entity.HasIndex(e => e.idFecha, "idFecha");

            entity.HasIndex(e => e.idPeriodo, "idPeriodo");

            entity.HasIndex(e => e.idSemanasHorarios, "idSemanasHorarios");

            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();

            entity.HasOne(d => d.idFechaNavigation).WithMany(p => p.fechas_semanas)
                .HasForeignKey(d => d.idFecha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fechas_semanas_ibfk_1");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.fechas_semanas)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fechas_semanas_ibfk_2");

            entity.HasOne(d => d.idSemanasHorariosNavigation).WithMany(p => p.fechas_semanas)
                .HasForeignKey(d => d.idSemanasHorarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fechas_semanas_ibfk_3");
        });

        modelBuilder.Entity<financiamiento_beca>(entity =>
        {
            entity.HasKey(e => e.idFinanciamiento).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(60);
        });

        modelBuilder.Entity<formaciones_academicas>(entity =>
        {
            entity.HasKey(e => e.idformaciones_academicas).HasName("PRIMARY");

            entity.Property(e => e.Institucion_nombre).HasMaxLength(255);
            entity.Property(e => e.abreviatura)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.area_estudio).HasMaxLength(90);
            entity.Property(e => e.fecha_creacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_fin).HasColumnType("date");
            entity.Property(e => e.fecha_inicio).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.numero_registro).HasMaxLength(45);
            entity.Property(e => e.titulo).HasMaxLength(90);
        });

        modelBuilder.Entity<gest_audit_acciones>(entity =>
        {
            entity.HasKey(e => new { e.idAuditAcciones, e.codigoSistema }).HasName("PRIMARY");

            entity.HasIndex(e => new { e.codigoSistema, e.idModulo }, "ix_audit_acciones_sistema_modulo");

            entity.Property(e => e.idAuditAcciones).HasMaxLength(100);
            entity.Property(e => e.codigoSistema).HasMaxLength(20);
            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<gest_audit_registros>(entity =>
        {
            entity.HasKey(e => e.idAuditRegistros).HasName("PRIMARY");

            entity.HasIndex(e => new { e.accion, e.fechaHora }, "ix_audit_accion_fecha");

            entity.HasIndex(e => new { e.codigoSistema, e.idAuditRegistros }, "ix_audit_codigo_sistema");

            entity.HasIndex(e => new { e.idEntidad, e.tablaAfectada }, "ix_audit_entidad");

            entity.HasIndex(e => e.jti, "ix_audit_jti");

            entity.HasIndex(e => new { e.codigoSistema, e.idModulo, e.fechaHora }, "ix_audit_sistema_modulo_fecha");

            entity.HasIndex(e => new { e.idUsuario, e.codigoSistema, e.fechaHora }, "ix_audit_sistema_usuario_fecha");

            entity.Property(e => e.accion).HasMaxLength(100);
            entity.Property(e => e.codigoSistema).HasMaxLength(20);
            entity.Property(e => e.datosAnteriores).HasColumnType("text");
            entity.Property(e => e.datosNuevos).HasColumnType("text");
            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.fechaHora).HasColumnType("datetime");
            entity.Property(e => e.idModulo).HasMaxLength(50);
            entity.Property(e => e.idUsuario).HasMaxLength(14);
            entity.Property(e => e.ipOrigen).HasMaxLength(45);
            entity.Property(e => e.jti).HasMaxLength(50);
            entity.Property(e => e.mensajeError).HasColumnType("text");
            entity.Property(e => e.requestMethod).HasMaxLength(10);
            entity.Property(e => e.requestPath).HasMaxLength(500);
            entity.Property(e => e.rol).HasMaxLength(30);
            entity.Property(e => e.tablaAfectada).HasMaxLength(100);
            entity.Property(e => e.userAgent).HasMaxLength(500);
        });

        modelBuilder.Entity<gest_password_resets>(entity =>
        {
            entity.HasKey(e => e.idToken).HasName("PRIMARY");

            entity.HasIndex(e => e.idUsuario, "fk_usuario_password_resets_idx");

            entity.Property(e => e.fechaCreacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.fechaExpiracion).HasColumnType("datetime");
            entity.Property(e => e.ipSolicitud).HasMaxLength(50);
            entity.Property(e => e.tokenHash).HasMaxLength(255);

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.gest_password_resets)
                .HasForeignKey(d => d.idUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_password_resets_usuarios1");
        });

        modelBuilder.Entity<grados_academicos>(entity =>
        {
            entity.HasKey(e => e.idGradoAcademico).HasName("PRIMARY");

            entity.HasIndex(e => e.idNivelAcademico, "fk_grados_academicos_niveles_academicos1_idx");

            entity.Property(e => e.nombre).HasMaxLength(45);

            entity.HasOne(d => d.idNivelAcademicoNavigation).WithMany(p => p.grados_academicos)
                .HasForeignKey(d => d.idNivelAcademico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grados_academicos_niveles_academicos1");
        });

        modelBuilder.Entity<habilidades>(entity =>
        {
            entity.HasKey(e => e.idhabilidades).HasName("PRIMARY");

            entity.HasIndex(e => e.nombre, "nombre_UNIQUE").IsUnique();

            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.nombre).HasMaxLength(60);
        });

        modelBuilder.Entity<habilidades_requeridas>(entity =>
        {
            entity.HasKey(e => e.idhabilidades_requeridas).HasName("PRIMARY");

            entity.HasIndex(e => new { e.idofertas_laborales, e.idhabilidades }, "habilidades_ofertas").IsUnique();

            entity.HasIndex(e => e.idhabilidades, "idhabilidades");

            entity.Property(e => e.nivel).HasColumnType("enum('basico','intermedio','avanzado')");

            entity.HasOne(d => d.idhabilidadesNavigation).WithMany(p => p.habilidades_requeridas)
                .HasForeignKey(d => d.idhabilidades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("habilidades_requeridas_ibfk_1");

            entity.HasOne(d => d.idofertas_laboralesNavigation).WithMany(p => p.habilidades_requeridas)
                .HasForeignKey(d => d.idofertas_laborales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("habilidades_requeridas_ibfk_2");
        });

        modelBuilder.Entity<horario_detalle>(entity =>
        {
            entity.HasKey(e => e.idHorario).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignacion, "fk_asignacion_horario_idx");

            entity.HasIndex(e => e.idEspacio, "fk_horario_detalle_espacios1_idx");

            entity.HasIndex(e => e.idFecha, "fk_horario_detalle_fechas_horarios1_idx");

            entity.HasIndex(e => e.idhora, "fk_horario_detalle_horas_clases1_idx");

            entity.HasIndex(e => new { e.idFecha, e.idhora, e.activo }, "ix_horario_detalle_fecha_hora_activo");

            entity.HasIndex(e => new { e.activo, e.idEspacio, e.idAsignacion, e.idFecha, e.idhora }, "uq_docente_horario").IsUnique();

            entity.Property(e => e.esRecuperacionPedagocia).HasDefaultValueSql("'1'");
            entity.Property(e => e.observacion).HasMaxLength(500);
            entity.Property(e => e.tipoBloque).HasColumnType("enum('teorico','practico','taller')");

            entity.HasOne(d => d.idAsignacionNavigation).WithMany(p => p.horario_detalle)
                .HasPrincipalKey(p => p.idAsignacion)
                .HasForeignKey(d => d.idAsignacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asignacion_horario");

            entity.HasOne(d => d.idEspacioNavigation).WithMany(p => p.horario_detalle)
                .HasForeignKey(d => d.idEspacio)
                .HasConstraintName("fk_horario_detalle_espacios1");

            entity.HasOne(d => d.idFechaNavigation).WithMany(p => p.horario_detalle)
                .HasForeignKey(d => d.idFecha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_horario_detalle_fechas_horarios1");

            entity.HasOne(d => d.idhoraNavigation).WithMany(p => p.horario_detalle)
                .HasForeignKey(d => d.idhora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_horario_detalle_horas_clases1");
        });

        modelBuilder.Entity<horario_profesores>(entity =>
        {
            entity.HasKey(e => e.idHorario).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.asiste).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<horas_academicas>(entity =>
        {
            entity.HasKey(e => e.idHorasAcademicas).HasName("PRIMARY");

            entity.HasIndex(e => e.idDedicacion, "fk_horas_academicas_dedicacion1_idx");

            entity.HasOne(d => d.idDedicacionNavigation).WithMany(p => p.horas_academicas)
                .HasForeignKey(d => d.idDedicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_horas_academicas_dedicacion1");
        });

        modelBuilder.Entity<horas_clases>(entity =>
        {
            entity.HasKey(e => e.idhora).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.hora_fin).HasMaxLength(5);
            entity.Property(e => e.hora_inicio).HasMaxLength(5);
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<instituciones>(entity =>
        {
            entity.HasKey(e => e.idInstitucion).HasName("PRIMARY");

            entity.Property(e => e.Institucion).HasMaxLength(200);
            entity.Property(e => e.ciudad).HasMaxLength(100);
            entity.Property(e => e.provincia).HasMaxLength(100);
        });

        modelBuilder.Entity<instituciones_instituto>(entity =>
        {
            entity.HasKey(e => e.idInstitucionesInstituto).HasName("PRIMARY");

            entity.Property(e => e.cedula_representante).HasMaxLength(14);
            entity.Property(e => e.nombre).HasMaxLength(255);
            entity.Property(e => e.representante).HasMaxLength(90);
            entity.Property(e => e.ruc).HasMaxLength(15);
            entity.Property(e => e.ubicado).HasMaxLength(255);
        });

        modelBuilder.Entity<jornadas_ofertas>(entity =>
        {
            entity.HasKey(e => e.idjornadas_ofertas).HasName("PRIMARY");

            entity.Property(e => e.tipo_jornada).HasMaxLength(100);
        });

        modelBuilder.Entity<kardex_vacaciones>(entity =>
        {
            entity.HasKey(e => e.id_kardex).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Transacciones del Kardex contable de vacaciones (Libro Mayor)"));

            entity.HasIndex(e => e.id_profesor, "fk_kardex_vac_profesores");

            entity.HasIndex(e => e.usuario_responsable, "fk_kardex_vac_usuario_resp");

            entity.Property(e => e.cantidad_dias)
                .HasPrecision(5)
                .HasComment("Días afectados: (+) Cargas anuales, (-) Descuentos por consumo o prescripción");
            entity.Property(e => e.detalle)
                .HasMaxLength(255)
                .HasComment("Detalle o justificación contable de la transacción");
            entity.Property(e => e.fecha_transaccion)
                .HasComment("Fecha en que se realiza la transacción")
                .HasColumnType("datetime");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Profesor al que se le afecta el saldo");
            entity.Property(e => e.periodo)
                .HasMaxLength(9)
                .HasComment("Periodo anual correspondiente (ej. 2024-2025)");
            entity.Property(e => e.tipo_transaccion)
                .HasMaxLength(30)
                .HasComment("ASIGNACION_ANUAL, CONSUMO_VACACIONES, AJUSTE_ADMINISTRATIVO, PRESCRIPCION");
            entity.Property(e => e.usuario_responsable).HasComment("Usuario del sistema (TH o RL) que realiza el movimiento");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.kardex_vacaciones)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_kardex_vac_profesores");

            entity.HasOne(d => d.usuario_responsableNavigation).WithMany(p => p.kardex_vacaciones)
                .HasForeignKey(d => d.usuario_responsable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_kardex_vac_usuario_resp");
        });

        modelBuilder.Entity<logsmigraciones>(entity =>
        {
            entity.HasKey(e => e.idLog).HasName("PRIMARY");

            entity.Property(e => e.fecha).HasColumnType("datetime");
            entity.Property(e => e.status).HasMaxLength(1000);
        });

        modelBuilder.Entity<mallas>(entity =>
        {
            entity.HasKey(e => e.idMalla).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "R_15");

            entity.Property(e => e.activa).HasDefaultValueSql("'0'");
            entity.Property(e => e.descripcion).HasMaxLength(100);

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.mallas)
                .HasForeignKey(d => d.idCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mallas_ibfk_1");
        });

        modelBuilder.Entity<mallas_periodos>(entity =>
        {
            entity.HasKey(e => new { e.idPeriodo, e.idNivel, e.idMalla }).HasName("PRIMARY");

            entity.Property(e => e.idPeriodo).HasMaxLength(7);
        });

        modelBuilder.Entity<matriculas>(entity =>
        {
            entity.HasKey(e => e.idMatricula).HasName("PRIMARY");

            entity.HasIndex(e => e.idAlumno, "R_3");

            entity.HasIndex(e => e.idSeccion, "R_4");

            entity.HasIndex(e => e.idNivel, "R_6");

            entity.HasIndex(e => e.idModalidad, "R_7");

            entity.HasIndex(e => e.idPeriodo, "R_8");

            entity.Property(e => e.beca_colegiatura).HasPrecision(5);
            entity.Property(e => e.beca_matricula).HasPrecision(5);
            entity.Property(e => e.carrera_convalidada).HasMaxLength(200);
            entity.Property(e => e.documentoFactura).HasMaxLength(14);
            entity.Property(e => e.esOyente).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaMatricula)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fechaRetiro).HasColumnType("date");
            entity.Property(e => e.idAlumno).HasMaxLength(14);
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.paralelo).HasMaxLength(10);
            entity.Property(e => e.user_matricula).HasMaxLength(20);
            entity.Property(e => e.valida).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idAlumnoNavigation).WithMany(p => p.matriculas)
                .HasForeignKey(d => d.idAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matriculas_ibfk_1");

            entity.HasOne(d => d.idModalidadNavigation).WithMany(p => p.matriculas)
                .HasForeignKey(d => d.idModalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matriculas_ibfk_4");

            entity.HasOne(d => d.idNivelNavigation).WithMany(p => p.matriculas)
                .HasForeignKey(d => d.idNivel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matriculas_ibfk_3");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.matriculas)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matriculas_ibfk_5");

            entity.HasOne(d => d.idSeccionNavigation).WithMany(p => p.matriculas)
                .HasForeignKey(d => d.idSeccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("matriculas_ibfk_2");
        });

        modelBuilder.Entity<matriculas_asistencias>(entity =>
        {
            entity.HasKey(e => new { e.idMatricula, e.idFecha }).HasName("PRIMARY");

            entity.Property(e => e.atraso).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha_actualizacion)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp");
            entity.Property(e => e.fecha_creacion)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp");
            entity.Property(e => e.noAsiste).HasDefaultValueSql("'0'");
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.usuario).HasMaxLength(20);
            entity.Property(e => e.usuario_actualiza).HasMaxLength(20);
        });

        modelBuilder.Entity<matriculas_examen_conduccion>(entity =>
        {
            entity.HasKey(e => new { e.idMatricula, e.idCategoria }).HasName("PRIMARY");

            entity.Property(e => e.fechaExamen).HasColumnType("date");
            entity.Property(e => e.fechaIngreso)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.instructor).HasMaxLength(100);
            entity.Property(e => e.nota).HasDefaultValueSql("'0'");
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.usuario).HasMaxLength(20);
        });

        modelBuilder.Entity<medios_contacto>(entity =>
        {
            entity.HasKey(e => e.idMedio).HasName("PRIMARY");

            entity.Property(e => e.activo)
                .HasDefaultValueSql("b'1'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.medio).HasMaxLength(100);
        });

        modelBuilder.Entity<modalidades>(entity =>
        {
            entity.HasKey(e => e.idModalidad).HasName("PRIMARY");

            entity.Property(e => e.modalidad).HasMaxLength(100);
            entity.Property(e => e.modalidadImpresion).HasMaxLength(30);
            entity.Property(e => e.sufijo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<modalidades_carreras>(entity =>
        {
            entity.HasKey(e => e.idModalidadCarrera).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "fk_ModalidadCarrera_carreras1_idx");

            entity.HasIndex(e => e.idModalidad, "fk_ModalidadCarrera_modalidades1_idx");

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.modalidades_carreras)
                .HasForeignKey(d => d.idCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ModalidadCarrera_carreras1");

            entity.HasOne(d => d.idModalidadNavigation).WithMany(p => p.modalidades_carreras)
                .HasForeignKey(d => d.idModalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ModalidadCarrera_modalidades1");
        });

        modelBuilder.Entity<modalidades_ofertas>(entity =>
        {
            entity.HasKey(e => e.idmodalidades_ofertas).HasName("PRIMARY");

            entity.Property(e => e.tipo_modalidad).HasMaxLength(100);
        });

        modelBuilder.Entity<motivo_salida>(entity =>
        {
            entity.HasKey(e => e.idMotivoSalida).HasName("PRIMARY");

            entity.Property(e => e.nombre_motivo).HasMaxLength(45);
        });

        modelBuilder.Entity<nacionalidades>(entity =>
        {
            entity.HasKey(e => e.idNacionalidad).HasName("PRIMARY");

            entity.Property(e => e.esNinguna).HasDefaultValueSql("'0'");
            entity.Property(e => e.nacionalidad).HasMaxLength(30);
        });

        modelBuilder.Entity<niveles_academicos>(entity =>
        {
            entity.HasKey(e => e.idNivelAcademico).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(60);
        });

        modelBuilder.Entity<ofertas_carreras>(entity =>
        {
            entity.HasKey(e => e.idofertas_carreras).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "idCarrera");

            entity.HasIndex(e => new { e.idofertas_laborales, e.idCarrera }, "ofertas_carreras").IsUnique();

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.ofertas_carreras)
                .HasForeignKey(d => d.idCarrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_carreras_ibfk_2");

            entity.HasOne(d => d.idofertas_laboralesNavigation).WithMany(p => p.ofertas_carreras)
                .HasForeignKey(d => d.idofertas_laborales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_carreras_ibfk_1");
        });

        modelBuilder.Entity<ofertas_laborales>(entity =>
        {
            entity.HasKey(e => e.idofertas_laborales).HasName("PRIMARY");

            entity.HasIndex(e => e.idcargos_ofertas, "idcargos_ofertas");

            entity.HasIndex(e => e.iddepartamentos, "iddepartamentos");

            entity.HasIndex(e => e.idempresa, "idempresa");

            entity.HasIndex(e => e.idtipos_ofertas, "idtipos_ofertas");

            entity.Property(e => e.Ciudad).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.enlace_original).HasColumnType("text");
            entity.Property(e => e.esActivo).HasDefaultValueSql("'0'");
            entity.Property(e => e.estado)
                .HasDefaultValueSql("'activa'")
                .HasColumnType("enum('activa','pausada','cerrada')");
            entity.Property(e => e.experiencia_requerida).HasMaxLength(50);
            entity.Property(e => e.fecha_cierre).HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_publicacion).HasColumnType("timestamp");
            entity.Property(e => e.idempresa).HasMaxLength(15);
            entity.Property(e => e.salario).HasPrecision(10);
            entity.Property(e => e.ubicacion).HasMaxLength(255);

            entity.HasOne(d => d.idcargos_ofertasNavigation).WithMany(p => p.ofertas_laborales)
                .HasForeignKey(d => d.idcargos_ofertas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_laborales_ibfk_4");

            entity.HasOne(d => d.iddepartamentosNavigation).WithMany(p => p.ofertas_laborales)
                .HasForeignKey(d => d.iddepartamentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_laborales_ibfk_1");

            entity.HasOne(d => d.idempresaNavigation).WithMany(p => p.ofertas_laborales)
                .HasForeignKey(d => d.idempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_laborales_ibfk_3");

            entity.HasOne(d => d.idtipos_ofertasNavigation).WithMany(p => p.ofertas_laborales)
                .HasForeignKey(d => d.idtipos_ofertas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_laborales_ibfk_2");
        });

        modelBuilder.Entity<ofertas_requisitos>(entity =>
        {
            entity.HasKey(e => e.idofertas_requisitos).HasName("PRIMARY");

            entity.HasIndex(e => e.idofertas_laborales, "idofertas_laborales");

            entity.Property(e => e.descripcion).HasColumnType("text");

            entity.HasOne(d => d.idofertas_laboralesNavigation).WithMany(p => p.ofertas_requisitos)
                .HasForeignKey(d => d.idofertas_laborales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ofertas_requisitos_ibfk_1");
        });

        modelBuilder.Entity<pagos>(entity =>
        {
            entity.HasKey(e => e.idPago).HasName("PRIMARY");

            entity.Property(e => e.anulado).HasDefaultValueSql("'0'");
            entity.Property(e => e.descuento).HasPrecision(8);
            entity.Property(e => e.documentoFactura).HasMaxLength(14);
            entity.Property(e => e.factura).HasMaxLength(15);
            entity.Property(e => e.fecha)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fecha_anulacion).HasColumnType("date");
            entity.Property(e => e.fecha_deposito).HasColumnType("date");
            entity.Property(e => e.genera_manual).HasDefaultValueSql("'0'");
            entity.Property(e => e.numero_deposito).HasMaxLength(20);
            entity.Property(e => e.numero_excepcion).HasDefaultValueSql("'0'");
            entity.Property(e => e.observacion).HasMaxLength(100);
            entity.Property(e => e.tipo_documento).HasMaxLength(50);
            entity.Property(e => e.user_pago).HasMaxLength(20);
            entity.Property(e => e.valor).HasPrecision(8);
        });

        modelBuilder.Entity<paises>(entity =>
        {
            entity.HasKey(e => e.idpaises).HasName("PRIMARY");

            entity.Property(e => e.nacionalidad).HasMaxLength(100);
            entity.Property(e => e.nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<parametros>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.archivoFirma).HasMaxLength(150);
            entity.Property(e => e.archivoSello).HasMaxLength(150);
            entity.Property(e => e.cadenaConexion).HasMaxLength(200);
            entity.Property(e => e.claveEmailSolicitudes).HasMaxLength(50);
            entity.Property(e => e.codigo_institucion).HasMaxLength(10);
            entity.Property(e => e.emailSolicitudes).HasMaxLength(150);
            entity.Property(e => e.nombreInstitucion).HasMaxLength(150);
            entity.Property(e => e.nombreRector).HasMaxLength(200);
            entity.Property(e => e.permiteActualizacionCompleta).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<parametrostipossolicitudes>(entity =>
        {
            entity.HasKey(e => e.idParametroTipoSolicitud).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoSolicitud, "idTipoSolicitud");

            entity.Property(e => e.activo).HasDefaultValueSql("'0'");
            entity.Property(e => e.asignatura).HasDefaultValueSql("'0'");
            entity.Property(e => e.carrera).HasDefaultValueSql("'0'");
            entity.Property(e => e.detalle).HasDefaultValueSql("'0'");
            entity.Property(e => e.detalleAutogenerado).HasMaxLength(1500);
            entity.Property(e => e.esCalificaciones).HasDefaultValueSql("'0'");
            entity.Property(e => e.esConduccion).HasDefaultValueSql("'0'");
            entity.Property(e => e.esDetalleAutogenerado).HasDefaultValueSql("'0'");
            entity.Property(e => e.esPeriodoApertura).HasDefaultValueSql("'0'");
            entity.Property(e => e.nivel).HasDefaultValueSql("'0'");
            entity.Property(e => e.periodo).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idTipoSolicitudNavigation).WithMany(p => p.parametrostipossolicitudes)
                .HasForeignKey(d => d.idTipoSolicitud)
                .HasConstraintName("parametrostipossolicitudes_ibfk_1");
        });

        modelBuilder.Entity<parciales>(entity =>
        {
            entity.HasKey(e => e.idParcial).HasName("PRIMARY");

            entity.Property(e => e.Parcial).HasMaxLength(40);
            entity.Property(e => e.esExamenFinal).HasDefaultValueSql("'0'");
            entity.Property(e => e.esPrimero).HasDefaultValueSql("'0'");
            entity.Property(e => e.esRemedial).HasDefaultValueSql("'0'");
            entity.Property(e => e.esSegundo).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha_final).HasColumnType("date");
            entity.Property(e => e.fecha_inicio).HasColumnType("date");
        });

        modelBuilder.Entity<parciales_modalidades>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<parciales_modalidades_fechas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaFin).HasColumnType("date");
            entity.Property(e => e.fechaInicio).HasColumnType("date");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
        });

        modelBuilder.Entity<parroquias>(entity =>
        {
            entity.HasKey(e => e.idParroquias).HasName("PRIMARY");

            entity.HasIndex(e => e.idciudades, "fk_parroquias_ciudades1_idx");

            entity.Property(e => e.nombre).HasMaxLength(100);

            entity.HasOne(d => d.idciudadesNavigation).WithMany(p => p.parroquias)
                .HasForeignKey(d => d.idciudades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_parroquias_ciudades1");
        });

        modelBuilder.Entity<pd_aceptaciones_usuarios>(entity =>
        {
            entity.HasKey(e => e.idAceptacionUsuario).HasName("PRIMARY");

            entity.Property(e => e.dispositivo).HasMaxLength(200);
            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.idUsuario).HasMaxLength(14);
            entity.Property(e => e.ipOrigen).HasMaxLength(50);
            entity.Property(e => e.sistema).HasMaxLength(100);
        });

        modelBuilder.Entity<pd_categorias_terminos_condiciones>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.categoria).HasMaxLength(50);
            entity.Property(e => e.esAdministrativo).HasDefaultValueSql("'0'");
            entity.Property(e => e.esAlumno).HasDefaultValueSql("'0'");
            entity.Property(e => e.esDocente).HasDefaultValueSql("'0'");
            entity.Property(e => e.esExterno).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaRegistro).HasColumnType("date");
        });

        modelBuilder.Entity<pd_terminos_condiciones>(entity =>
        {
            entity.HasKey(e => e.idTermino).HasName("PRIMARY");

            entity.Property(e => e.archivoHtml).HasMaxLength(100);
            entity.Property(e => e.contenido).HasColumnType("text");
            entity.Property(e => e.esVigente).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaPublicacion).HasColumnType("date");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.versionTermino).HasMaxLength(20);
        });

        modelBuilder.Entity<periodos>(entity =>
        {
            entity.HasKey(e => e.idPeriodo).HasName("PRIMARY");

            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.detalle).HasMaxLength(100);
            entity.Property(e => e.esConduccion).HasDefaultValueSql("'0'");
            entity.Property(e => e.esInstituto).HasDefaultValueSql("'0'");
            entity.Property(e => e.fecha_final).HasColumnType("date");
            entity.Property(e => e.fecha_inicial).HasColumnType("date");
            entity.Property(e => e.fecha_matrucla_extraordinaria).HasColumnType("date");
            entity.Property(e => e.fecha_maxima_autocierre).HasColumnType("date");
            entity.Property(e => e.ingresoCalificaciones).HasDefaultValueSql("'0'");
            entity.Property(e => e.periodoPlanificacion).HasDefaultValueSql("'0'");
            entity.Property(e => e.periodoactivoinstituto).HasDefaultValueSql("'0'");
            entity.Property(e => e.permiteCalificacionesInstituto).HasDefaultValueSql("'0'");
            entity.Property(e => e.permiteMatricula).HasDefaultValueSql("'0'");
            entity.Property(e => e.visualizaPowerBi).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<periodos_inscripciones>(entity =>
        {
            entity.HasKey(e => e.idPeriodoInscripcion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.conduccion).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaFinal).HasColumnType("date");
            entity.Property(e => e.fechaInicio).HasColumnType("date");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
        });

        modelBuilder.Entity<periodos_matriculas_niveles>(entity =>
        {
            entity.HasKey(e => new { e.idPeriodo, e.idNivel, e.idSeccion }).HasName("PRIMARY");

            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<permisos>(entity =>
        {
            entity.HasKey(e => e.id_permiso).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Registro de permisos y licencias por horas o días con soporte de adjuntos"));

            entity.HasIndex(e => e.id_profesor, "fk_permisos_profesores");

            entity.HasIndex(e => e.id_tipo_permiso, "fk_permisos_tipos_permisos");

            entity.HasIndex(e => e.aprobado_por_id, "fk_permisos_usuarios");

            entity.Property(e => e.aprobado_por_id).HasComment("Usuario de RRHH que aprueba/autoriza el permiso");
            entity.Property(e => e.dias)
                .HasPrecision(4)
                .HasComment("Cantidad de días de la ausencia (si es tipo DIAS)");
            entity.Property(e => e.estado)
                .HasMaxLength(30)
                .HasDefaultValueSql("'PENDIENTE_RECUPERACION'")
                .HasComment("PENDIENTE_RECUPERACION, RECUPERADO, DESCONTADO, JUSTIFICADO");
            entity.Property(e => e.fecha_entrega_justificativo)
                .HasComment("Fecha de carga del archivo justificativo")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_solicitud)
                .HasComment("Fecha de registro")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_suceso)
                .HasComment("Fecha del permiso/evento")
                .HasColumnType("date");
            entity.Property(e => e.horas)
                .HasPrecision(4)
                .HasComment("Cantidad de horas de la ausencia (si es tipo HORAS)");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Empleado que solicita el permiso");
            entity.Property(e => e.id_tipo_permiso).HasComment("Referencia al tipo de permiso configurado");
            entity.Property(e => e.motivo)
                .HasComment("Justificación o descripción detallada")
                .HasColumnType("text");
            entity.Property(e => e.notas_rrhh)
                .HasComment("Notas de RRHH sobre el acuerdo verbal de recuperación o justificación")
                .HasColumnType("text");
            entity.Property(e => e.ruta_justificativo)
                .HasMaxLength(255)
                .HasComment("Ruta de archivo adjunto (Foto o PDF)");

            entity.HasOne(d => d.aprobado_por).WithMany(p => p.permisos)
                .HasForeignKey(d => d.aprobado_por_id)
                .HasConstraintName("fk_permisos_usuarios");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.permisos)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_permisos_profesores");

            entity.HasOne(d => d.id_tipo_permisoNavigation).WithMany(p => p.permisos)
                .HasForeignKey(d => d.id_tipo_permiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_permisos_tipos_permisos");
        });

        modelBuilder.Entity<planificacion_vacaciones>(entity =>
        {
            entity.HasKey(e => e.id_planificacion).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Planificación institucional anual de vacaciones coordinada por TH"));

            entity.HasIndex(e => e.id_profesor, "fk_planificacion_vac_profesores");

            entity.HasIndex(e => e.usuario_autorizo, "fk_planificacion_vac_usuario_autorizo");

            entity.HasIndex(e => e.usuario_creo, "fk_planificacion_vac_usuario_creo");

            entity.Property(e => e.dias_planificados).HasComment("Total de días calendario planificados");
            entity.Property(e => e.estado)
                .HasMaxLength(30)
                .HasDefaultValueSql("'Borrador'")
                .HasComment("Borrador, Presentada, Aprobada, Rechazada");
            entity.Property(e => e.fecha_autorizacion)
                .HasComment("Fecha de autorización")
                .HasColumnType("date");
            entity.Property(e => e.fecha_fin)
                .HasComment("Fecha de fin del periodo planificado")
                .HasColumnType("date");
            entity.Property(e => e.fecha_inicio)
                .HasComment("Fecha de inicio del periodo planificado")
                .HasColumnType("date");
            entity.Property(e => e.fecha_planificacion)
                .HasComment("Fecha de registro")
                .HasColumnType("date");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Empleado planificado");
            entity.Property(e => e.observaciones)
                .HasComment("Observaciones administrativas")
                .HasColumnType("text");
            entity.Property(e => e.periodo)
                .HasMaxLength(9)
                .HasComment("Periodo vacacional de la planificación");
            entity.Property(e => e.usuario_autorizo).HasComment("Representante Legal que autoriza (Llave foránea a usuarios)");
            entity.Property(e => e.usuario_creo).HasComment("Usuario de TH que registra (Llave foránea a usuarios)");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.planificacion_vacaciones)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_planificacion_vac_profesores");

            entity.HasOne(d => d.usuario_autorizoNavigation).WithMany(p => p.planificacion_vacacionesusuario_autorizoNavigation)
                .HasForeignKey(d => d.usuario_autorizo)
                .HasConstraintName("fk_planificacion_vac_usuario_autorizo");

            entity.HasOne(d => d.usuario_creoNavigation).WithMany(p => p.planificacion_vacacionesusuario_creoNavigation)
                .HasForeignKey(d => d.usuario_creo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_planificacion_vac_usuario_creo");
        });

        modelBuilder.Entity<plantilla_clausulas>(entity =>
        {
            entity.HasKey(e => e.idPlantillasClausulas).HasName("PRIMARY");

            entity.HasIndex(e => e.idClausulas, "fk_plantilla_clausulas_clausulas1_idx");

            entity.HasIndex(e => e.idPlantillaContrato, "fk_plantilla_clausulas_plantilla_contrato1_idx");

            entity.Property(e => e.fecha_creacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");
            entity.Property(e => e.texto).HasColumnType("mediumtext");

            entity.HasOne(d => d.idClausulasNavigation).WithMany(p => p.plantilla_clausulas)
                .HasForeignKey(d => d.idClausulas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_clausulas_clausulas1");

            entity.HasOne(d => d.idPlantillaContratoNavigation).WithMany(p => p.plantilla_clausulas)
                .HasForeignKey(d => d.idPlantillaContrato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_clausulas_plantilla_contrato1");
        });

        modelBuilder.Entity<plantilla_contrato>(entity =>
        {
            entity.HasKey(e => e.idPlantillaContrato).HasName("PRIMARY");

            entity.HasIndex(e => e.idSello, "fk_plantilla_contrato_adjuntos_imagenes1_idx");

            entity.HasIndex(e => e.idFondo, "fk_plantilla_contrato_adjuntos_imagenes2_idx");

            entity.HasIndex(e => e.idDedicacion, "fk_plantilla_contrato_dedicacion1_idx");

            entity.HasIndex(e => e.idInstitucionesInstituto, "fk_plantilla_contrato_instituciones_instituto1_idx");

            entity.HasIndex(e => e.idTiposContratos, "fk_plantilla_contrato_tipos_contratos1_idx");

            entity.Property(e => e.cuerpo).HasColumnType("mediumtext");
            entity.Property(e => e.fecha_creacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");
            entity.Property(e => e.titulo).HasMaxLength(255);

            entity.HasOne(d => d.idDedicacionNavigation).WithMany(p => p.plantilla_contrato)
                .HasForeignKey(d => d.idDedicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_contrato_dedicacion1");

            entity.HasOne(d => d.idFondoNavigation).WithMany(p => p.plantilla_contratoidFondoNavigation)
                .HasForeignKey(d => d.idFondo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_contrato_adjuntos_imagenes2");

            entity.HasOne(d => d.idInstitucionesInstitutoNavigation).WithMany(p => p.plantilla_contrato)
                .HasForeignKey(d => d.idInstitucionesInstituto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_contrato_instituciones_instituto1");

            entity.HasOne(d => d.idSelloNavigation).WithMany(p => p.plantilla_contratoidSelloNavigation)
                .HasForeignKey(d => d.idSello)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_contrato_adjuntos_imagenes1");

            entity.HasOne(d => d.idTiposContratosNavigation).WithMany(p => p.plantilla_contrato)
                .HasForeignKey(d => d.idTiposContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plantilla_contrato_tipos_contratos1");
        });

        modelBuilder.Entity<plantillas>(entity =>
        {
            entity.HasKey(e => e.idPlantilla).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.archivo).HasMaxLength(100);
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.nombre).HasMaxLength(200);
            entity.Property(e => e.usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<plantillas_documentos>(entity =>
        {
            entity.HasKey(e => e.id_plantilla).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Plantillas dinámicas para la generación de reportes y actas en Word"));

            entity.HasIndex(e => e.codigo, "uk_codigo_plantilla").IsUnique();

            entity.Property(e => e.activo)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.codigo)
                .HasMaxLength(50)
                .HasComment("Código único de la plantilla (ej. ACTA_VACACIONES)");
            entity.Property(e => e.cuerpo)
                .HasComment("Texto enriquecido con variables {{...}}")
                .HasColumnType("text");
            entity.Property(e => e.fecha_actualizacion).HasColumnType("datetime");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .HasComment("Nombre descriptivo del reporte");
        });

        modelBuilder.Entity<plantillasparametros>(entity =>
        {
            entity.HasKey(e => e.idParametro).HasName("PRIMARY");

            entity.HasIndex(e => e.idPlantilla, "idPlantilla");

            entity.Property(e => e.fontFamily).HasMaxLength(200);
            entity.Property(e => e.fontSize).HasPrecision(10);
            entity.Property(e => e.parametro).HasMaxLength(100);
            entity.Property(e => e.textAlign).HasMaxLength(50);
            entity.Property(e => e.width).HasMaxLength(50);
            entity.Property(e => e.x).HasPrecision(10);
            entity.Property(e => e.y).HasPrecision(10);

            entity.HasOne(d => d.idPlantillaNavigation).WithMany(p => p.plantillasparametros)
                .HasForeignKey(d => d.idPlantilla)
                .HasConstraintName("plantillasparametros_ibfk_1");
        });

        modelBuilder.Entity<postulaciones>(entity =>
        {
            entity.HasKey(e => e.idPostulaciones).HasName("PRIMARY");

            entity.HasIndex(e => e.iddocumentos_adjuntos, "iddocumentos_adjuntos");

            entity.HasIndex(e => e.idofertas_laborales, "idofertas_laborales");

            entity.Property(e => e.estado)
                .HasDefaultValueSql("'Pendiente'")
                .HasColumnType("enum('Pendiente','Revisado','Entrevista','Rechazado','Aceptado')");
            entity.Property(e => e.fecha_creacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion).HasColumnType("timestamp");
            entity.Property(e => e.fecha_postulacion).HasColumnType("timestamp");
            entity.Property(e => e.idAlumno).HasMaxLength(14);

            entity.HasOne(d => d.iddocumentos_adjuntosNavigation).WithMany(p => p.postulaciones)
                .HasForeignKey(d => d.iddocumentos_adjuntos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("postulaciones_ibfk_2");

            entity.HasOne(d => d.idofertas_laboralesNavigation).WithMany(p => p.postulaciones)
                .HasForeignKey(d => d.idofertas_laborales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("postulaciones_ibfk_1");
        });

        modelBuilder.Entity<prerequisitos>(entity =>
        {
            entity.HasKey(e => new { e.idDetalleMalla, e.idAsignatura }).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignatura, "R_34");

            entity.HasOne(d => d.idAsignaturaNavigation).WithMany(p => p.prerequisitos)
                .HasForeignKey(d => d.idAsignatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prerequisitos_ibfk_2");

            entity.HasOne(d => d.idDetalleMallaNavigation).WithMany(p => p.prerequisitos)
                .HasForeignKey(d => d.idDetalleMalla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prerequisitos_ibfk_1");
        });

        modelBuilder.Entity<procesos_usuario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.consultar).HasDefaultValueSql("'0'");
            entity.Property(e => e.eliminar).HasDefaultValueSql("'0'");
            entity.Property(e => e.insertar).HasDefaultValueSql("'0'");
            entity.Property(e => e.modificar).HasDefaultValueSql("'0'");
            entity.Property(e => e.proceso).HasMaxLength(30);
            entity.Property(e => e.usuario).HasMaxLength(20);
        });

        modelBuilder.Entity<profesores>(entity =>
        {
            entity.HasKey(e => e.idProfesor).HasName("PRIMARY");

            entity.HasIndex(e => e.idDiscapacidad, "fk_profesores_discapacidades1_idx");

            entity.HasIndex(e => e.estadoCivil, "fk_profesores_estadoCivil1_idx");

            entity.HasIndex(e => e.idEtnia, "fk_profesores_etnias1_idx");

            entity.HasIndex(e => e.idNacionalidad, "fk_profesores_nacionalidades1_idx");

            entity.HasIndex(e => e.idParroquiaNacimiento, "fk_profesores_parroquias1_idx");

            entity.HasIndex(e => e.idParroquiaResidencia, "fk_profesores_parroquias2_idx");

            entity.HasIndex(e => e.tipoSangre, "fk_profesores_tipoSangre1_idx");

            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.abreviatura).HasMaxLength(5);
            entity.Property(e => e.abreviatura_post).HasMaxLength(5);
            entity.Property(e => e.apellidos).HasMaxLength(60);
            entity.Property(e => e.callePrincipal).HasMaxLength(125);
            entity.Property(e => e.calleSecundaria).HasMaxLength(125);
            entity.Property(e => e.celular).HasMaxLength(20);
            entity.Property(e => e.clave)
                .HasMaxLength(20)
                .HasDefaultValueSql("'321'");
            entity.Property(e => e.codigoPostal).HasMaxLength(20);
            entity.Property(e => e.direccion).HasMaxLength(100);
            entity.Property(e => e.email).HasMaxLength(100);
            entity.Property(e => e.emailInstitucional).HasMaxLength(255);
            entity.Property(e => e.esReal).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaIngresoIess).HasColumnType("date");
            entity.Property(e => e.fecha_ingreso).HasColumnType("date");
            entity.Property(e => e.fecha_nacimiento).HasColumnType("date");
            entity.Property(e => e.fecha_retiro).HasColumnType("date");
            entity.Property(e => e.foto).HasMaxLength(255);
            entity.Property(e => e.nacionalidad).HasMaxLength(40);
            entity.Property(e => e.nombres).HasMaxLength(60);
            entity.Property(e => e.numeroCasa).HasMaxLength(45);
            entity.Property(e => e.numeroConadis).HasMaxLength(45);
            entity.Property(e => e.practicas).HasDefaultValueSql("'0'");
            entity.Property(e => e.primerApellido).HasMaxLength(60);
            entity.Property(e => e.primerNombre).HasMaxLength(60);
            entity.Property(e => e.segundoApellido).HasMaxLength(60);
            entity.Property(e => e.segundoNombre).HasMaxLength(60);
            entity.Property(e => e.sexo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.telefono).HasMaxLength(30);
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'P'")
                .IsFixedLength();
            entity.Property(e => e.tipoSangre).HasMaxLength(5);
            entity.Property(e => e.tipodocumento)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.titulo).HasMaxLength(200);

            entity.HasOne(d => d.estadoCivilNavigation).WithMany(p => p.profesores)
                .HasForeignKey(d => d.estadoCivil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_estadoCivil1");

            entity.HasOne(d => d.idDiscapacidadNavigation).WithMany(p => p.profesores)
                .HasForeignKey(d => d.idDiscapacidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_discapacidades1");

            entity.HasOne(d => d.idEtniaNavigation).WithMany(p => p.profesores)
                .HasForeignKey(d => d.idEtnia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_etnias1");

            entity.HasOne(d => d.idNacionalidadNavigation).WithMany(p => p.profesores)
                .HasForeignKey(d => d.idNacionalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_nacionalidades1");

            entity.HasOne(d => d.idParroquiaNacimientoNavigation).WithMany(p => p.profesoresidParroquiaNacimientoNavigation)
                .HasForeignKey(d => d.idParroquiaNacimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_parroquias1");

            entity.HasOne(d => d.idParroquiaResidenciaNavigation).WithMany(p => p.profesoresidParroquiaResidenciaNavigation)
                .HasForeignKey(d => d.idParroquiaResidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_parroquias2");

            entity.HasOne(d => d.tipoSangreNavigation).WithMany(p => p.profesores)
                .HasForeignKey(d => d.tipoSangre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_tipoSangre1");
        });

        modelBuilder.Entity<profesores_actas_parciales>(entity =>
        {
            entity.HasKey(e => new { e.idAsignacion, e.idParcial }).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.activoAtraso).HasDefaultValueSql("'0'");
            entity.Property(e => e.codigo_impresion).HasMaxLength(10);
            entity.Property(e => e.entrega_acta).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaFin).HasColumnType("date");
            entity.Property(e => e.fechaInicio).HasColumnType("date");
            entity.Property(e => e.fecha_grabar)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fecha_modificacion)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp");
            entity.Property(e => e.ingresa_notas).HasDefaultValueSql("'0'");
            entity.Property(e => e.usuario_graba).HasMaxLength(20);
        });

        modelBuilder.Entity<profesores_actividades>(entity =>
        {
            entity.HasKey(e => new { e.idPeriodo, e.idProfesor, e.idSubcategoria }).HasName("PRIMARY");

            entity.HasIndex(e => e.idSubcategoria, "fk_profesores_actividades_subcategorias_actividades1_idx");

            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.fecha)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.horas_semana).HasDefaultValueSql("'0'");
            entity.Property(e => e.usuario).HasMaxLength(20);

            entity.HasOne(d => d.idSubcategoriaNavigation).WithMany(p => p.profesores_actividades)
                .HasForeignKey(d => d.idSubcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_actividades_subcategorias_actividades1");
        });

        modelBuilder.Entity<profesores_carreras_periodos>(entity =>
        {
            entity.HasKey(e => e.idProfesoresCarrerasPeriodos).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "fk_profesores_carreras_periodos_carreras1_idx");

            entity.HasIndex(e => e.idPeriodo, "fk_profesores_carreras_periodos_periodos1_idx");

            entity.HasIndex(e => e.idProfesor, "fk_profesores_carreras_periodos_profesores1_idx");

            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.sonTodas).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.profesores_carreras_periodos)
                .HasForeignKey(d => d.idCarrera)
                .HasConstraintName("fk_profesores_carreras_periodos_carreras1");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.profesores_carreras_periodos)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_carreras_periodos_periodos1");

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.profesores_carreras_periodos)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_carreras_periodos_profesores1");
        });

        modelBuilder.Entity<profesores_dedicacion>(entity =>
        {
            entity.HasKey(e => e.idProfesoresDedicacion).HasName("PRIMARY");

            entity.HasIndex(e => e.idDedicacionCategorias, "fk_profesores_dedicacion_dedicacion_categorias1_idx");

            entity.HasIndex(e => e.idPeriodo, "fk_profesores_dedicacion_periodos1_idx");

            entity.HasIndex(e => e.idProfesor, "fk_profesores_dedicacion_profesores1_idx");

            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idDedicacionCategoriasNavigation).WithMany(p => p.profesores_dedicacion)
                .HasForeignKey(d => d.idDedicacionCategorias)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_dedicacion_dedicacion_categorias1");

            entity.HasOne(d => d.idPeriodoNavigation).WithMany(p => p.profesores_dedicacion)
                .HasForeignKey(d => d.idPeriodo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_dedicacion_periodos1");

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.profesores_dedicacion)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_dedicacion_profesores1");
        });

        modelBuilder.Entity<profesores_motivo_salida>(entity =>
        {
            entity.HasKey(e => new { e.idProfesor, e.idMotivoSalida }).HasName("PRIMARY");

            entity.HasIndex(e => e.idContratos, "fk_profesores_has_motivo_salida_contratos1_idx");

            entity.HasIndex(e => e.idMotivoSalida, "fk_profesores_has_motivo_salida_motivo_salida1_idx");

            entity.HasIndex(e => e.idProfesor, "fk_profesores_has_motivo_salida_profesores1_idx");

            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.Observacion).HasMaxLength(400);
            entity.Property(e => e.fecha_registro).HasColumnType("date");
            entity.Property(e => e.fecha_salida).HasColumnType("date");
            entity.Property(e => e.ruta_archivo).HasMaxLength(150);

            entity.HasOne(d => d.idContratosNavigation).WithMany(p => p.profesores_motivo_salida)
                .HasForeignKey(d => d.idContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_has_motivo_salida_contratos1");

            entity.HasOne(d => d.idMotivoSalidaNavigation).WithMany(p => p.profesores_motivo_salida)
                .HasForeignKey(d => d.idMotivoSalida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_has_motivo_salida_motivo_salida1");

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.profesores_motivo_salida)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_profesores_has_motivo_salida_profesores1");
        });

        modelBuilder.Entity<provincias>(entity =>
        {
            entity.HasKey(e => e.idprovincias).HasName("PRIMARY");

            entity.HasIndex(e => e.idpaises, "fk_provincias_paises1_idx");

            entity.Property(e => e.nombre).HasMaxLength(100);

            entity.HasOne(d => d.idpaisesNavigation).WithMany(p => p.provincias)
                .HasForeignKey(d => d.idpaises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_provincias_paises1");
        });

        modelBuilder.Entity<rbac_modulos>(entity =>
        {
            entity.HasKey(e => e.idModulos).HasName("PRIMARY");

            entity.HasIndex(e => e.id_sistema, "fk_modulos_sistema1_idx");

            entity.Property(e => e.Nombre).HasMaxLength(255);

            entity.HasOne(d => d.id_sistemaNavigation).WithMany(p => p.rbac_modulos)
                .HasForeignKey(d => d.id_sistema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_modulos_sistema1");
        });

        modelBuilder.Entity<rbac_modulos_operaciones>(entity =>
        {
            entity.HasKey(e => e.idModulosOperaciones).HasName("PRIMARY");

            entity.HasIndex(e => e.idModulos, "fk_modulos_operaciones_modulos1_idx");

            entity.HasIndex(e => e.idOperaciones, "fk_modulos_operaciones_operaciones1_idx");

            entity.Property(e => e.fecha_creacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");

            entity.HasOne(d => d.idModulosNavigation).WithMany(p => p.rbac_modulos_operaciones)
                .HasForeignKey(d => d.idModulos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_modulos_operaciones_modulos1");

            entity.HasOne(d => d.idOperacionesNavigation).WithMany(p => p.rbac_modulos_operaciones)
                .HasForeignKey(d => d.idOperaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_modulos_operaciones_operaciones1");
        });

        modelBuilder.Entity<rbac_operaciones>(entity =>
        {
            entity.HasKey(e => e.idOperaciones).HasName("PRIMARY");

            entity.Property(e => e.NombreOperacion).HasMaxLength(100);
        });

        modelBuilder.Entity<rbac_refresh_tokens>(entity =>
        {
            entity.HasKey(e => e.idRefreshToken).HasName("PRIMARY");

            entity.HasIndex(e => new { e.idUsuario, e.revokedAt }, "rbac_refresh_tokens_idUsuario_IDX");

            entity.HasIndex(e => e.tokenHash, "rbac_refresh_tokens_tokenHash_IDX");

            entity.HasIndex(e => e.tokenHash, "rbac_refresh_tokens_unique_1").IsUnique();

            entity.Property(e => e.createdAt).HasColumnType("datetime");
            entity.Property(e => e.deviceInfo).HasMaxLength(255);
            entity.Property(e => e.expiresAt).HasColumnType("datetime");
            entity.Property(e => e.familyId).HasMaxLength(36);
            entity.Property(e => e.ipAddress).HasMaxLength(45);
            entity.Property(e => e.revokedAt).HasColumnType("datetime");
            entity.Property(e => e.revokedReason).HasMaxLength(30);

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.rbac_refresh_tokens)
                .HasForeignKey(d => d.idUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rbac_refresh_tokens_usuarios_FK");
        });

        modelBuilder.Entity<rbac_rol>(entity =>
        {
            entity.HasKey(e => e.idRol).HasName("PRIMARY");

            entity.HasIndex(e => e.codigo_rol, "codigo_rol_UNIQUE").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.codigo_rol).HasMaxLength(25);
        });

        modelBuilder.Entity<rbac_rol_modulo_operacion>(entity =>
        {
            entity.HasKey(e => e.idRolModuloOperacion).HasName("PRIMARY");

            entity.HasIndex(e => e.idModulosOperaciones, "fk_rol_modulo_operacion_modulos_operaciones1_idx");

            entity.HasIndex(e => e.idRol, "fk_rol_modulo_operacion_rol1_idx");

            entity.Property(e => e.fecha_asignacion).HasColumnType("date");
            entity.Property(e => e.fecha_desactivacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");

            entity.HasOne(d => d.idModulosOperacionesNavigation).WithMany(p => p.rbac_rol_modulo_operacion)
                .HasForeignKey(d => d.idModulosOperaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rol_modulo_operacion_modulos_operaciones1");

            entity.HasOne(d => d.idRolNavigation).WithMany(p => p.rbac_rol_modulo_operacion)
                .HasForeignKey(d => d.idRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rol_modulo_operacion_rol1");
        });

        modelBuilder.Entity<rbac_sistema>(entity =>
        {
            entity.HasKey(e => e.idSistema).HasName("PRIMARY");

            entity.HasIndex(e => e.codigo, "rbac_sistema_codigo_IDX").IsUnique();

            entity.Property(e => e.codigo).HasMaxLength(20);
            entity.Property(e => e.detalle).HasMaxLength(50);
            entity.Property(e => e.icono).HasMaxLength(50);
            entity.Property(e => e.url).HasMaxLength(500);
        });

        modelBuilder.Entity<rbac_usuario_rol>(entity =>
        {
            entity.HasKey(e => e.idUsuarioRol).HasName("PRIMARY");

            entity.HasIndex(e => e.idRol, "fk_usuario_rol_rol1_idx");

            entity.HasIndex(e => e.idUsuario, "fk_usuario_rol_usuarios1_idx");

            entity.Property(e => e.fecha_creacion).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("date");

            entity.HasOne(d => d.idRolNavigation).WithMany(p => p.rbac_usuario_rol)
                .HasForeignKey(d => d.idRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_rol_rol1");

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.rbac_usuario_rol)
                .HasForeignKey(d => d.idUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_rol_usuarios1");
        });

        modelBuilder.Entity<recuperacion_tiempo>(entity =>
        {
            entity.HasKey(e => e.id_recuperacion).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Detalle transaccional de la recuperación de horas de permisos personales"));

            entity.HasIndex(e => e.id_permiso, "fk_recuperacion_tiempo_permisos");

            entity.HasIndex(e => e.usuario_th, "fk_recuperacion_tiempo_usuarios");

            entity.Property(e => e.fecha_recuperada)
                .HasComment("Fecha en la que el empleado recuperó el tiempo (ej. sábado)")
                .HasColumnType("date");
            entity.Property(e => e.fecha_registro)
                .HasComment("Fecha de registro de la recuperación")
                .HasColumnType("datetime");
            entity.Property(e => e.horas)
                .HasPrecision(4)
                .HasComment("Horas recuperadas en esta fecha");
            entity.Property(e => e.id_permiso).HasComment("Referencia al permiso personal que se está recuperando");
            entity.Property(e => e.usuario_th).HasComment("Analista de TH que convalida");

            entity.HasOne(d => d.id_permisoNavigation).WithMany(p => p.recuperacion_tiempo)
                .HasForeignKey(d => d.id_permiso)
                .HasConstraintName("fk_recuperacion_tiempo_permisos");

            entity.HasOne(d => d.usuario_thNavigation).WithMany(p => p.recuperacion_tiempo)
                .HasForeignKey(d => d.usuario_th)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recuperacion_tiempo_usuarios");
        });

        modelBuilder.Entity<relacion_ies>(entity =>
        {
            entity.HasKey(e => e.idRelacionIes).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(90);
        });

        modelBuilder.Entity<respuestassolicitudes>(entity =>
        {
            entity.HasKey(e => e.idRespuestaSolicitud).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.adjuntaArchivo).HasDefaultValueSql("'0'");
            entity.Property(e => e.adjuntarSoloArchivoAdjunto).HasDefaultValueSql("'0'");
            entity.Property(e => e.archivoAjunto).HasMaxLength(150);
            entity.Property(e => e.detalleRespuesta).HasMaxLength(8000);
            entity.Property(e => e.envioMail).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.fechaRespuesta).HasColumnType("datetime");
            entity.Property(e => e.mailRespuesta).HasMaxLength(100);
            entity.Property(e => e.revisarLogs).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<restricciones>(entity =>
        {
            entity.HasKey(e => e.idrestriccion).HasName("PRIMARY");

            entity.Property(e => e.idrestriccion).HasMaxLength(5);
            entity.Property(e => e.activo).HasColumnType("bit(1)");
            entity.Property(e => e.restriccion).HasMaxLength(100);
        });

        modelBuilder.Entity<saldos_vacaciones>(entity =>
        {
            entity.HasKey(e => e.id_saldo_vacaciones).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Historial de saldos y balances consolidados de vacaciones por periodo anual"));

            entity.HasIndex(e => new { e.id_profesor, e.periodo }, "uk_profesor_periodo").IsUnique();

            entity.Property(e => e.activo)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasComment("Indica si el saldo de este periodo está vigente");
            entity.Property(e => e.dias_acumulados)
                .HasPrecision(8, 4)
                .HasComment("Días transferidos de periodos anteriores no tomados");
            entity.Property(e => e.dias_ganados)
                .HasPrecision(8, 4)
                .HasComment("Días acumulados por derecho legal/ajustes");
            entity.Property(e => e.dias_tomados)
                .HasPrecision(8, 4)
                .HasComment("Días de vacaciones gozados o descontados por permisos en este periodo");
            entity.Property(e => e.fecha_ultimo_calculo)
                .HasComment("Fecha de última actualización")
                .HasColumnType("date");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Cédula o ID del Profesor (Llave foránea a profesores)");
            entity.Property(e => e.periodo)
                .HasMaxLength(9)
                .HasComment("Periodo anual correspondiente (ej. 2024-2025)");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.saldos_vacaciones)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_saldos_vacaciones_profesores");
        });

        modelBuilder.Entity<secciones>(entity =>
        {
            entity.HasKey(e => e.idSeccion).HasName("PRIMARY");

            entity.Property(e => e.seccion).HasMaxLength(30);
            entity.Property(e => e.sufijo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<sectores_empresas>(entity =>
        {
            entity.HasKey(e => e.idsectores_empresas).HasName("PRIMARY");

            entity.Property(e => e.codigo_sector).HasMaxLength(20);
            entity.Property(e => e.nombre_sector).HasMaxLength(90);
        });

        modelBuilder.Entity<seddautoevaluacion>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddautoevaluacion)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddautoevaluacion_ibfk_1");
        });

        modelBuilder.Entity<seddautoriadesperiodos>(entity =>
        {
            entity.HasKey(e => e.idAsignacion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.designacion).HasMaxLength(200);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
        });

        modelBuilder.Entity<seddautoridadescarrerasperiodos>(entity =>
        {
            entity.HasKey(e => e.idAsignacion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.designacion).HasMaxLength(100);
            entity.Property(e => e.idInstrumento).HasDefaultValueSql("'0'");
            entity.Property(e => e.idPeriodo).HasMaxLength(14);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
        });

        modelBuilder.Entity<seddcoevaluacion>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.fechaTest).HasColumnType("datetime");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddcoevaluacion)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddcoevaluacion_ibfk_1");
        });

        modelBuilder.Entity<seddcoevaluacionautoridad>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.fechaTest).HasColumnType("datetime");
            entity.Property(e => e.idEvaluador).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddcoevaluacionautoridad)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddcoevaluacionautoridad_ibfk_1");
        });

        modelBuilder.Entity<sedddetalleautoevaluacion>(entity =>
        {
            entity.HasKey(e => e.idDetalle).HasName("PRIMARY");

            entity.HasIndex(e => e.idPregunta, "idPregunta");

            entity.HasIndex(e => e.idTest, "idTest");

            entity.Property(e => e.respuesta).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idPreguntaNavigation).WithMany(p => p.sedddetalleautoevaluacion)
                .HasForeignKey(d => d.idPregunta)
                .HasConstraintName("sedddetalleautoevaluacion_ibfk_1");

            entity.HasOne(d => d.idTestNavigation).WithMany(p => p.sedddetalleautoevaluacion)
                .HasForeignKey(d => d.idTest)
                .HasConstraintName("sedddetalleautoevaluacion_ibfk_2");
        });

        modelBuilder.Entity<sedddetallecoevaluacion>(entity =>
        {
            entity.HasKey(e => e.idDetalle).HasName("PRIMARY");

            entity.HasIndex(e => e.idPregunta, "idPregunta");

            entity.HasIndex(e => e.idTest, "idTest");

            entity.Property(e => e.respuesta).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idPreguntaNavigation).WithMany(p => p.sedddetallecoevaluacion)
                .HasForeignKey(d => d.idPregunta)
                .HasConstraintName("sedddetallecoevaluacion_ibfk_1");

            entity.HasOne(d => d.idTestNavigation).WithMany(p => p.sedddetallecoevaluacion)
                .HasForeignKey(d => d.idTest)
                .HasConstraintName("sedddetallecoevaluacion_ibfk_2");
        });

        modelBuilder.Entity<sedddetallecoevaluacionautoridad>(entity =>
        {
            entity.HasKey(e => e.idDetalle).HasName("PRIMARY");

            entity.HasIndex(e => e.idPregunta, "idPregunta");

            entity.HasIndex(e => e.idTest, "idTest");

            entity.Property(e => e.respuesta).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idPreguntaNavigation).WithMany(p => p.sedddetallecoevaluacionautoridad)
                .HasForeignKey(d => d.idPregunta)
                .HasConstraintName("sedddetallecoevaluacionautoridad_ibfk_1");

            entity.HasOne(d => d.idTestNavigation).WithMany(p => p.sedddetallecoevaluacionautoridad)
                .HasForeignKey(d => d.idTest)
                .HasConstraintName("sedddetallecoevaluacionautoridad_ibfk_2");
        });

        modelBuilder.Entity<sedddetalleheteroevaluacion>(entity =>
        {
            entity.HasKey(e => e.idDetalle).HasName("PRIMARY");

            entity.HasIndex(e => e.idPregunta, "idPregunta");

            entity.HasIndex(e => e.idTest, "idTest");

            entity.Property(e => e.respuesta).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idPreguntaNavigation).WithMany(p => p.sedddetalleheteroevaluacion)
                .HasForeignKey(d => d.idPregunta)
                .HasConstraintName("sedddetalleheteroevaluacion_ibfk_1");

            entity.HasOne(d => d.idTestNavigation).WithMany(p => p.sedddetalleheteroevaluacion)
                .HasForeignKey(d => d.idTest)
                .HasConstraintName("sedddetalleheteroevaluacion_ibfk_2");
        });

        modelBuilder.Entity<seddheteroevaluacion>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddheteroevaluacion)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddheteroevaluacion_ibfk_1");
        });

        modelBuilder.Entity<seddinsitu>(entity =>
        {
            entity.HasKey(e => e.idEvaluacion).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.calificacion)
                .HasPrecision(5)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.fechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idEvaluador).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddinsitu)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddinsitu_ibfk_1");
        });

        modelBuilder.Entity<seddinstrumentos>(entity =>
        {
            entity.HasKey(e => e.idInstrumento).HasName("PRIMARY");

            entity.HasIndex(e => e.idCategoria, "idCategoria");

            entity.Property(e => e.Instrumento).HasMaxLength(100);
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.codigo).HasMaxLength(3);
            entity.Property(e => e.porcentaje).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idCategoriaNavigation).WithMany(p => p.seddinstrumentos)
                .HasForeignKey(d => d.idCategoria)
                .HasConstraintName("seddinstrumentos_ibfk_1");
        });

        modelBuilder.Entity<seddinstrumentospreguntas>(entity =>
        {
            entity.HasKey(e => e.idInstrumentoPregunta).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.HasIndex(e => e.idPregunta, "idPregunta");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddinstrumentospreguntas)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddinstrumentospreguntas_ibfk_1");

            entity.HasOne(d => d.idPreguntaNavigation).WithMany(p => p.seddinstrumentospreguntas)
                .HasForeignKey(d => d.idPregunta)
                .HasConstraintName("seddinstrumentospreguntas_ibfk_2");
        });

        modelBuilder.Entity<seddpreguntas>(entity =>
        {
            entity.HasKey(e => e.idPregunta).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.pregunta).HasMaxLength(300);
        });

        modelBuilder.Entity<seedevaluadoresinsitu>(entity =>
        {
            entity.HasKey(e => e.idAsignacionEvaluador).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idEvaluador).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
        });

        modelBuilder.Entity<semanas_horarios>(entity =>
        {
            entity.HasKey(e => e.idSemanasHorarios).HasName("PRIMARY");

            entity.Property(e => e.detalle).HasMaxLength(50);
        });

        modelBuilder.Entity<sistema_titulacion>(entity =>
        {
            entity.HasKey(e => e.codigo_sistema).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.detalle).HasMaxLength(100);
        });

        modelBuilder.Entity<solicitudes>(entity =>
        {
            entity.HasKey(e => e.idSolicitud).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoSolicitud, "idTipoSolicitud");

            entity.Property(e => e.anulada).HasDefaultValueSql("'0'");
            entity.Property(e => e.asunto).HasMaxLength(1000);
            entity.Property(e => e.carrera).HasMaxLength(100);
            entity.Property(e => e.cedula).HasMaxLength(14);
            entity.Property(e => e.codigoSolicitud).HasMaxLength(10);
            entity.Property(e => e.emailSolicitante).HasMaxLength(100);
            entity.Property(e => e.esAlumno).HasDefaultValueSql("'0'");
            entity.Property(e => e.esDocente).HasDefaultValueSql("'0'");
            entity.Property(e => e.esExterno).HasDefaultValueSql("'0'");
            entity.Property(e => e.esperandoImpresion).HasDefaultValueSql("'0'");
            entity.Property(e => e.fechaImpresion).HasColumnType("datetime");
            entity.Property(e => e.fechaVenta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.impreso).HasDefaultValueSql("'0'");
            entity.Property(e => e.nivel).HasMaxLength(60);
            entity.Property(e => e.reimprimir).HasDefaultValueSql("'0'");
            entity.Property(e => e.revisarLogs).HasDefaultValueSql("'0'");
            entity.Property(e => e.solicitante).HasMaxLength(150);
            entity.Property(e => e.usuarioVenta).HasMaxLength(20);

            entity.HasOne(d => d.idTipoSolicitudNavigation).WithMany(p => p.solicitudes)
                .HasForeignKey(d => d.idTipoSolicitud)
                .HasConstraintName("solicitudes_ibfk_1");
        });

        modelBuilder.Entity<solicitudes_licencias>(entity =>
        {
            entity.HasKey(e => e.id_licencia).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Permisos con sueldo y licencias justificadas conforme a la ley"));

            entity.HasIndex(e => e.id_profesor, "fk_solicitudes_lic_profesores");

            entity.HasIndex(e => e.usuario_aprobador, "fk_solicitudes_lic_usuario_aprobador");

            entity.Property(e => e.dias_solicitados).HasComment("Cantidad de días solicitados");
            entity.Property(e => e.estado)
                .HasMaxLength(30)
                .HasDefaultValueSql("'PendienteJustificacion'")
                .HasComment("PendienteJustificacion, PendienteAprobacion, Aprobada, Rechazada, FaltaInjustificada");
            entity.Property(e => e.fecha_aprobacion)
                .HasComment("Fecha de aprobación de la licencia")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_entrega_justificativo)
                .HasComment("Fecha en que se cargó el justificativo")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_fin)
                .HasComment("Fin de la licencia")
                .HasColumnType("date");
            entity.Property(e => e.fecha_inicio)
                .HasComment("Inicio de la licencia")
                .HasColumnType("date");
            entity.Property(e => e.fecha_solicitud)
                .HasComment("Fecha de registro en el sistema")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_suceso)
                .HasComment("Fecha en que ocurrió el hecho")
                .HasColumnType("date");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Empleado ausente");
            entity.Property(e => e.motivo)
                .HasComment("Detalle del suceso/solicitud")
                .HasColumnType("text");
            entity.Property(e => e.motivo_rechazo)
                .HasComment("Detalle del rechazo en caso de aplicar")
                .HasColumnType("text");
            entity.Property(e => e.ruta_documento_justificativo)
                .HasMaxLength(255)
                .HasComment("Ruta del justificativo en PDF");
            entity.Property(e => e.tipo_licencia)
                .HasMaxLength(50)
                .HasComment("Maternidad, Paternidad, Lactancia, Capacitacion, CalamidadDomestica, Fallecimiento");
            entity.Property(e => e.usuario_aprobador).HasComment("Usuario de TH que aprueba");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.solicitudes_licencias)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_solicitudes_lic_profesores");

            entity.HasOne(d => d.usuario_aprobadorNavigation).WithMany(p => p.solicitudes_licencias)
                .HasForeignKey(d => d.usuario_aprobador)
                .HasConstraintName("fk_solicitudes_lic_usuario_aprobador");
        });

        modelBuilder.Entity<solicitudes_vacaciones>(entity =>
        {
            entity.HasKey(e => e.id_solicitud).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Solicitudes individuales de vacaciones extraordinarias o fuera de planificación"));

            entity.HasIndex(e => e.id_profesor, "fk_solicitudes_vac_profesores");

            entity.HasIndex(e => e.usuario_rl, "fk_solicitudes_vac_usuario_rl");

            entity.HasIndex(e => e.usuario_th, "fk_solicitudes_vac_usuario_th");

            entity.Property(e => e.dias_solicitados).HasComment("Días ininterrumpidos calculados");
            entity.Property(e => e.es_fuera_planificacion).HasComment("1 = Fuera de planificación, 0 = Dentro");
            entity.Property(e => e.estado)
                .HasMaxLength(30)
                .HasDefaultValueSql("'Pendiente'")
                .HasComment("Pendiente, AprobadaTH, AprobadaRL, Rechazada");
            entity.Property(e => e.fecha_aprobacion_rl).HasColumnType("datetime");
            entity.Property(e => e.fecha_aprobacion_th).HasColumnType("datetime");
            entity.Property(e => e.fecha_fin)
                .HasComment("Fecha de retorno")
                .HasColumnType("date");
            entity.Property(e => e.fecha_inicio)
                .HasComment("Fecha de salida")
                .HasColumnType("date");
            entity.Property(e => e.fecha_solicitud)
                .HasComment("Fecha de creación de la solicitud")
                .HasColumnType("datetime");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Profesor solicitante");
            entity.Property(e => e.motivo_rechazo).HasColumnType("text");
            entity.Property(e => e.motivo_solicitud).HasColumnType("text");
            entity.Property(e => e.ruta_documento_escrito)
                .HasMaxLength(255)
                .HasComment("Ruta del archivo PDF de la solicitud física firmada");
            entity.Property(e => e.usuario_rl).HasComment("Representante Legal que autoriza definitivamente");
            entity.Property(e => e.usuario_th).HasComment("Analista de Talento Humano que pre-aprueba");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.solicitudes_vacaciones)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_solicitudes_vac_profesores");

            entity.HasOne(d => d.usuario_rlNavigation).WithMany(p => p.solicitudes_vacacionesusuario_rlNavigation)
                .HasForeignKey(d => d.usuario_rl)
                .HasConstraintName("fk_solicitudes_vac_usuario_rl");

            entity.HasOne(d => d.usuario_thNavigation).WithMany(p => p.solicitudes_vacacionesusuario_thNavigation)
                .HasForeignKey(d => d.usuario_th)
                .HasConstraintName("fk_solicitudes_vac_usuario_th");
        });

        modelBuilder.Entity<solicitudescalificaciones>(entity =>
        {
            entity.HasKey(e => e.idSolicitudCalificacion).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignatura, "idAsignatura");

            entity.HasIndex(e => e.idMatricula, "idMatricula");

            entity.HasIndex(e => e.idNivel, "idNivel");

            entity.HasIndex(e => e.idParcial, "idParcial");

            entity.HasIndex(e => e.idSolicitud, "idSolicitud");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.calificacion).HasPrecision(4);
            entity.Property(e => e.fechaCalificacion).HasColumnType("datetime");
            entity.Property(e => e.fechaHabilitado).HasColumnType("datetime");
            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.paralelo).HasMaxLength(10);

            entity.HasOne(d => d.idAsignaturaNavigation).WithMany(p => p.solicitudescalificaciones)
                .HasForeignKey(d => d.idAsignatura)
                .HasConstraintName("solicitudescalificaciones_ibfk_5");

            entity.HasOne(d => d.idMatriculaNavigation).WithMany(p => p.solicitudescalificaciones)
                .HasForeignKey(d => d.idMatricula)
                .HasConstraintName("solicitudescalificaciones_ibfk_3");

            entity.HasOne(d => d.idNivelNavigation).WithMany(p => p.solicitudescalificaciones)
                .HasForeignKey(d => d.idNivel)
                .HasConstraintName("solicitudescalificaciones_ibfk_4");

            entity.HasOne(d => d.idParcialNavigation).WithMany(p => p.solicitudescalificaciones)
                .HasForeignKey(d => d.idParcial)
                .HasConstraintName("solicitudescalificaciones_ibfk_2");

            entity.HasOne(d => d.idSolicitudNavigation).WithMany(p => p.solicitudescalificaciones)
                .HasForeignKey(d => d.idSolicitud)
                .HasConstraintName("solicitudescalificaciones_ibfk_1");
        });

        modelBuilder.Entity<solicitudeslogs>(entity =>
        {
            entity.HasKey(e => e.idLogSolicitud).HasName("PRIMARY");

            entity.HasIndex(e => e.idSolicitud, "idSolicitud");

            entity.Property(e => e.detalle).HasMaxLength(2000);
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
        });

        modelBuilder.Entity<subcategoria_vehiculos>(entity =>
        {
            entity.HasKey(e => e.idSubcategoria).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.subcategoria).HasMaxLength(50);
        });

        modelBuilder.Entity<subcategorias_actividades>(entity =>
        {
            entity.HasKey(e => e.idSubcategoria).HasName("PRIMARY");

            entity.HasIndex(e => e.idCategoria, "fk_subcategorias_actividades_categorias_actividades1_idx");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.esDocencia).HasDefaultValueSql("'0'");
            entity.Property(e => e.subcategoria).HasMaxLength(200);

            entity.HasOne(d => d.idCategoriaNavigation).WithMany(p => p.subcategorias_actividades)
                .HasForeignKey(d => d.idCategoria)
                .HasConstraintName("fk_subcategorias_actividades_categorias_actividades1");
        });

        modelBuilder.Entity<sueldos_contratos>(entity =>
        {
            entity.HasKey(e => e.idSueldosContratos).HasName("PRIMARY");

            entity.HasIndex(e => e.idContratos, "fk_sueldos_contratos_contratos1_idx");

            entity.Property(e => e.fecha_cambiosueldo).HasColumnType("date");
            entity.Property(e => e.fecha_registro).HasColumnType("date");
            entity.Property(e => e.sueldo)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.usarioRegistra).HasMaxLength(45);

            entity.HasOne(d => d.idContratosNavigation).WithMany(p => p.sueldos_contratos)
                .HasForeignKey(d => d.idContratos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sueldos_contratos_contratos1");
        });

        modelBuilder.Entity<terminos_condiciones>(entity =>
        {
            entity.HasKey(e => e.idTermino).HasName("PRIMARY");

            entity.Property(e => e.archivoHtml).HasMaxLength(100);
            entity.Property(e => e.contenido).HasColumnType("text");
            entity.Property(e => e.esVigente).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaPublicacion).HasColumnType("date");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.versionTermino).HasMaxLength(20);
        });

        modelBuilder.Entity<tipo_contacto>(entity =>
        {
            entity.HasKey(e => e.idtipo_contacto).HasName("PRIMARY");

            entity.Property(e => e.longitud_contacto).HasMaxLength(90);
            entity.Property(e => e.nombre_contacto).HasMaxLength(90);
        });

        modelBuilder.Entity<tipo_funcionario>(entity =>
        {
            entity.HasKey(e => e.idTipoFuncionario).HasName("PRIMARY");

            entity.Property(e => e.esDocente).HasColumnType("bit(1)");
            entity.Property(e => e.nombre).HasMaxLength(45);
        });

        modelBuilder.Entity<tipos_asignatura>(entity =>
        {
            entity.HasKey(e => e.idtipo_asignatura).HasName("PRIMARY");

            entity.Property(e => e.abreviatura)
                .HasMaxLength(5)
                .IsFixedLength();
            entity.Property(e => e.tipo_asignatura).HasMaxLength(45);
        });

        modelBuilder.Entity<tipos_becas>(entity =>
        {
            entity.HasKey(e => e.idTipoBeca).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(45);
        });

        modelBuilder.Entity<tipos_contratos>(entity =>
        {
            entity.HasKey(e => e.idTiposContratos).HasName("PRIMARY");

            entity.Property(e => e.codigo).HasMaxLength(10);
            entity.Property(e => e.esAfiliado).HasColumnType("bit(1)");
            entity.Property(e => e.nombre).HasMaxLength(90);
        });

        modelBuilder.Entity<tipos_documentos>(entity =>
        {
            entity.HasKey(e => e.idtipos_documentos).HasName("PRIMARY");

            entity.Property(e => e.documento).HasMaxLength(90);
            entity.Property(e => e.subijo_documento).HasMaxLength(10);
        });

        modelBuilder.Entity<tipos_ofertas>(entity =>
        {
            entity.HasKey(e => e.idtipos_ofertas).HasName("PRIMARY");

            entity.Property(e => e.nombre).HasMaxLength(90);
        });

        modelBuilder.Entity<tipos_permisos>(entity =>
        {
            entity.HasKey(e => e.id_tipo_permiso).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Configuración parametrizable de tipos de permisos y licencias"));

            entity.HasIndex(e => e.nombre, "uk_nombre_tipo_permiso").IsUnique();

            entity.Property(e => e.activo)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasComment("0 para deshabilitado/eliminado lógico");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .HasComment("Nombre del permiso (ej. Médico, Calamidad, Personal)");
            entity.Property(e => e.requiere_adjunto).HasComment("1 si es mandatorio adjuntar foto/pdf justificativo");
            entity.Property(e => e.unidad)
                .HasMaxLength(10)
                .HasDefaultValueSql("'HORAS'")
                .HasComment("HORAS o DIAS");
        });

        modelBuilder.Entity<tiposangre>(entity =>
        {
            entity.HasKey(e => e.codigoTipoSangre).HasName("PRIMARY");

            entity.Property(e => e.codigoTipoSangre).HasMaxLength(5);
            entity.Property(e => e.grupo).HasMaxLength(5);
        });

        modelBuilder.Entity<tiposdocumentosi>(entity =>
        {
            entity.HasKey(e => e.tipoDocumento).HasName("PRIMARY");

            entity.Property(e => e.tipoDocumento).HasMaxLength(1);
            entity.Property(e => e.documento).HasMaxLength(20);
        });

        modelBuilder.Entity<tipossolicitudes>(entity =>
        {
            entity.HasKey(e => e.idTipoSolicitud).HasName("PRIMARY");

            entity.HasIndex(e => e.idCategoriaSolicitud, "idCategoriaSolicitud");

            entity.HasIndex(e => e.idDepartamentoSolicitud, "idDepartamentoSolicitud");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.escuelaConduccion).HasDefaultValueSql("'0'");
            entity.Property(e => e.tipoSolicitud).HasMaxLength(200);

            entity.HasOne(d => d.idCategoriaSolicitudNavigation).WithMany(p => p.tipossolicitudes)
                .HasForeignKey(d => d.idCategoriaSolicitud)
                .HasConstraintName("tipossolicitudes_ibfk_1");

            entity.HasOne(d => d.idDepartamentoSolicitudNavigation).WithMany(p => p.tipossolicitudes)
                .HasForeignKey(d => d.idDepartamentoSolicitud)
                .HasConstraintName("tipossolicitudes_ibfk_2");
        });

        modelBuilder.Entity<titulos>(entity =>
        {
            entity.HasKey(e => e.idTitulo).HasName("PRIMARY");

            entity.Property(e => e.creditos_practicas).HasDefaultValueSql("'0'");
            entity.Property(e => e.creditos_titulacion).HasDefaultValueSql("'0'");
            entity.Property(e => e.nivel_final).HasDefaultValueSql("'6'");
            entity.Property(e => e.nivel_inicial).HasDefaultValueSql("'1'");
            entity.Property(e => e.tiene_practicas).HasDefaultValueSql("'1'");
            entity.Property(e => e.tiene_titulacion).HasDefaultValueSql("'1'");
            entity.Property(e => e.titulo).HasMaxLength(100);
            entity.Property(e => e.titulo_femenino).HasMaxLength(100);
        });

        modelBuilder.Entity<titulos_en_curso>(entity =>
        {
            entity.HasKey(e => e.idTitulosProfesorCurso).HasName("PRIMARY");

            entity.HasIndex(e => e.idCampoDetalladoUnesco, "fk_titulos_en_curso_campo_detallado_unesco1_idx");

            entity.HasIndex(e => e.idFinanciamiento, "fk_titulos_en_curso_financiamiento_beca1_idx");

            entity.HasIndex(e => e.idGradoAcademico, "fk_titulos_en_curso_grados_academicos1_idx");

            entity.HasIndex(e => e.idProfesor, "fk_titulos_en_curso_profesores1_idx");

            entity.HasIndex(e => e.idTipoBeca, "fk_titulos_en_curso_tipos_becas1_idx");

            entity.HasIndex(e => e.idUniversidad, "fk_titulos_en_curso_universidades1_idx");

            entity.Property(e => e.fecha_inicio).HasColumnType("date");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.montoBeca).HasPrecision(10);
            entity.Property(e => e.nombreOtro).HasMaxLength(60);
            entity.Property(e => e.titulo).HasMaxLength(200);

            entity.HasOne(d => d.idCampoDetalladoUnescoNavigation).WithMany(p => p.titulos_en_curso)
                .HasForeignKey(d => d.idCampoDetalladoUnesco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_en_curso_campo_detallado_unesco1");

            entity.HasOne(d => d.idFinanciamientoNavigation).WithMany(p => p.titulos_en_curso)
                .HasForeignKey(d => d.idFinanciamiento)
                .HasConstraintName("fk_titulos_en_curso_financiamiento_beca1");

            entity.HasOne(d => d.idGradoAcademicoNavigation).WithMany(p => p.titulos_en_curso)
                .HasForeignKey(d => d.idGradoAcademico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_en_curso_grados_academicos1");

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.titulos_en_curso)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_en_curso_profesores1");

            entity.HasOne(d => d.idTipoBecaNavigation).WithMany(p => p.titulos_en_curso)
                .HasForeignKey(d => d.idTipoBeca)
                .HasConstraintName("fk_titulos_en_curso_tipos_becas1");

            entity.HasOne(d => d.idUniversidadNavigation).WithMany(p => p.titulos_en_curso)
                .HasForeignKey(d => d.idUniversidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_en_curso_universidades1");
        });

        modelBuilder.Entity<titulos_profesores>(entity =>
        {
            entity.HasKey(e => e.idTitulosProfesor).HasName("PRIMARY");

            entity.HasIndex(e => e.idGradoAcademico, "fk_titulos_grados_academicos1_idx");

            entity.HasIndex(e => e.idCampoDetalladoUnesco, "fk_titulos_profesores_campo_detallado_unesco1_idx");

            entity.HasIndex(e => e.idProfesor, "fk_titulos_profesores_profesores1_idx");

            entity.HasIndex(e => e.idUniversidad, "fk_titulos_universidades1_idx");

            entity.Property(e => e.archivoTitulo).HasMaxLength(255);
            entity.Property(e => e.codigo_senescyt).HasMaxLength(90);
            entity.Property(e => e.fecha_obtencion).HasColumnType("date");
            entity.Property(e => e.fecha_registro).HasColumnType("date");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.titulo).HasMaxLength(200);

            entity.HasOne(d => d.idCampoDetalladoUnescoNavigation).WithMany(p => p.titulos_profesores)
                .HasForeignKey(d => d.idCampoDetalladoUnesco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_profesores_campo_detallado_unesco1");

            entity.HasOne(d => d.idGradoAcademicoNavigation).WithMany(p => p.titulos_profesores)
                .HasForeignKey(d => d.idGradoAcademico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_grados_academicos1");

            entity.HasOne(d => d.idProfesorNavigation).WithMany(p => p.titulos_profesores)
                .HasForeignKey(d => d.idProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_profesores_profesores1");

            entity.HasOne(d => d.idUniversidadNavigation).WithMany(p => p.titulos_profesores)
                .HasForeignKey(d => d.idUniversidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_titulos_universidades1");
        });

        modelBuilder.Entity<universidades>(entity =>
        {
            entity.HasKey(e => e.idUniversidad).HasName("PRIMARY");

            entity.HasIndex(e => e.idpaises, "fk_universidades_paises1_idx");

            entity.Property(e => e.codigo_siees).HasMaxLength(100);
            entity.Property(e => e.nombre).HasMaxLength(255);

            entity.HasOne(d => d.idpaisesNavigation).WithMany(p => p.universidades)
                .HasForeignKey(d => d.idpaises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_universidades_paises1");
        });

        modelBuilder.Entity<usuarios>(entity =>
        {
            entity.HasKey(e => e.idUsuario).HasName("PRIMARY");

            entity.HasIndex(e => e.idSigafi, "usuario_UNIQUE").IsUnique();

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.contrasenia).HasMaxLength(250);
            entity.Property(e => e.emailInstitucional).HasMaxLength(100);
            entity.Property(e => e.fechaEmailValidacion).HasColumnType("datetime");
            entity.Property(e => e.hashEmailToken).HasMaxLength(255);
            entity.Property(e => e.idSigafi)
                .HasMaxLength(20)
                .HasComment("este es idSifafi\\n");
            entity.Property(e => e.nombre).HasMaxLength(200);
            entity.Property(e => e.tablaSigafi).HasColumnType("enum('alumno','profesor','otros')");
        });

        modelBuilder.Entity<usuarios_web>(entity =>
        {
            entity.HasKey(e => e.usuario).HasName("PRIMARY");

            entity.Property(e => e.usuario).HasMaxLength(20);
            entity.Property(e => e.activo).HasDefaultValueSql("'0'");
            entity.Property(e => e.asistencia).HasDefaultValueSql("'0'");
            entity.Property(e => e.esRrhh).HasDefaultValueSql("'0'");
            entity.Property(e => e.ingreso).HasDefaultValueSql("'0'");
            entity.Property(e => e.password).HasMaxLength(20);
            entity.Property(e => e.salida).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<usuariosdepartamentossolicitudes>(entity =>
        {
            entity.HasKey(e => e.idUsuarioDepartamentoSolicitud).HasName("PRIMARY");

            entity.HasIndex(e => e.idTipoSolicitud, "idTipoSolicitud");

            entity.HasIndex(e => e.idUsuarioSolicitud, "idUsuarioSolicitud");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaBaja).HasColumnType("datetime");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");

            entity.HasOne(d => d.idTipoSolicitudNavigation).WithMany(p => p.usuariosdepartamentossolicitudes)
                .HasForeignKey(d => d.idTipoSolicitud)
                .HasConstraintName("usuariosdepartamentossolicitudes_ibfk_2");

            entity.HasOne(d => d.idUsuarioSolicitudNavigation).WithMany(p => p.usuariosdepartamentossolicitudes)
                .HasForeignKey(d => d.idUsuarioSolicitud)
                .HasConstraintName("usuariosdepartamentossolicitudes_ibfk_1");
        });

        modelBuilder.Entity<usuariossolicitudes>(entity =>
        {
            entity.HasKey(e => e.idUsuarioSolicitud).HasName("PRIMARY");

            entity.Property(e => e.Administrador).HasDefaultValueSql("'0'");
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.clave).HasMaxLength(20);
            entity.Property(e => e.email).HasMaxLength(60);
            entity.Property(e => e.nombre).HasMaxLength(100);
            entity.Property(e => e.resetear).HasDefaultValueSql("'0'");
            entity.Property(e => e.usuario).HasMaxLength(60);
        });

        modelBuilder.Entity<vacaciones_ledger>(entity =>
        {
            entity.HasKey(e => e.id_ledger).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Libro Diario contable de transacciones de saldo de vacaciones (Odoo-Style)"));

            entity.HasIndex(e => e.id_profesor, "fk_vacaciones_ledger_profesores");

            entity.HasIndex(e => e.registrado_por_id, "fk_vacaciones_ledger_usuarios");

            entity.Property(e => e.detalle)
                .HasMaxLength(255)
                .HasComment("Detalle o descripción de la transacción");
            entity.Property(e => e.dias)
                .HasPrecision(8, 4)
                .HasComment("Crédito (+) o Débito (-) en días de vacaciones");
            entity.Property(e => e.fecha)
                .HasComment("Fecha y hora de la transacción")
                .HasColumnType("datetime");
            entity.Property(e => e.id_profesor)
                .HasMaxLength(14)
                .HasComment("Profesor al que afecta la transacción");
            entity.Property(e => e.periodo)
                .HasMaxLength(9)
                .HasComment("Periodo anual al que corresponde (ej. 2025-2026)");
            entity.Property(e => e.registrado_por_id).HasComment("Usuario de RRHH (TH o RL) que ejecutó el registro");
            entity.Property(e => e.tipo_transaccion)
                .HasMaxLength(30)
                .HasComment("ACREDITACION, GOCE, DESCUENTO_PERMISO, CADUCIDAD, BONIFICACION_SEPT, AJUSTE_CREDITO, AJUSTE_DEBITO");

            entity.HasOne(d => d.id_profesorNavigation).WithMany(p => p.vacaciones_ledger)
                .HasForeignKey(d => d.id_profesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_vacaciones_ledger_profesores");

            entity.HasOne(d => d.registrado_por).WithMany(p => p.vacaciones_ledger)
                .HasForeignKey(d => d.registrado_por_id)
                .HasConstraintName("fk_vacaciones_ledger_usuarios");
        });

        modelBuilder.Entity<vehiculos>(entity =>
        {
            entity.HasKey(e => e.idVehiculo).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.chasis).HasMaxLength(50);
            entity.Property(e => e.marca).HasMaxLength(100);
            entity.Property(e => e.modelo).HasMaxLength(100);
            entity.Property(e => e.motor).HasMaxLength(50);
            entity.Property(e => e.numero_vehiculo).HasMaxLength(3);
            entity.Property(e => e.observacion).HasMaxLength(200);
            entity.Property(e => e.placa).HasMaxLength(10);
        });

        modelBuilder.Entity<vehiculos_operacion>(entity =>
        {
            entity.HasKey(e => e.idVehiculo).HasName("PRIMARY");

            entity.Property(e => e.estado_mecanico)
                .HasMaxLength(30)
                .HasDefaultValueSql("'OPERATIVO'");
            entity.Property(e => e.id_instructor_fijo).HasMaxLength(14);

            entity.HasOne(d => d.idVehiculoNavigation).WithOne(p => p.vehiculos_operacion)
                .HasForeignKey<vehiculos_operacion>(d => d.idVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vehiculos_operacion_ibfk_1");
        });

        modelBuilder.Entity<vinculacionarea>(entity =>
        {
            entity.HasKey(e => e.idArea).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.area).HasMaxLength(250);
        });

        modelBuilder.Entity<vinculacioncategoriasobjetivosoportunidades>(entity =>
        {
            entity.HasKey(e => e.idCategoriaObjetivoOportunidad).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.categoriaObjetivoOportunidad).HasMaxLength(100);
        });

        modelBuilder.Entity<vinculacioncategoriasresultadosaprendizajes>(entity =>
        {
            entity.HasKey(e => e.idCategoriaResultadoAprendizaje).HasName("PRIMARY");

            entity.Property(e => e.categoriaResultadoAprendizaje).HasMaxLength(50);
        });

        modelBuilder.Entity<vinculacionestadosproyectos>(entity =>
        {
            entity.HasKey(e => e.idEstadoProyecto).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.estado).HasMaxLength(100);
        });

        modelBuilder.Entity<vinculacionhabilidadesblandas>(entity =>
        {
            entity.HasKey(e => e.idHablidadBlanda).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.descripcion).HasMaxLength(500);
            entity.Property(e => e.habilidadBlanda).HasMaxLength(100);
        });

        modelBuilder.Entity<vinculacionimpactosproyectos>(entity =>
        {
            entity.HasKey(e => e.idImpactoproyecto).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.impactoProyecto).HasMaxLength(100);
        });

        modelBuilder.Entity<vinculacionlineasaccion>(entity =>
        {
            entity.HasKey(e => e.idlineaAsccion).HasName("PRIMARY");

            entity.Property(e => e.linea).HasMaxLength(100);
        });

        modelBuilder.Entity<vinculacionobjetivosoportunidades>(entity =>
        {
            entity.HasKey(e => e.idObjetivoOportunidad).HasName("PRIMARY");

            entity.HasIndex(e => e.idCategoriaObjetivoOportunidad, "idCategoriaObjetivoOportunidad");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.objetivoOportunidad).HasMaxLength(500);

            entity.HasOne(d => d.idCategoriaObjetivoOportunidadNavigation).WithMany(p => p.vinculacionobjetivosoportunidades)
                .HasForeignKey(d => d.idCategoriaObjetivoOportunidad)
                .HasConstraintName("vinculacionobjetivosoportunidades_ibfk_1");
        });

        modelBuilder.Entity<vinculacionobjetivospedis>(entity =>
        {
            entity.HasKey(e => e.idObjetivoPedi).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.objetivoPedi).HasMaxLength(500);
            entity.Property(e => e.pedi).HasMaxLength(9);
        });

        modelBuilder.Entity<vinculacionpoblaciondirecta>(entity =>
        {
            entity.HasKey(e => e.idPoblacionDirecta).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.directa).HasMaxLength(250);
        });

        modelBuilder.Entity<vinculacionpoblacionexterna>(entity =>
        {
            entity.HasKey(e => e.idPoblacionExterna).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.externa).HasMaxLength(250);
        });

        modelBuilder.Entity<vinculacionpoblacionindirecta>(entity =>
        {
            entity.HasKey(e => e.idPoblacionIndirecta).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.indirecta).HasMaxLength(250);
        });

        modelBuilder.Entity<vinculacionprogramas>(entity =>
        {
            entity.HasKey(e => e.idPrograma).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.fechaFin).HasColumnType("date");
            entity.Property(e => e.fechaInicio).HasColumnType("date");
            entity.Property(e => e.programa).HasMaxLength(200);
        });

        modelBuilder.Entity<vinculacionproyectos>(entity =>
        {
            entity.HasKey(e => e.idProyectoVinculacion).HasName("PRIMARY");

            entity.HasIndex(e => e.idCampoDetalladoUnesco, "idCampoDetalladoUnesco");

            entity.HasIndex(e => e.idlineaAsccion, "idlineaAsccion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.alcanceTerritorial).HasMaxLength(100);
            entity.Property(e => e.antecedentes).HasColumnType("text");
            entity.Property(e => e.biografia).HasColumnType("text");
            entity.Property(e => e.esAsistenciaComunitaria).HasDefaultValueSql("'0'");
            entity.Property(e => e.esEducacionContinua).HasDefaultValueSql("'0'");
            entity.Property(e => e.habilidadesDescripcion).HasColumnType("text");
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.impacto).HasColumnType("text");
            entity.Property(e => e.innovacion).HasColumnType("text");
            entity.Property(e => e.metodologia).HasColumnType("text");
            entity.Property(e => e.proyecto).HasMaxLength(500);
            entity.Property(e => e.resumenEjecutivo).HasColumnType("text");
            entity.Property(e => e.tiempoEstimado).HasMaxLength(50);

            entity.HasOne(d => d.idCampoDetalladoUnescoNavigation).WithMany(p => p.vinculacionproyectos)
                .HasForeignKey(d => d.idCampoDetalladoUnesco)
                .HasConstraintName("vinculacionproyectos_ibfk_1");

            entity.HasOne(d => d.idlineaAsccionNavigation).WithMany(p => p.vinculacionproyectos)
                .HasForeignKey(d => d.idlineaAsccion)
                .HasConstraintName("vinculacionproyectos_ibfk_2");
        });

        modelBuilder.Entity<vinculacionproyectosalumnos>(entity =>
        {
            entity.HasKey(e => e.idProyectoAlumno).HasName("PRIMARY");

            entity.HasIndex(e => e.idMatricula, "idMatricula");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idMatriculaNavigation).WithMany(p => p.vinculacionproyectosalumnos)
                .HasForeignKey(d => d.idMatricula)
                .HasConstraintName("vinculacionproyectosalumnos_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosalumnos)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosalumnos_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectoscarreras>(entity =>
        {
            entity.HasKey(e => e.idProyectoCarrera).HasName("PRIMARY");

            entity.HasIndex(e => e.idCarrera, "idCarrera");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.esPrincipal).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idCarreraNavigation).WithMany(p => p.vinculacionproyectoscarreras)
                .HasForeignKey(d => d.idCarrera)
                .HasConstraintName("vinculacionproyectoscarreras_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectoscarreras)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectoscarreras_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectoscarrerasdetalle>(entity =>
        {
            entity.HasKey(e => e.idProyectoCarrera).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.HasIndex(e => e.idTipoPoblacion, "idTipoPoblacion");

            entity.Property(e => e.descripcion).HasMaxLength(400);
            entity.Property(e => e.poblacion).HasMaxLength(100);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectoscarrerasdetalle)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectoscarrerasdetalle_ibfk_1");

            entity.HasOne(d => d.idTipoPoblacionNavigation).WithMany(p => p.vinculacionproyectoscarrerasdetalle)
                .HasForeignKey(d => d.idTipoPoblacion)
                .HasConstraintName("vinculacionproyectoscarrerasdetalle_ibfk_2");
        });

        modelBuilder.Entity<vinculacionproyectoscronograma>(entity =>
        {
            entity.HasKey(e => e.idProyectosCronograma).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.actividad).HasMaxLength(5000);
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaFinCumplida).HasColumnType("timestamp");
            entity.Property(e => e.fechaFinPlanificada).HasColumnType("timestamp");
            entity.Property(e => e.fechaInicioCumplida).HasColumnType("timestamp");
            entity.Property(e => e.fechaInicioPlanificada).HasColumnType("timestamp");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectoscronograma)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectoscronograma_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosentidades>(entity =>
        {
            entity.HasKey(e => e.idProyectoEntidad).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.entidad).HasMaxLength(200);
            entity.Property(e => e.tipoEntidad).HasMaxLength(200);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosentidades)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosentidades_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectoshabilidadesblandas>(entity =>
        {
            entity.HasKey(e => e.idProyectoHabilidad).HasName("PRIMARY");

            entity.HasIndex(e => e.idHablidadBlanda, "idHablidadBlanda");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idHablidadBlandaNavigation).WithMany(p => p.vinculacionproyectoshabilidadesblandas)
                .HasForeignKey(d => d.idHablidadBlanda)
                .HasConstraintName("vinculacionproyectoshabilidadesblandas_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectoshabilidadesblandas)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectoshabilidadesblandas_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosimpactos>(entity =>
        {
            entity.HasKey(e => e.idProyectoImpacto).HasName("PRIMARY");

            entity.HasIndex(e => e.idImpactoproyecto, "idImpactoproyecto");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idImpactoproyectoNavigation).WithMany(p => p.vinculacionproyectosimpactos)
                .HasForeignKey(d => d.idImpactoproyecto)
                .HasConstraintName("vinculacionproyectosimpactos_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosimpactos)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosimpactos_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosmateriales>(entity =>
        {
            entity.HasKey(e => e.idProyectosMateriales).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.material).HasMaxLength(5000);
            entity.Property(e => e.total).HasPrecision(5);
            entity.Property(e => e.valor).HasPrecision(5);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosmateriales)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosmateriales_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosobjetivos>(entity =>
        {
            entity.HasKey(e => e.idProyectoObjetivo).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.esGeneral).HasDefaultValueSql("'0'");
            entity.Property(e => e.objetivo).HasColumnType("text");
            entity.Property(e => e.resultado).HasColumnType("text");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosobjetivos)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosobjetivos_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosobjetivosoportunidades>(entity =>
        {
            entity.HasKey(e => e.idProyectObjetivoOportunidad).HasName("PRIMARY");

            entity.HasIndex(e => e.idObjetivoOportunidad, "idObjetivoOportunidad");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idObjetivoOportunidadNavigation).WithMany(p => p.vinculacionproyectosobjetivosoportunidades)
                .HasForeignKey(d => d.idObjetivoOportunidad)
                .HasConstraintName("vinculacionproyectosobjetivosoportunidades_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosobjetivosoportunidades)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosobjetivosoportunidades_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosobjetivospedis>(entity =>
        {
            entity.HasKey(e => e.idProyectoObjetivoPedi).HasName("PRIMARY");

            entity.HasIndex(e => e.idObjetivoPedi, "idObjetivoPedi");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.idObjetivoPediNavigation).WithMany(p => p.vinculacionproyectosobjetivospedis)
                .HasForeignKey(d => d.idObjetivoPedi)
                .HasConstraintName("vinculacionproyectosobjetivospedis_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosobjetivospedis)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosobjetivospedis_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosperiodos>(entity =>
        {
            entity.HasKey(e => e.idProyectoPeriodo).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.esPrincipal).HasDefaultValueSql("'0'");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosperiodos)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosperiodos_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosplanesaprendizaje>(entity =>
        {
            entity.HasKey(e => e.idProyectosPlanesAprendizaje).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.HasIndex(e => e.idProyectosResultadosAprendizaje, "idProyectosResultadosAprendizaje");

            entity.Property(e => e.actividad).HasMaxLength(5000);
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosplanesaprendizaje)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosplanesaprendizaje_ibfk_1");

            entity.HasOne(d => d.idProyectosResultadosAprendizajeNavigation).WithMany(p => p.vinculacionproyectosplanesaprendizaje)
                .HasForeignKey(d => d.idProyectosResultadosAprendizaje)
                .HasConstraintName("vinculacionproyectosplanesaprendizaje_ibfk_2");
        });

        modelBuilder.Entity<vinculacionproyectosplantrabajo>(entity =>
        {
            entity.HasKey(e => e.idProyectosPlanTrabajo).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoImpacto, "idProyectoImpacto");

            entity.HasIndex(e => e.idProyectoObjetivo, "idProyectoObjetivo");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.actividades).HasColumnType("text");
            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.indicador).HasColumnType("text");
            entity.Property(e => e.medioVerificacion).HasColumnType("text");
            entity.Property(e => e.resultadoEsperado).HasColumnType("text");
            entity.Property(e => e.resultados).HasColumnType("text");

            entity.HasOne(d => d.idProyectoImpactoNavigation).WithMany(p => p.vinculacionproyectosplantrabajo)
                .HasForeignKey(d => d.idProyectoImpacto)
                .HasConstraintName("vinculacionproyectosplantrabajo_ibfk_3");

            entity.HasOne(d => d.idProyectoObjetivoNavigation).WithMany(p => p.vinculacionproyectosplantrabajo)
                .HasForeignKey(d => d.idProyectoObjetivo)
                .HasConstraintName("vinculacionproyectosplantrabajo_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosplantrabajo)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosplantrabajo_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectospoblaciones>(entity =>
        {
            entity.HasKey(e => e.idProyectosPoblaciones).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.contacto).HasMaxLength(100);
            entity.Property(e => e.direccion).HasMaxLength(250);
            entity.Property(e => e.email).HasMaxLength(50);
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.nombre).HasMaxLength(500);
            entity.Property(e => e.telefono).HasMaxLength(15);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectospoblaciones)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectospoblaciones_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectospresupuestos>(entity =>
        {
            entity.HasKey(e => e.idProyectoPresupuesto).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.cantidad)
                .HasPrecision(10)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.empresa).HasMaxLength(100);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectospresupuestos)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectospresupuestos_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosprofesores>(entity =>
        {
            entity.HasKey(e => e.idProyectoProfesor).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.esDirector).HasDefaultValueSql("'0'");
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosprofesores)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosprofesores_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosresponsables>(entity =>
        {
            entity.HasKey(e => e.idProyectoResponsable).HasName("PRIMARY");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.esColaborador).HasDefaultValueSql("'0'");
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosresponsables)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosresponsables_ibfk_1");
        });

        modelBuilder.Entity<vinculacionproyectosresultadosaprendizaje>(entity =>
        {
            entity.HasKey(e => e.idProyectosResultadosAprendizaje).HasName("PRIMARY");

            entity.HasIndex(e => e.idCategoriaResultadoAprendizaje, "idCategoriaResultadoAprendizaje");

            entity.HasIndex(e => e.idProyectoVinculacion, "idProyectoVinculacion");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.resultado).HasMaxLength(5000);

            entity.HasOne(d => d.idCategoriaResultadoAprendizajeNavigation).WithMany(p => p.vinculacionproyectosresultadosaprendizaje)
                .HasForeignKey(d => d.idCategoriaResultadoAprendizaje)
                .HasConstraintName("vinculacionproyectosresultadosaprendizaje_ibfk_2");

            entity.HasOne(d => d.idProyectoVinculacionNavigation).WithMany(p => p.vinculacionproyectosresultadosaprendizaje)
                .HasForeignKey(d => d.idProyectoVinculacion)
                .HasConstraintName("vinculacionproyectosresultadosaprendizaje_ibfk_1");
        });

        modelBuilder.Entity<vinculacionsubarea>(entity =>
        {
            entity.HasKey(e => e.idSubArea).HasName("PRIMARY");

            entity.HasIndex(e => e.idArea, "idArea");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.subArea).HasMaxLength(250);

            entity.HasOne(d => d.idAreaNavigation).WithMany(p => p.vinculacionsubarea)
                .HasForeignKey(d => d.idArea)
                .HasConstraintName("vinculacionsubarea_ibfk_1");
        });

        modelBuilder.Entity<vinculacionsubareaespecifica>(entity =>
        {
            entity.HasKey(e => e.idSubAreaEspecifica).HasName("PRIMARY");

            entity.HasIndex(e => e.idSubArea, "idSubArea");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.subAreaEspecifica).HasMaxLength(250);

            entity.HasOne(d => d.idSubAreaNavigation).WithMany(p => p.vinculacionsubareaespecifica)
                .HasForeignKey(d => d.idSubArea)
                .HasConstraintName("vinculacionsubareaespecifica_ibfk_1");
        });

        modelBuilder.Entity<vinculaciontiposobjetivos>(entity =>
        {
            entity.HasKey(e => e.idTipoObjetivo).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.tipoObjetivo).HasMaxLength(50);
        });

        modelBuilder.Entity<vinculaciontipospoblaciones>(entity =>
        {
            entity.HasKey(e => e.idTipoPoblacion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.tipoPoblacion).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
