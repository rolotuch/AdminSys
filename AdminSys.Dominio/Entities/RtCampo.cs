using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtCampo
{
    public long Tid { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? TipoDato { get; set; }

    public long? Dominio { get; set; }

    public string? Longitud { get; set; }

    public string? Obligatorio { get; set; }

    public long Tabla { get; set; }

    public string? Directiva { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public string? Llave { get; set; }

    public string? TipoControl { get; set; }
}
