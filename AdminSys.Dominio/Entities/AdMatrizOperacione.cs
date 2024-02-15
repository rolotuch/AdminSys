using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdMatrizOperacione
{
    public byte IdMatriz { get; set; }

    public string Objeto { get; set; } = null!;

    public string? ClaseRegistro { get; set; }

    public string? ClaseModificacion { get; set; }

    public string? ClaseGrupo { get; set; }

    public string? Descripcion { get; set; }

    public string Directiva { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public string? Modo { get; set; }
}
