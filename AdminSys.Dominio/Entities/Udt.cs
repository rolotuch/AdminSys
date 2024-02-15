using System;
using System.Collections.Generic;

namespace AdminSys.Dominio.Entities;

public partial class Udt
{
    public byte[]? Firma { get; set; }

    public string? DNotas { get; set; }

    public DateTime? FechaCorta { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? TipoContribuyente { get; set; }

    public byte? Mes { get; set; }

    public byte? Zona { get; set; }

    public byte? UnidadMedida { get; set; }

    public bool? Trimestre { get; set; }

    public byte? TipoPresupuesto { get; set; }

    public byte? TipoPersonal { get; set; }

    public byte? TipoFianza { get; set; }

    public byte? TipoDocumento { get; set; }

    public bool? TipoCuenta { get; set; }

    public byte? TipoContrato { get; set; }

    public decimal? TasaCambio { get; set; }

    public byte? Sucursal { get; set; }

    public byte? Subprograma { get; set; }

    public byte? Subcuenta { get; set; }

    public byte? Signo { get; set; }

    public bool? Semana { get; set; }

    public int? Secuencia { get; set; }

    public byte? Sector { get; set; }

    public byte? Region { get; set; }

    public byte? RecursoAux { get; set; }

    public short? Recurso { get; set; }

    public byte? Recaudacion { get; set; }

    public byte? Proyecto { get; set; }

    public byte? Programa { get; set; }

    public int? PartidaAux { get; set; }

    public byte? Partida { get; set; }

    public byte? Pais { get; set; }

    public byte? OrigenCuenta { get; set; }

    public int? Organismo { get; set; }

    public byte? OperacionBanco { get; set; }

    public byte? NumeroCorto { get; set; }

    public int? Numero { get; set; }

    public long? NoRespaldo { get; set; }

    public int? NoOriginal { get; set; }

    public byte? NoMatriz { get; set; }

    public int? NoFondo { get; set; }

    public int? NoEntrada { get; set; }

    public long? NoDeposito { get; set; }

    public int? NoCur { get; set; }

    public int? NoCriterio { get; set; }

    public bool? NivelInstitucional { get; set; }

    public bool? NivelEstructura { get; set; }

    public decimal? Monto { get; set; }

    public byte? Moneda { get; set; }

    public byte? Meta { get; set; }

    public byte? Mayor { get; set; }

    public short? GrupoIngreso { get; set; }

    public byte? GrupoGasto { get; set; }

    public byte? Geografico { get; set; }

    public byte? Funcion { get; set; }

    public byte? Fuente { get; set; }

    public byte? FormaPago { get; set; }

    public byte? ErrorHoja { get; set; }

    public int? EntidadReceptora { get; set; }

    public int? Entidad { get; set; }

    public byte? Ejercicio { get; set; }

    public int? Economico { get; set; }

    public long? DisposicionLegal { get; set; }

    public byte? Dia { get; set; }

    public long? Deuda { get; set; }

    public byte? Deduccion { get; set; }

    public long? DLlave { get; set; }

    public byte? Cuenta { get; set; }

    public byte? Concepto { get; set; }

    public byte? ClaseCorrespondencia { get; set; }

    public byte? ClaseContrato { get; set; }

    public byte? ClaseAux { get; set; }

    public int? Categoria { get; set; }

    public decimal? Cantidad { get; set; }

    public byte? Banco { get; set; }

    public short? Aspecto { get; set; }

    public byte? Actobra { get; set; }

    public string? Usuario { get; set; }

    public string? TotalDetalle { get; set; }

    public string? TipoValor { get; set; }

    public string? TipoCategoria { get; set; }

    public string? Telefono { get; set; }

    public string? Sino { get; set; }

    public string? Sigla { get; set; }

    public string? SiProyecto { get; set; }

    public string? SiCuenta { get; set; }

    public string? RegimenIva { get; set; }

    public string? Observaciones { get; set; }

    public string? Objetivos { get; set; }

    public string? Nombre { get; set; }

    public string? NoFactura { get; set; }

    public string? NoComprobante { get; set; }

    public string? Nit { get; set; }

    public string? MeOperacion { get; set; }

    public string? MeEstado { get; set; }

    public string? MeClase { get; set; }

    public string? LugarGasto { get; set; }

    public string? Instancia { get; set; }

    public string? IngresoGasto { get; set; }

    public string? GrupoCuenta { get; set; }

    public string? GastoIngreso { get; set; }

    public string? Factura { get; set; }

    public string? EstadoFondo { get; set; }

    public string? EstadoFiscal { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public string? Descripcion { get; set; }

    public string? DebitoCredito { get; set; }

    public string? DTipoDato { get; set; }

    public string? DSistema { get; set; }

    public string? DSinonimo { get; set; }

    public string? DSino { get; set; }

    public string? DOperacion { get; set; }

    public string? DNombreMedio { get; set; }

    public string? DNombreCorto { get; set; }

    public string? DLongitud { get; set; }

    public string? DEstado { get; set; }

    public string? DDescripcionMedia { get; set; }

    public string? DDescripcionCorta { get; set; }

    public string? DClase { get; set; }

    public string? CuentaMonetaria { get; set; }

    public string? Contenido { get; set; }

    public string? ClaseRegistro { get; set; }

    public string? ClaseModificacion { get; set; }

    public string? ClaseGrupo { get; set; }

    public string? Caif { get; set; }

    public string? AumentoDisminucion { get; set; }
}
