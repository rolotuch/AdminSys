using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class VwFuncionPerfilObjeto
{
    public long Funcion { get; set; }

    public string NombreFuncion { get; set; } = null!;

    public string Perfil { get; set; } = null!;

    public string NombrePerfil { get; set; } = null!;

    public string Objeto { get; set; } = null!;

    public string NombreLogico { get; set; } = null!;
}
