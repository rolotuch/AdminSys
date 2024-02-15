using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdFuncione
{
    public long Funcion { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Restrictiva { get; set; }

    public string? EjecucionFormulacion { get; set; }

    public string? Historico { get; set; }

    public string? Regularizacion { get; set; }

    public string? TipoFuncion { get; set; }

    public virtual ICollection<AdFuncionesUsuario> AdFuncionesUsuarios { get; set; } = new List<AdFuncionesUsuario>();

    public virtual ICollection<AdGruposFuncion> AdGruposFuncions { get; set; } = new List<AdGruposFuncion>();
}
