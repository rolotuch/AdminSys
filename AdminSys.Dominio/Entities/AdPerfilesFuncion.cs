using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdPerfilesFuncion
{
    public string Perfil { get; set; } = null!;

    public long Funcion { get; set; }

    public string? Restrictiva { get; set; }

    public string PerfilAplicacion { get; set; } = null!;
}
