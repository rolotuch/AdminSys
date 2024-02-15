using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdDefinicionParametro
{
    public string Parametro { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public long? Longitud { get; set; }

    public long? Decimales { get; set; }

    public string? EtiquetaDefault { get; set; }
}
