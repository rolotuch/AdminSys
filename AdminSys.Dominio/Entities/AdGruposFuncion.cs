using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdGruposFuncion
{
    public long Funcion { get; set; }

    public long Grupo { get; set; }

    public string Restrictiva { get; set; } = null!;

    public virtual AdFuncione FuncionNavigation { get; set; } = null!;

    public virtual AdGrupo GrupoNavigation { get; set; } = null!;
}
