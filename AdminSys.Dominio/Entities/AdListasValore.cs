using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdListasValore
{
    public string IdLista { get; set; } = null!;

    public string SqlStatement { get; set; } = null!;

    public string? UsarWebcache { get; set; }

    public string? CargarBajoDemanda { get; set; }

    public string? UsarDiccionario { get; set; }

    public string? Descripcion { get; set; }

    public string? ForzarFiltro { get; set; }
}
