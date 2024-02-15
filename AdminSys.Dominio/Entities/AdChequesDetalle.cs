using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdChequesDetalle
{
    public long Entidad { get; set; }

    public long UnidadEjecutora { get; set; }

    public long UnidadDesconcentrada { get; set; }

    public string CuentaPagadora { get; set; } = null!;

    public long Correlativo { get; set; }

    public string NombreCampo { get; set; } = null!;

    public long OrdenCampo { get; set; }

    public long Fila { get; set; }

    public long Columna { get; set; }

    public string SeImprime { get; set; } = null!;

    public string? Tabla { get; set; }

    public string? CampoTabla { get; set; }

    public string? ValorDefault { get; set; }

    public string? Mascara { get; set; }

    public string Condensado { get; set; } = null!;
}
