using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdTiposObjeto
{
    public short TipoObjeto { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreFisico { get; set; } = null!;

    public string ObjetoBd { get; set; } = null!;

    public string Directiva { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecIng { get; set; }

    public string? UseridIng { get; set; }

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public virtual ICollection<AdObjeto> AdObjetos { get; set; } = new List<AdObjeto>();
}
