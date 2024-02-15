using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Temp
{
    public string Usuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Puesto { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Ubicacion { get; set; }

    public string? Direccion { get; set; }

    public string Directiva { get; set; } = null!;

    public DateTime? UltFecCambioClave { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public DateTime? FecUltLogin { get; set; }

    public byte? EstadoLogin { get; set; }

    public string? Password { get; set; }

    public long? Grupo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string SesionMultiple { get; set; } = null!;

    public string? CambiaClave { get; set; }

    public string? Email { get; set; }

    public string? UsuarioSupervisa { get; set; }

    public string? Nit { get; set; }

    public byte? AccesoSistemas { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public string? RespaldoEgreso { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? ResponsableSuperior { get; set; }

    public string? PuestoResponsable { get; set; }

    public long? UnidadAdministrativa { get; set; }
}
