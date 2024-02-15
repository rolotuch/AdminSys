using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdPrivilegio
{
    public int Privilegio { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Sentencia { get; set; } = null!;

    public string? Generable { get; set; }

    public string Directiva { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public DateTime? UseridAct { get; set; }

    public virtual ICollection<AdGrant> AdGrants { get; set; } = new List<AdGrant>();
}
