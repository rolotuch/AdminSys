using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtSistema
{
    public long Tid { get; set; }

    public string Sistema { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Dueno { get; set; }

    public long? Supersistema { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }
}
