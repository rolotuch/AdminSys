using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Secuencia
{
    public string? TipoObjeto { get; set; }

    public long? Anio { get; set; }

    public long? Correlativo { get; set; }
}
