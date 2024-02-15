using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdGrant
{
    public string Objeto { get; set; } = null!;

    public string Perfil { get; set; } = null!;

    public int Privilegio { get; set; }

    public string? Granteable { get; set; }

    public string Modo { get; set; } = null!;

    public string? Directiva { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecIng { get; set; }

    public string? UseridIng { get; set; }

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public virtual AdPerfile PerfilNavigation { get; set; } = null!;

    public virtual AdPrivilegio PrivilegioNavigation { get; set; } = null!;
}
