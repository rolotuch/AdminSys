using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Reporte
{
    public int Codrep { get; set; }

    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }
}
