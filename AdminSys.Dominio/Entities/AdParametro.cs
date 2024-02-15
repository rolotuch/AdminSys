using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdParametro
{
    public string Parametro { get; set; } = null!;

    public string Etiqueta { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public long? Longitud { get; set; }

    public long? Decimales { get; set; }
}
