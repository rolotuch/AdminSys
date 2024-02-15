using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdUnidadesAdministrativa
{
    public byte UnidadAdministrativa { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Maa { get; set; }

    public string Directiva { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public string Siglas { get; set; } = null!;
}
