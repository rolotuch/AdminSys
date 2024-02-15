using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class SgEncbitacora
{
    public int IdEnc { get; set; }

    public string? NombreTabla { get; set; }

    public string? Operacion { get; set; }

    public string? LlaveFila { get; set; }

    public string? CamposPk { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdOperacion { get; set; }

    public string? UsuarioBdd { get; set; }
}
