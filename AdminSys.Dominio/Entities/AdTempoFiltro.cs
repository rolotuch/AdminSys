using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdTempoFiltro
{
    public string Objeto { get; set; } = null!;

    public long Campo { get; set; }

    public string? Directiva { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecIng { get; set; }

    public string? UseridIng { get; set; }

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }
}
