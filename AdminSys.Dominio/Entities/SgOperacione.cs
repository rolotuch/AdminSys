using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class SgOperacione
{
    public long IdOperacion { get; set; }

    public string? NombreOperacion { get; set; }

    public string? Descripcion { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public string? UsuarioBdd { get; set; }

    public DateTime? FechaFinOperacion { get; set; }

    public long? TiempoOperacionBdd { get; set; }
}
