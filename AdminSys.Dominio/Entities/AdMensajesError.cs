using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdMensajesError
{
    public string Prefijo { get; set; } = null!;

    public int Numero { get; set; }

    public string? Mensaje { get; set; }

    public string? Accion { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }
}
