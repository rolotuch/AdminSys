using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Result /*: BaseEntidades*/
{
    public bool NivelEstructura { get; set; }

    public byte Ejercicio { get; set; }

    public int Entidad { get; set; }

    public byte Programa { get; set; }

    public byte Subprograma { get; set; }

    public byte Proyecto { get; set; }

    public byte Actobra { get; set; }

    public string NomEstructura { get; set; } = null!;

    public byte? Funcion { get; set; }

    public string? NoProyecto { get; set; }

    public int? EntidadNs { get; set; }

    public byte? ProgramaNs { get; set; }

    public byte? SubprogramaNs { get; set; }

    public byte? ProyectoNs { get; set; }

    public byte? ActobraNs { get; set; }

    public string? MeClase { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public string Directiva { get; set; } = null!;

    public DateTime FecIng { get; set; }

    public string UseridIng { get; set; } = null!;

    public DateTime? FecAct { get; set; }

    public string? UseridAct { get; set; }

    public byte? ClaseGasto { get; set; }
}
