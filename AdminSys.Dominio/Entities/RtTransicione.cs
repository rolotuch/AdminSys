using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtTransicione
{
    public long Tid { get; set; }

    public long Operacion { get; set; }

    public long EstadoInicial { get; set; }

    public long EstadoFinal { get; set; }

    public string Automatica { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }
}
