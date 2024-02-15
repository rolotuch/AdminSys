using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdDefwhereFuncion
{
    public string Objeto { get; set; } = null!;

    public long Funcion { get; set; }

    public string DefaultWhere { get; set; } = null!;

    public virtual AdObjeto ObjetoNavigation { get; set; } = null!;
}
