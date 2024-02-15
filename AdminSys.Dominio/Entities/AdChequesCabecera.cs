using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdChequesCabecera
{
    public long Entidad { get; set; }

    public long UnidadEjecutora { get; set; }

    public long UnidadDesconcentrada { get; set; }

    public string CuentaPagadora { get; set; } = null!;

    public long Correlativo { get; set; }

    public string TipoImpresora { get; set; } = null!;

    public long CantidadLineas { get; set; }

    public long CaracteresLinea { get; set; }

    public string Restrictiva { get; set; } = null!;
}
