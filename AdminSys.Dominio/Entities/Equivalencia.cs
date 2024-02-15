using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Equivalencia
{
    public string Frase { get; set; } = null!;

    public string? Equivalencia1 { get; set; }

    public string? TipoFrase { get; set; }
}
