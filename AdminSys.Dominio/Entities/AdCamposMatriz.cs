using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdCamposMatriz
{
    public long Llave { get; set; }

    public string Objeto { get; set; } = null!;

    public string ValorCampo { get; set; } = null!;

    public string TipoCampo { get; set; } = null!;

    public string Etiqueta { get; set; } = null!;

    public string? PredicadoJoin { get; set; }

    public string? TablaCampo { get; set; }

    public string? TablaJoin { get; set; }

    public string? CodigoCampo { get; set; }
}
