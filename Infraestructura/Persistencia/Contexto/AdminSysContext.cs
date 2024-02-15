using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AdminSys.Infraestructura.Persistencia.Contexto;

public partial class AdminSysContext : DbContext
{
   

    public AdminSysContext(DbContextOptions<AdminSysContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdCamposMatriz> AdCamposMatrizs { get; set; }

    public virtual DbSet<AdCamposOperacionRe> AdCamposOperacionRes { get; set; }

    public virtual DbSet<AdChequesCabecera> AdChequesCabeceras { get; set; }

    public virtual DbSet<AdChequesDetalle> AdChequesDetalles { get; set; }

    public virtual DbSet<AdClasesIdentificadore> AdClasesIdentificadores { get; set; }

    public virtual DbSet<AdColumna> AdColumnas { get; set; }

    public virtual DbSet<AdConsulta> AdConsultas { get; set; }

    public virtual DbSet<AdDefinicionParametro> AdDefinicionParametros { get; set; }

    public virtual DbSet<AdDefwhereFuncion> AdDefwhereFuncions { get; set; }

    public virtual DbSet<AdErrore> AdErrores { get; set; }

    public virtual DbSet<AdFiltro> AdFiltros { get; set; }

    public virtual DbSet<AdFormula> AdFormulas { get; set; }

    public virtual DbSet<AdFuncione> AdFunciones { get; set; }

    public virtual DbSet<AdFuncionesUsuario> AdFuncionesUsuarios { get; set; }

    public virtual DbSet<AdGrant> AdGrants { get; set; }

    public virtual DbSet<AdGrupo> AdGrupos { get; set; }

    public virtual DbSet<AdGruposFuncion> AdGruposFuncions { get; set; }

    public virtual DbSet<AdHuella> AdHuellas { get; set; }

    public virtual DbSet<AdInstanciasOperacion> AdInstanciasOperacions { get; set; }

    public virtual DbSet<AdListasValore> AdListasValores { get; set; }

    public virtual DbSet<AdMapeoObjeto> AdMapeoObjetos { get; set; }

    public virtual DbSet<AdMatrizOperacione> AdMatrizOperaciones { get; set; }

    public virtual DbSet<AdMensajesError> AdMensajesErrors { get; set; }

    public virtual DbSet<AdNoticia> AdNoticias { get; set; }

    public virtual DbSet<AdNumerosEntradum> AdNumerosEntrada { get; set; }

    public virtual DbSet<AdObjeto> AdObjetos { get; set; }

    public virtual DbSet<AdObjetosCierre> AdObjetosCierres { get; set; }

    public virtual DbSet<AdOperacionesRestrictiva> AdOperacionesRestrictivas { get; set; }

    public virtual DbSet<AdParametro> AdParametros { get; set; }

    public virtual DbSet<AdParametrosSistema> AdParametrosSistemas { get; set; }

    public virtual DbSet<AdPerfile> AdPerfiles { get; set; }

    public virtual DbSet<AdPerfilesColumna> AdPerfilesColumnas { get; set; }

    public virtual DbSet<AdPerfilesFuncion> AdPerfilesFuncions { get; set; }

    public virtual DbSet<AdPerfilesUsuario> AdPerfilesUsuarios { get; set; }

    public virtual DbSet<AdPistaOperacionesMe> AdPistaOperacionesMes { get; set; }

    public virtual DbSet<AdPrivilegio> AdPrivilegios { get; set; }

    public virtual DbSet<AdPrivilegiosTipoObjeto> AdPrivilegiosTipoObjetos { get; set; }

    public virtual DbSet<AdRepositorioReporte> AdRepositorioReportes { get; set; }

    public virtual DbSet<AdTempoColumna> AdTempoColumnas { get; set; }

    public virtual DbSet<AdTempoConsulta> AdTempoConsultas { get; set; }

    public virtual DbSet<AdTempoFiltro> AdTempoFiltros { get; set; }

    public virtual DbSet<AdTempoObjeto> AdTempoObjetos { get; set; }

    public virtual DbSet<AdTemporalRowid> AdTemporalRowids { get; set; }

    public virtual DbSet<AdTiposObjeto> AdTiposObjetos { get; set; }

    public virtual DbSet<AdUnidadesAdministrativa> AdUnidadesAdministrativas { get; set; }

    public virtual DbSet<AdUsuario> AdUsuarios { get; set; }

    public virtual DbSet<AdUsuariosGrupo> AdUsuariosGrupos { get; set; }

    public virtual DbSet<Dtproperty> Dtproperties { get; set; }

    public virtual DbSet<Equivalencia> Equivalencias { get; set; }

    public virtual DbSet<MenuFuncione> MenuFunciones { get; set; }

    public virtual DbSet<Metforeignkey> Metforeignkeys { get; set; }

    public virtual DbSet<Orm> Orms { get; set; }

    public virtual DbSet<Prueba> Pruebas { get; set; }

    public virtual DbSet<Prueba1> Prueba1s { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RtCampo> RtCampos { get; set; }

    public virtual DbSet<RtClasesDeRegistro> RtClasesDeRegistros { get; set; }

    public virtual DbSet<RtDominio> RtDominios { get; set; }

    public virtual DbSet<RtEstado> RtEstados { get; set; }

    public virtual DbSet<RtOperacione> RtOperaciones { get; set; }

    public virtual DbSet<RtRegla> RtReglas { get; set; }

    public virtual DbSet<RtSistema> RtSistemas { get; set; }

    public virtual DbSet<RtTabla> RtTablas { get; set; }

    public virtual DbSet<RtTransicione> RtTransiciones { get; set; }

    public virtual DbSet<Secuencia> Secuencias { get; set; }

    public virtual DbSet<Seq> Seqs { get; set; }

    public virtual DbSet<Sequence> Sequences { get; set; }

    public virtual DbSet<SgDetalleBitacora> SgDetalleBitacoras { get; set; }

    public virtual DbSet<SgEncbitacora> SgEncbitacoras { get; set; }

    public virtual DbSet<SgOperacione> SgOperaciones { get; set; }

    public virtual DbSet<SgReporte> SgReportes { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<TempUsuario> TempUsuarios { get; set; }

    public virtual DbSet<TipoReporte> TipoReportes { get; set; }

    public virtual DbSet<Udt> Udts { get; set; }

    public virtual DbSet<VBitacoraFunusu> VBitacoraFunusus { get; set; }

    public virtual DbSet<VwFuncionPerfilObjeto> VwFuncionPerfilObjetos { get; set; }

    public virtual DbSet<VwUsuario> VwUsuarios { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
