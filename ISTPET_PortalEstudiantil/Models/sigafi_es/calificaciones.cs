﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ISTPET_PortalEstudiantil.Models.sigafi_es
{
    public partial class calificaciones
    {
        public int idMatricula { get; set; }
        public int idAsignatura { get; set; }
        public int? idNivel { get; set; }
        public string paralelo { get; set; }
        public int? idSeccion { get; set; }
        public int? idModalidad { get; set; }
        public decimal? ef1 { get; set; }
        public decimal? ep1 { get; set; }
        public decimal? nota1 { get; set; }
        public int? faltasi1 { get; set; }
        public int? faltasj1 { get; set; }
        public decimal? ef2 { get; set; }
        public decimal? ep2 { get; set; }
        public decimal? nota2 { get; set; }
        public int? faltasi2 { get; set; }
        public int? faltasj2 { get; set; }
        public decimal? nota3 { get; set; }
        public int? faltasi3 { get; set; }
        public int? faltasj3 { get; set; }
        public decimal? nota4 { get; set; }
        public int? faltasi4 { get; set; }
        public int? faltasj4 { get; set; }
        public decimal? nota5 { get; set; }
        public int? horas_asistidas { get; set; }
        public decimal? remedial_parcial { get; set; }
        public decimal? promedio_parcial { get; set; }
        public decimal? examen { get; set; }
        public decimal? remedial_final { get; set; }
        public decimal? promedio_final { get; set; }
        public decimal? nota_final { get; set; }
        public bool? aprobado { get; set; }
        public bool? remedial { get; set; }
        public string observacion { get; set; }
        public string tipo { get; set; }
        public byte? pierde_faltas { get; set; }

        public virtual asignaturas idAsignaturaNavigation { get; set; }
        public virtual matriculas idMatriculaNavigation { get; set; }
    }
}
