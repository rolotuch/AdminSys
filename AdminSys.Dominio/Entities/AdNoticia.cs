using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdNoticia
{
    public DateTime FechaInicioVigencia { get; set; }

    public DateTime? FechaFinVigencia { get; set; }

    public string De { get; set; } = null!;

    public string Para { get; set; } = null!;

    public string Asunto { get; set; } = null!;

    public string? Prioridad { get; set; }

    public string Contenido { get; set; } = null!;

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }
}
