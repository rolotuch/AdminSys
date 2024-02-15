using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtOperacione
{
    public long Tid { get; set; }

    public string Operacion { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Notas { get; set; }

    public string Detabla { get; set; } = null!;

    public long? Tabla { get; set; }

    public long? ClaseDeRegistro { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }
}
