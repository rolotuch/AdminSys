using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdErrore
{
    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string Accion { get; set; } = null!;

    public string? Ubicacion { get; set; }
}
