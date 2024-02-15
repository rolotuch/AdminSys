using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class SgReporte
{
    public string? Reporte { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Usuario { get; set; }

    public string? Filtro { get; set; }
}
