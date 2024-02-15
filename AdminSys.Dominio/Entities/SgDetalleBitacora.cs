using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class SgDetalleBitacora
{
    public int IdDetalle { get; set; }

    public int? IdEnc { get; set; }

    public string? NombreCampo { get; set; }

    public string? ValorAnterior { get; set; }

    public string? ValorNuevo { get; set; }
}
