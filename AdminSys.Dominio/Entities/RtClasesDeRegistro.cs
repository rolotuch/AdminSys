using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtClasesDeRegistro
{
    public long Tid { get; set; }

    public string ClaseDeRegistro { get; set; } = null!;

    public string? Descripcion { get; set; }

    public long Tabla { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }
}
