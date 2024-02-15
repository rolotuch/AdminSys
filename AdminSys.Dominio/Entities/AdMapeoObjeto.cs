using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdMapeoObjeto
{
    public string ObjetoInicial { get; set; } = null!;

    public string ObjetoFinal { get; set; } = null!;

    public string? Restrictiva { get; set; }
}
