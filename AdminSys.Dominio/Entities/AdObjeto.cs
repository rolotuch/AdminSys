using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdObjeto
{
    public string Objeto { get; set; } = null!;

    public string NombreLogico { get; set; } = null!;

    public string? NombreFisico { get; set; }

    public string? Etiqueta { get; set; }

    public string? ObjetoPadre { get; set; }

    public short? TipoObjeto { get; set; }

    public byte Nivel { get; set; }

    public string? Numeracion { get; set; }

    public int? OrdenTabulacion { get; set; }

    public string? ImagenBotonArriba { get; set; }

    public string? ImagenBotonSobre { get; set; }

    public string? Directiva { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecIng { get; set; }

    public string? UseridIng { get; set; }

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public string? AmbienteDesarrollo { get; set; }

    public virtual ICollection<AdDefwhereFuncion> AdDefwhereFuncions { get; set; } = new List<AdDefwhereFuncion>();

    public virtual ICollection<AdObjeto> InverseObjetoPadreNavigation { get; set; } = new List<AdObjeto>();

    public virtual AdObjeto? ObjetoPadreNavigation { get; set; }

    public virtual AdTiposObjeto? TipoObjetoNavigation { get; set; }
}
