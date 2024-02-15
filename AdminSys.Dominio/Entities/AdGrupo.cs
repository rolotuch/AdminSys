using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdGrupo
{
    public long Grupo { get; set; }

    public string? Descripcion { get; set; }

    public string? Directiva { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecIng { get; set; }

    public string? UseridIng { get; set; }

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public virtual ICollection<AdGruposFuncion> AdGruposFuncions { get; set; } = new List<AdGruposFuncion>();

    public virtual ICollection<AdUsuario> AdUsuarios { get; set; } = new List<AdUsuario>();
}
