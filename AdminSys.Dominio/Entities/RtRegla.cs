using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class RtRegla
{
    public decimal Tid { get; set; }

    public decimal? Patron { get; set; }

    public string Regla { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Notas { get; set; }

    public decimal? ReglaContenedora { get; set; }

    public string Origen { get; set; } = null!;

    public string OrigenAutor { get; set; } = null!;

    public string OrigenResponsable { get; set; } = null!;

    public string OrigenFuente { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public string? Accion { get; set; }
}
