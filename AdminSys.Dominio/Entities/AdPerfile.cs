using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdPerfile
{
    public string Perfil { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public byte Nivel { get; set; }

    public string? PerfilPadre { get; set; }

    public string? TipoPerfil { get; set; }

    public string? ObjetoRaiz { get; set; }

    public string PerfilAdministrativo { get; set; } = null!;

    public string? Directiva { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecIng { get; set; }

    public string? UseridIng { get; set; }

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public virtual ICollection<AdGrant> AdGrants { get; set; } = new List<AdGrant>();
}
