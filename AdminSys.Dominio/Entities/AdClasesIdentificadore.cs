using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdClasesIdentificadore
{
    public string Mnemonico { get; set; } = null!;

    public string Clase { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Directiva { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }
}
