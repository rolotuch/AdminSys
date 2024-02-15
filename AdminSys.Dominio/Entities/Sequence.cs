using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Sequence
{
    public string Seq { get; set; } = null!;

    public int? SequenceId { get; set; }
}
