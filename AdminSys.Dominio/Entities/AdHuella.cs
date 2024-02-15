using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdHuella
{
    public string Usuario { get; set; } = null!;

    public string FirmaDactilar { get; set; } = null!;
}
