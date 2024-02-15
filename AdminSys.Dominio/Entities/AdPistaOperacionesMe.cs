using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdPistaOperacionesMe
{
    public string Usuario { get; set; } = null!;

    public long Operacion { get; set; }

    public DateTime FechaOperacion { get; set; }
}
