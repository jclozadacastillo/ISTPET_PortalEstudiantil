using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class usuarios
{
    public int idUsuario { get; set; }

    /// <summary>
    /// este es idSifafi\n
    /// </summary>
    public string idSigafi { get; set; } = null!;

    public string tablaSigafi { get; set; } = null!;

    public string? nombre { get; set; }

    public string contrasenia { get; set; } = null!;

    public sbyte activo { get; set; }

    public sbyte administrador { get; set; }

    public string? emailInstitucional { get; set; }

    public sbyte emailValidado { get; set; }

    public string? hashEmailToken { get; set; }

    public DateTime? fechaEmailValidacion { get; set; }

    public virtual ICollection<asignaciones_vacaciones> asignaciones_vacaciones { get; set; } = new List<asignaciones_vacaciones>();

    public virtual ICollection<bien_apoyo_financiero> bien_apoyo_financiero { get; set; } = new List<bien_apoyo_financiero>();

    public virtual ICollection<bien_postulacion_requisitos_becas> bien_postulacion_requisitos_becas { get; set; } = new List<bien_postulacion_requisitos_becas>();

    public virtual ICollection<bien_postulaciones_becas> bien_postulaciones_becas { get; set; } = new List<bien_postulaciones_becas>();

    public virtual ICollection<bien_resoluciones_tribunales> bien_resoluciones_tribunales { get; set; } = new List<bien_resoluciones_tribunales>();

    public virtual bien_tribunal? bien_tribunal { get; set; }

    public virtual ICollection<cierres_colectivos> cierres_colectivos { get; set; } = new List<cierres_colectivos>();

    public virtual ICollection<gest_password_resets> gest_password_resets { get; set; } = new List<gest_password_resets>();

    public virtual ICollection<kardex_vacaciones> kardex_vacaciones { get; set; } = new List<kardex_vacaciones>();

    public virtual ICollection<permisos> permisos { get; set; } = new List<permisos>();

    public virtual ICollection<planificacion_vacaciones> planificacion_vacacionesusuario_autorizoNavigation { get; set; } = new List<planificacion_vacaciones>();

    public virtual ICollection<planificacion_vacaciones> planificacion_vacacionesusuario_creoNavigation { get; set; } = new List<planificacion_vacaciones>();

    public virtual ICollection<rbac_refresh_tokens> rbac_refresh_tokens { get; set; } = new List<rbac_refresh_tokens>();

    public virtual ICollection<rbac_usuario_rol> rbac_usuario_rol { get; set; } = new List<rbac_usuario_rol>();

    public virtual ICollection<recuperacion_tiempo> recuperacion_tiempo { get; set; } = new List<recuperacion_tiempo>();

    public virtual ICollection<solicitudes_licencias> solicitudes_licencias { get; set; } = new List<solicitudes_licencias>();

    public virtual ICollection<solicitudes_vacaciones> solicitudes_vacacionesusuario_rlNavigation { get; set; } = new List<solicitudes_vacaciones>();

    public virtual ICollection<solicitudes_vacaciones> solicitudes_vacacionesusuario_thNavigation { get; set; } = new List<solicitudes_vacaciones>();

    public virtual ICollection<vacaciones_ledger> vacaciones_ledger { get; set; } = new List<vacaciones_ledger>();
}
