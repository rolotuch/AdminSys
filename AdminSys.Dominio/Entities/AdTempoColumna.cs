using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdTempoColumna
{
    public string Objeto { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Datafield { get; set; } = null!;

    public string HeaderText { get; set; } = null!;

    public long? TabIndex { get; set; }

    public string TipoDato { get; set; } = null!;

    public string? CampoLlave { get; set; }

    public string? Datalist { get; set; }

    public string? ExcluirGrid { get; set; }

    public string? MostrarFiltro { get; set; }

    public long? Longitud { get; set; }

    public long? Decimales { get; set; }

    public string? PermitirInsert { get; set; }

    public string? PermitirUpdate { get; set; }

    public string? Sumarizable { get; set; }

    public string? EditableGrid { get; set; }

    public long? Width { get; set; }

    public long? Height { get; set; }

    public long? WidthEtiqueta { get; set; }

    public long? HeightEtiqueta { get; set; }

    public string? ValorInicial { get; set; }

    public string? AgregarParametro { get; set; }
}
