using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdPerfilesColumna
{
    public long IdColumna { get; set; }

    public string Perfil { get; set; } = null!;

    public string VerificaEstado { get; set; } = null!;
}
