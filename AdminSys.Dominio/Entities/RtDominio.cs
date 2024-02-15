using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtDominio
{
    public long Tid { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? MeClase { get; set; }

    public string? MeEstado { get; set; }

    public string? MeOperacion { get; set; }

    public string? Tipo { get; set; }

    public string? Longitud { get; set; }
}
