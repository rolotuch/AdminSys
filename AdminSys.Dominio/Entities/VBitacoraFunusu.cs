using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class VBitacoraFunusu
{
    public string Usuario { get; set; } = null!;

    public string? U { get; set; }

    public string Nombre { get; set; } = null!;

    public string? MeEstado { get; set; }

    public long? CodigoGrupo { get; set; }

    public string? Grupo { get; set; }

    public decimal? CodigoFuncion { get; set; }

    public string Funcion { get; set; } = null!;

    public string? Operacion { get; set; }

    public string? UsuarioAsigna { get; set; }

    public DateTime? FechaOperacion { get; set; }
}
