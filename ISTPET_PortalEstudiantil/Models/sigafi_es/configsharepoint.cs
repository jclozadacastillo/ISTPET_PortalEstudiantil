using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class configsharepoint
{
    public int idSharePoint { get; set; }

    public string ClientID { get; set; } = null!;

    public string TenanID { get; set; } = null!;

    public string ClientSecret { get; set; } = null!;

    public string AppID { get; set; } = null!;

    public string RedirectURL { get; set; } = null!;

    public string TenantName { get; set; } = null!;

    public string SiteName { get; set; } = null!;

    public string SiteID { get; set; } = null!;

    public string ListID { get; set; } = null!;

    public string DriveID { get; set; } = null!;

    public sbyte? esActivo { get; set; }

    public DateTime? FechaCreado { get; set; }

    public DateTime? FechaActualizado { get; set; }

    public string? correo { get; set; }

    public string? password { get; set; }
}
