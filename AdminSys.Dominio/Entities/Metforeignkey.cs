using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Metforeignkey
{
    public int Idfk { get; set; }

    public short? Keyno { get; set; }

    public string ForeignKeyName { get; set; } = null!;

    public string ChildTable { get; set; } = null!;

    public string? ChildColumn { get; set; }

    public string ParentTable { get; set; } = null!;

    public string? ParentColumn { get; set; }
}
