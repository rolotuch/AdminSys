using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Seq
{
    public string Secuencia { get; set; } = null!;

    public int? Valor { get; set; }
}
