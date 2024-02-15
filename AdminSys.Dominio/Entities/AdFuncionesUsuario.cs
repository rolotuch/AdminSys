using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdFuncionesUsuario
{
    public string Usuario { get; set; } = null!;

    public long Funcion { get; set; }

    public string? Restrictiva { get; set; }

    public virtual AdFuncione FuncionNavigation { get; set; } = null!;
}
