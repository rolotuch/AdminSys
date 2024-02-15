using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdRepositorioReporte
{
    public string? Reporte { get; set; }

    public string? Usuario { get; set; }

    public string? DirectorioReporte { get; set; }

    public DateTime? FechaGeneracion { get; set; }

    public long? DiasPresentacion { get; set; }

    public string? Objeto { get; set; }
}
