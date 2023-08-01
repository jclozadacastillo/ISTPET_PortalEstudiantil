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

    public virtual DbSet<agenda_academica> agenda_academica { get; set; }

    public virtual DbSet<alumnos> alumnos { get; set; }

    public virtual DbSet<alumnos_acta_conduccion> alumnos_acta_conduccion { get; set; }

    public virtual DbSet<alumnos_carreras> alumnos_carreras { get; set; }

    public virtual DbSet<alumnos_inscripciones> alumnos_inscripciones { get; set; }

    public virtual DbSet<alumnos_inscripciones_ingles> alumnos_inscripciones_ingles { get; set; }

    public virtual DbSet<alumnos_restricciones> alumnos_restricciones { get; set; }

    public virtual DbSet<alumnos_sucesos> alumnos_sucesos { get; set; }

    public virtual DbSet<alumnos_titulos> alumnos_titulos { get; set; }

    public virtual DbSet<asignacion_instructores_vehiculos> asignacion_instructores_vehiculos { get; set; }

    public virtual DbSet<asignaciones_profesores> asignaciones_profesores { get; set; }

    public virtual DbSet<asignaciones_profesores_grado> asignaciones_profesores_grado { get; set; }

    public virtual DbSet<asignaciones_propedeutico> asignaciones_propedeutico { get; set; }

    public virtual DbSet<asignaturas> asignaturas { get; set; }

    public virtual DbSet<asignaturas_complementos_formacion> asignaturas_complementos_formacion { get; set; }

    public virtual DbSet<asignaturas_propedeutico> asignaturas_propedeutico { get; set; }

    public virtual DbSet<auditoria_pagos> auditoria_pagos { get; set; }

    public virtual DbSet<calificaciones> calificaciones { get; set; }

    public virtual DbSet<calificaciones_complementos_formacion> calificaciones_complementos_formacion { get; set; }

    public virtual DbSet<calificaciones_conduccion> calificaciones_conduccion { get; set; }

    public virtual DbSet<calificaciones_grado> calificaciones_grado { get; set; }

    public virtual DbSet<calificaciones_propedeutico> calificaciones_propedeutico { get; set; }

    public virtual DbSet<cambiosmalla> cambiosmalla { get; set; }

    public virtual DbSet<carreras> carreras { get; set; }

    public virtual DbSet<categoria_vehiculos> categoria_vehiculos { get; set; }

    public virtual DbSet<categorias_actividades> categorias_actividades { get; set; }

    public virtual DbSet<categorias_examenes_conduccion> categorias_examenes_conduccion { get; set; }

    public virtual DbSet<cliente_factura> cliente_factura { get; set; }

    public virtual DbSet<complementos_formacion> complementos_formacion { get; set; }

    public virtual DbSet<cond_alumnos_horarios> cond_alumnos_horarios { get; set; }

    public virtual DbSet<cond_alumnos_practicas> cond_alumnos_practicas { get; set; }

    public virtual DbSet<cond_alumnos_vehiculos> cond_alumnos_vehiculos { get; set; }

    public virtual DbSet<cond_practicas_horarios_alumnos> cond_practicas_horarios_alumnos { get; set; }

    public virtual DbSet<credito_alumno> credito_alumno { get; set; }

    public virtual DbSet<cuentas> cuentas { get; set; }

    public virtual DbSet<cursos> cursos { get; set; }

    public virtual DbSet<detalle_pagos> detalle_pagos { get; set; }

    public virtual DbSet<detalle_sistema_evaluacion> detalle_sistema_evaluacion { get; set; }

    public virtual DbSet<detallemallas> detallemallas { get; set; }

    public virtual DbSet<detalles_documentos_pagos> detalles_documentos_pagos { get; set; }

    public virtual DbSet<discapacidades> discapacidades { get; set; }

    public virtual DbSet<ed_alumnostest> ed_alumnostest { get; set; }

    public virtual DbSet<ed_encuestas> ed_encuestas { get; set; }

    public virtual DbSet<ed_fechasevaluacion> ed_fechasevaluacion { get; set; }

    public virtual DbSet<ed_preguntas> ed_preguntas { get; set; }

    public virtual DbSet<ed_respuestastest> ed_respuestastest { get; set; }

    public virtual DbSet<ed_respuestastestab> ed_respuestastestab { get; set; }

    public virtual DbSet<especies> especies { get; set; }

    public virtual DbSet<especies_extras> especies_extras { get; set; }

    public virtual DbSet<etnias> etnias { get; set; }

    public virtual DbSet<fechas_grados> fechas_grados { get; set; }

    public virtual DbSet<fechas_horarios> fechas_horarios { get; set; }

    public virtual DbSet<fechas_pagos> fechas_pagos { get; set; }

    public virtual DbSet<horario_profesores> horario_profesores { get; set; }

    public virtual DbSet<horas_clases> horas_clases { get; set; }

    public virtual DbSet<instituciones> instituciones { get; set; }

    public virtual DbSet<logsmigraciones> logsmigraciones { get; set; }

    public virtual DbSet<mallas> mallas { get; set; }

    public virtual DbSet<mallas_periodos> mallas_periodos { get; set; }

    public virtual DbSet<matriculas> matriculas { get; set; }

    public virtual DbSet<matriculas_asistencias> matriculas_asistencias { get; set; }

    public virtual DbSet<matriculas_examen_conduccion> matriculas_examen_conduccion { get; set; }

    public virtual DbSet<medios_contacto> medios_contacto { get; set; }

    public virtual DbSet<modalidades> modalidades { get; set; }

    public virtual DbSet<nacionalidades> nacionalidades { get; set; }

    public virtual DbSet<pagos> pagos { get; set; }

    public virtual DbSet<parciales> parciales { get; set; }

    public virtual DbSet<parciales_modalidades> parciales_modalidades { get; set; }

    public virtual DbSet<parciales_modalidades_fechas> parciales_modalidades_fechas { get; set; }

    public virtual DbSet<periodos> periodos { get; set; }

    public virtual DbSet<periodos_inscripciones> periodos_inscripciones { get; set; }

    public virtual DbSet<periodos_matriculas_niveles> periodos_matriculas_niveles { get; set; }

    public virtual DbSet<prerequisitos> prerequisitos { get; set; }

    public virtual DbSet<procesos_usuario> procesos_usuario { get; set; }

    public virtual DbSet<profesores> profesores { get; set; }

    public virtual DbSet<profesores_actas_parciales> profesores_actas_parciales { get; set; }

    public virtual DbSet<profesores_actividades> profesores_actividades { get; set; }

    public virtual DbSet<restricciones> restricciones { get; set; }

    public virtual DbSet<secciones> secciones { get; set; }

    public virtual DbSet<seddautoevaluacion> seddautoevaluacion { get; set; }

    public virtual DbSet<seddautoridadesperiodos> seddautoridadesperiodos { get; set; }

    public virtual DbSet<seddcoevaluacion> seddcoevaluacion { get; set; }

    public virtual DbSet<sedddetalleautoevaluacion> sedddetalleautoevaluacion { get; set; }

    public virtual DbSet<sedddetallecoevaluacion> sedddetallecoevaluacion { get; set; }

    public virtual DbSet<sedddetalleevaluacionautoridad> sedddetalleevaluacionautoridad { get; set; }

    public virtual DbSet<sedddetalleheteroevaluacion> sedddetalleheteroevaluacion { get; set; }

    public virtual DbSet<seddevaluacionautoridad> seddevaluacionautoridad { get; set; }

    public virtual DbSet<seddheteroevaluacion> seddheteroevaluacion { get; set; }

    public virtual DbSet<seddinstrumentos> seddinstrumentos { get; set; }

    public virtual DbSet<seddinstrumentospreguntas> seddinstrumentospreguntas { get; set; }

    public virtual DbSet<seddpreguntas> seddpreguntas { get; set; }

    public virtual DbSet<sistema_titulacion> sistema_titulacion { get; set; }

    public virtual DbSet<subcategoria_vehiculos> subcategoria_vehiculos { get; set; }

    public virtual DbSet<subcategorias_actividades> subcategorias_actividades { get; set; }

    public virtual DbSet<tiposdocumentosi> tiposdocumentosi { get; set; }

    public virtual DbSet<titulos> titulos { get; set; }

    public virtual DbSet<usuarios_web> usuarios_web { get; set; }

    public virtual DbSet<vehiculos> vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("name=sigafi_es");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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

            entity.Property(e => e.idAlumno)
                .HasMaxLength(14)
                .HasDefaultValueSql("''");
            entity.Property(e => e.apellidoMaterno).HasMaxLength(30);
            entity.Property(e => e.apellidoPaterno).HasMaxLength(30);
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
            entity.Property(e => e.tipo_sangre).HasMaxLength(6);
            entity.Property(e => e.tituloColegio).HasMaxLength(200);
            entity.Property(e => e.user_alumno).HasMaxLength(20);
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
            entity.Property(e => e.entrega_acta).HasDefaultValueSql("'0'");
            entity.Property(e => e.esActivaAsignacion).HasDefaultValueSql("'1'");
            entity.Property(e => e.fecha_fin).HasColumnType("date");
            entity.Property(e => e.fecha_grabar).HasColumnType("datetime");
            entity.Property(e => e.fecha_inicial).HasColumnType("date");
            entity.Property(e => e.fecha_modificacion).HasColumnType("datetime");
            entity.Property(e => e.idAsignacion).ValueGeneratedOnAdd();
            entity.Property(e => e.ingresa_notas).HasDefaultValueSql("'0'");
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

        modelBuilder.Entity<asignaturas>(entity =>
        {
            entity.HasKey(e => e.idAsignatura).HasName("PRIMARY");

            entity.Property(e => e.asignatura).HasMaxLength(200);
            entity.Property(e => e.codigo).HasMaxLength(30);
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

        modelBuilder.Entity<calificaciones>(entity =>
        {
            entity.HasKey(e => new { e.idAsignatura, e.idMatricula }).HasName("PRIMARY");

            entity.HasIndex(e => e.idMatricula, "R_30");

            entity.Property(e => e.aprobado).HasDefaultValueSql("'0'");
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

        modelBuilder.Entity<carreras>(entity =>
        {
            entity.HasKey(e => e.idCarrera).HasName("PRIMARY");

            entity.Property(e => e.Carrera).HasMaxLength(100);
            entity.Property(e => e.aliasCarrera).HasMaxLength(5);
            entity.Property(e => e.codigo_cases).HasMaxLength(20);
            entity.Property(e => e.directorCarrera).HasMaxLength(100);
            entity.Property(e => e.fechaCreacion).HasColumnType("date");
            entity.Property(e => e.ordenCarrera).HasDefaultValueSql("'0'");
            entity.Property(e => e.revisaArrastres).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<categoria_vehiculos>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasName("PRIMARY");

            entity.Property(e => e.categoria).HasMaxLength(100);
        });

        modelBuilder.Entity<categorias_actividades>(entity =>
        {
            entity.HasKey(e => e.idCategoria).HasName("PRIMARY");

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
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

        modelBuilder.Entity<credito_alumno>(entity =>
        {
            entity.HasKey(e => new { e.idMatricula, e.idEspecie }).HasName("PRIMARY");

            entity.HasIndex(e => e.idCredito, "idCredito");

            entity.Property(e => e.beca).HasPrecision(8);
            entity.Property(e => e.credito_inicial).HasPrecision(8);
            entity.Property(e => e.fechaMigracion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.idCredito).ValueGeneratedOnAdd();
            entity.Property(e => e.idDeudaApi).HasMaxLength(150);
            entity.Property(e => e.migradoContabilidad).HasDefaultValueSql("'0'");
            entity.Property(e => e.saldo).HasPrecision(8);
            entity.Property(e => e.saldo_beca).HasPrecision(8);
            entity.Property(e => e.valor_cuotas).HasPrecision(8);
        });

        modelBuilder.Entity<cuentas>(entity =>
        {
            entity.HasKey(e => e.idCuenta).HasName("PRIMARY");

            entity.Property(e => e.cuenta).HasMaxLength(100);
            entity.Property(e => e.numero_cuenta).HasMaxLength(20);
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

        modelBuilder.Entity<detalle_pagos>(entity =>
        {
            entity.HasKey(e => new { e.idPago, e.idEspecie }).HasName("PRIMARY");

            entity.HasIndex(e => e.idEspecie, "R_36");

            entity.Property(e => e.descuento).HasPrecision(8);
            entity.Property(e => e.fechaMigracion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
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

        modelBuilder.Entity<discapacidades>(entity =>
        {
            entity.HasKey(e => e.idDiscapacidad).HasName("PRIMARY");

            entity.Property(e => e.discapacidad).HasMaxLength(30);
            entity.Property(e => e.esDefecto).HasDefaultValueSql("'0'");
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

        modelBuilder.Entity<especies>(entity =>
        {
            entity.HasKey(e => e.idEspecie).HasName("PRIMARY");

            entity.Property(e => e.codigo_referencia).HasMaxLength(10);
            entity.Property(e => e.especie).HasMaxLength(100);
            entity.Property(e => e.extraordinaria).HasPrecision(8);
            entity.Property(e => e.idNivel).HasDefaultValueSql("'0'");
            entity.Property(e => e.idperiodo).HasMaxLength(7);
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

        modelBuilder.Entity<etnias>(entity =>
        {
            entity.HasKey(e => e.idEtnia).HasName("PRIMARY");

            entity.Property(e => e.etnia).HasMaxLength(30);
            entity.Property(e => e.noRegistra).HasDefaultValueSql("'0'");
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

            entity.Property(e => e.dia).HasMaxLength(15);
            entity.Property(e => e.fecha).HasColumnType("date");
            entity.Property(e => e.finsemana).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<fechas_pagos>(entity =>
        {
            entity.HasKey(e => e.idFecha).HasName("PRIMARY");

            entity.Property(e => e.fecha).HasColumnType("date");
        });

        modelBuilder.Entity<horario_profesores>(entity =>
        {
            entity.HasKey(e => e.idHorario).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.asiste).HasDefaultValueSql("'1'");
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
            entity.Property(e => e.sufijo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<nacionalidades>(entity =>
        {
            entity.HasKey(e => e.idNacionalidad).HasName("PRIMARY");

            entity.Property(e => e.esNinguna).HasDefaultValueSql("'0'");
            entity.Property(e => e.nacionalidad).HasMaxLength(30);
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

        modelBuilder.Entity<parciales>(entity =>
        {
            entity.HasKey(e => e.idParcial).HasName("PRIMARY");

            entity.Property(e => e.Parcial).HasMaxLength(40);
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

        modelBuilder.Entity<periodos>(entity =>
        {
            entity.HasKey(e => e.idPeriodo).HasName("PRIMARY");

            entity.Property(e => e.idPeriodo)
                .HasMaxLength(7)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.detalle).HasMaxLength(100);
            entity.Property(e => e.fecha_final).HasColumnType("date");
            entity.Property(e => e.fecha_inicial).HasColumnType("date");
            entity.Property(e => e.fecha_matrucla_extraordinaria).HasColumnType("date");
            entity.Property(e => e.fecha_maxima_autocierre).HasColumnType("date");
            entity.Property(e => e.ingresoCalificaciones).HasDefaultValueSql("'0'");
            entity.Property(e => e.periodoactivoinstituto).HasDefaultValueSql("'0'");
            entity.Property(e => e.permiteCalificacionesInstituto).HasDefaultValueSql("'0'");
            entity.Property(e => e.permiteMatricula).HasDefaultValueSql("'0'");
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

            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.abreviatura).HasMaxLength(5);
            entity.Property(e => e.apellidos).HasMaxLength(60);
            entity.Property(e => e.celular).HasMaxLength(20);
            entity.Property(e => e.clave)
                .HasMaxLength(20)
                .HasDefaultValueSql("'321'");
            entity.Property(e => e.direccion).HasMaxLength(100);
            entity.Property(e => e.email).HasMaxLength(100);
            entity.Property(e => e.fecha_ingreso).HasColumnType("date");
            entity.Property(e => e.fecha_nacimiento).HasColumnType("date");
            entity.Property(e => e.fecha_retiro).HasColumnType("date");
            entity.Property(e => e.foto).HasMaxLength(100);
            entity.Property(e => e.nacionalidad).HasMaxLength(40);
            entity.Property(e => e.nombres).HasMaxLength(60);
            entity.Property(e => e.practicas).HasDefaultValueSql("'0'");
            entity.Property(e => e.sexo)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.telefono).HasMaxLength(30);
            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'P'")
                .IsFixedLength();
            entity.Property(e => e.tipodocumento)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.titulo).HasMaxLength(200);
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

            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
            entity.Property(e => e.fecha)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.horas_semana).HasDefaultValueSql("'0'");
            entity.Property(e => e.usuario).HasMaxLength(20);
        });

        modelBuilder.Entity<restricciones>(entity =>
        {
            entity.HasKey(e => e.idrestriccion).HasName("PRIMARY");

            entity.Property(e => e.idrestriccion).HasMaxLength(5);
            entity.Property(e => e.activo).HasColumnType("bit(1)");
            entity.Property(e => e.restriccion).HasMaxLength(100);
        });

        modelBuilder.Entity<secciones>(entity =>
        {
            entity.HasKey(e => e.idSeccion).HasName("PRIMARY");

            entity.Property(e => e.seccion).HasMaxLength(30);
            entity.Property(e => e.sufijo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<seddautoevaluacion>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddautoevaluacion)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddautoevaluacion_ibfk_1");
        });

        modelBuilder.Entity<seddautoridadesperiodos>(entity =>
        {
            entity.HasKey(e => e.idAsignacion).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.designacion).HasMaxLength(100);
            entity.Property(e => e.idPeriodo).HasMaxLength(14);
            entity.Property(e => e.idProfesor).HasMaxLength(14);
        });

        modelBuilder.Entity<seddcoevaluacion>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignacion, "idAsignacion");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.fechaTest).HasColumnType("datetime");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idAsignacionNavigation).WithMany(p => p.seddcoevaluacion)
                .HasPrincipalKey(p => p.idAsignacion)
                .HasForeignKey(d => d.idAsignacion)
                .HasConstraintName("seddcoevaluacion_ibfk_2");

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddcoevaluacion)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddcoevaluacion_ibfk_1");
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

        modelBuilder.Entity<sedddetalleevaluacionautoridad>(entity =>
        {
            entity.HasKey(e => e.idDetalle).HasName("PRIMARY");

            entity.HasIndex(e => e.idPregunta, "idPregunta");

            entity.HasIndex(e => e.idTest, "idTest");

            entity.Property(e => e.respuesta).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.idPreguntaNavigation).WithMany(p => p.sedddetalleevaluacionautoridad)
                .HasForeignKey(d => d.idPregunta)
                .HasConstraintName("sedddetalleevaluacionautoridad_ibfk_1");

            entity.HasOne(d => d.idTestNavigation).WithMany(p => p.sedddetalleevaluacionautoridad)
                .HasForeignKey(d => d.idTest)
                .HasConstraintName("sedddetalleevaluacionautoridad_ibfk_2");
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

        modelBuilder.Entity<seddevaluacionautoridad>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.fechaTest).HasColumnType("datetime");
            entity.Property(e => e.idAutoridad).HasMaxLength(14);
            entity.Property(e => e.idPeriodo).HasMaxLength(7);
            entity.Property(e => e.idProfesor).HasMaxLength(14);

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddevaluacionautoridad)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddevaluacionautoridad_ibfk_1");
        });

        modelBuilder.Entity<seddheteroevaluacion>(entity =>
        {
            entity.HasKey(e => e.idTest).HasName("PRIMARY");

            entity.HasIndex(e => e.idAsignacion, "idAsignacion");

            entity.HasIndex(e => e.idInstrumento, "idInstrumento");

            entity.HasIndex(e => e.idMatricula, "idMatricula");

            entity.Property(e => e.fechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.idPeriodo).HasMaxLength(7);

            entity.HasOne(d => d.idAsignacionNavigation).WithMany(p => p.seddheteroevaluacion)
                .HasPrincipalKey(p => p.idAsignacion)
                .HasForeignKey(d => d.idAsignacion)
                .HasConstraintName("seddheteroevaluacion_ibfk_2");

            entity.HasOne(d => d.idInstrumentoNavigation).WithMany(p => p.seddheteroevaluacion)
                .HasForeignKey(d => d.idInstrumento)
                .HasConstraintName("seddheteroevaluacion_ibfk_1");

            entity.HasOne(d => d.idMatriculaNavigation).WithMany(p => p.seddheteroevaluacion)
                .HasForeignKey(d => d.idMatricula)
                .HasConstraintName("seddheteroevaluacion_ibfk_3");
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
            entity.Property(e => e.pregunta).HasMaxLength(100);
        });

        modelBuilder.Entity<sistema_titulacion>(entity =>
        {
            entity.HasKey(e => e.codigo_sistema).HasName("PRIMARY");

            entity.Property(e => e.activo).HasDefaultValueSql("'1'");
            entity.Property(e => e.detalle).HasMaxLength(100);
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

            entity.Property(e => e.activa).HasDefaultValueSql("'1'");
            entity.Property(e => e.esDocencia).HasDefaultValueSql("'0'");
            entity.Property(e => e.subcategoria).HasMaxLength(200);
        });

        modelBuilder.Entity<tiposdocumentosi>(entity =>
        {
            entity.HasKey(e => e.tipoDocumento).HasName("PRIMARY");

            entity.Property(e => e.tipoDocumento).HasMaxLength(1);
            entity.Property(e => e.documento).HasMaxLength(20);
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

        modelBuilder.Entity<usuarios_web>(entity =>
        {
            entity.HasKey(e => e.usuario).HasName("PRIMARY");

            entity.Property(e => e.usuario).HasMaxLength(20);
            entity.Property(e => e.activo).HasDefaultValueSql("'0'");
            entity.Property(e => e.asistencia).HasDefaultValueSql("'0'");
            entity.Property(e => e.ingreso).HasDefaultValueSql("'0'");
            entity.Property(e => e.password).HasMaxLength(20);
            entity.Property(e => e.salida).HasDefaultValueSql("'0'");
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
