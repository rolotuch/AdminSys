using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdPerfilesUsuario
{
    public string Usuario { get; set; } = null!;

    public string Perfil { get; set; } = null!;

    public string PerfilAplicacion { get; set; } = null!;

    public string Directiva { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }
}
