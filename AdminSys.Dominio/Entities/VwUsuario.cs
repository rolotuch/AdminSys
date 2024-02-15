using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class VwUsuario
{
    public string? Usuario { get; set; }

    public string? Password { get; set; }

    public string? Nombre { get; set; }

    public string? Puesto { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Nit { get; set; }

    public DateTime? FecUltLogin { get; set; }

    public byte? Institucion { get; set; }

    public string? NombreInstitucion { get; set; }

    public int? Entidad { get; set; }

    public byte? UnidadEjecutora { get; set; }
}
