using System;
using System.Collections.Generic;

namespace ISTPET_PortalEstudiantil.Models.sigafi_es;

public partial class rbac_refresh_tokens
{
    public ulong idRefreshToken { get; set; }

    public int idUsuario { get; set; }

    public string tokenHash { get; set; } = null!;

    public string? deviceInfo { get; set; }

    public string? ipAddress { get; set; }

    public DateTime createdAt { get; set; }

    public DateTime expiresAt { get; set; }

    public DateTime? revokedAt { get; set; }

    public ulong? replacedByTokenId { get; set; }

    public string? familyId { get; set; }

    public uint? sequence { get; set; }

    public string? revokedReason { get; set; }

    public virtual usuarios idUsuarioNavigation { get; set; } = null!;
}
