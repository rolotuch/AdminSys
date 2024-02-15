using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class AdConsulta
{
    public string Objeto { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string SelectStatement { get; set; } = null!;

    public string? Tabla { get; set; }

    public long? SecuenciaFetch { get; set; }

    public string? DefaultWhere { get; set; }

    public string? DefaultOrderby { get; set; }

    public string? Multiselect { get; set; }

    public string? TextoParametros { get; set; }

    public string? ObjetoRepositorio { get; set; }

    public string? TablaBase { get; set; }

    public string? LinkExpandir { get; set; }

    public string? UtilizaFormulas { get; set; }

    public string? Paginear { get; set; }

    public string? SelectStatementAux { get; set; }
}
