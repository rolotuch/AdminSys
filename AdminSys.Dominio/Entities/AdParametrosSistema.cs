using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdParametrosSistema
{
    public string Propietario { get; set; } = null!;

    public string? Titulo { get; set; }

    public string? Institucion { get; set; }

    public string? Pais { get; set; }

    public decimal? TasaImpuesto { get; set; }

    public string? Contexto { get; set; }

    public string? InterfazSeguridad { get; set; }

    public string? GeneradorPredicados { get; set; }

    public string? TablespaceUsuario { get; set; }

    public string? TablespaceTemporal { get; set; }

    public short? DiasNoticiaReciente { get; set; }

    public string? ServidorReportes { get; set; }

    public string? EmailContacto { get; set; }

    public string? ServidorCorreo { get; set; }

    public byte? DiasExpiracionClaves { get; set; }

    public byte? DiasNotifAntesExp { get; set; }
}
