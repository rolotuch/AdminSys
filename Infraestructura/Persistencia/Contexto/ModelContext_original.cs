using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdminSys.Dominio.Entities;

public partial class ModelContext_original : DbContext
{
    public ModelContext_original()
    {
    }

    public ModelContext_original(DbContextOptions<ModelContext_original> options)
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("Data Source=172.18.28.233:1521/PDBDESA;Password=RRHHMD_TEST;User ID=RRHHMD_TEST;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("RRHHMD_TEST")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<AdCamposMatriz>(entity =>
        {
            entity.HasKey(e => e.Llave);

            entity.ToTable("AD_CAMPOS_MATRIZ");

            entity.Property(e => e.Llave)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("LLAVE");
            entity.Property(e => e.CodigoCampo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CAMPO");
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA");
            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.PredicadoJoin)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PREDICADO_JOIN");
            entity.Property(e => e.TablaCampo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TABLA_CAMPO");
            entity.Property(e => e.TablaJoin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TABLA_JOIN");
            entity.Property(e => e.TipoCampo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIPO_CAMPO");
            entity.Property(e => e.ValorCampo)
                .HasColumnType("CLOB")
                .HasColumnName("VALOR_CAMPO");
        });

        modelBuilder.Entity<AdCamposOperacionRe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_CAMPOS_OPERACION_RES");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdChequesCabecera>(entity =>
        {
            entity.HasKey(e => new { e.Entidad, e.UnidadEjecutora, e.UnidadDesconcentrada, e.CuentaPagadora, e.Correlativo });

            entity.ToTable("AD_CHEQUES_CABECERA");

            entity.Property(e => e.Entidad)
                .HasPrecision(18)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.UnidadEjecutora)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_EJECUTORA");
            entity.Property(e => e.UnidadDesconcentrada)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_DESCONCENTRADA");
            entity.Property(e => e.CuentaPagadora)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CUENTA_PAGADORA");
            entity.Property(e => e.Correlativo)
                .HasPrecision(18)
                .HasColumnName("CORRELATIVO");
            entity.Property(e => e.CantidadLineas)
                .HasPrecision(18)
                .HasColumnName("CANTIDAD_LINEAS");
            entity.Property(e => e.CaracteresLinea)
                .HasPrecision(18)
                .HasColumnName("CARACTERES_LINEA");
            entity.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .HasColumnName("RESTRICTIVA");
            entity.Property(e => e.TipoImpresora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPRESORA");
        });

        modelBuilder.Entity<AdChequesDetalle>(entity =>
        {
            entity.HasKey(e => new { e.Entidad, e.UnidadEjecutora, e.UnidadDesconcentrada, e.CuentaPagadora, e.Correlativo, e.NombreCampo });

            entity.ToTable("AD_CHEQUES_DETALLE");

            entity.Property(e => e.Entidad)
                .HasPrecision(18)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.UnidadEjecutora)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_EJECUTORA");
            entity.Property(e => e.UnidadDesconcentrada)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_DESCONCENTRADA");
            entity.Property(e => e.CuentaPagadora)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CUENTA_PAGADORA");
            entity.Property(e => e.Correlativo)
                .HasPrecision(18)
                .HasColumnName("CORRELATIVO");
            entity.Property(e => e.NombreCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CAMPO");
            entity.Property(e => e.CampoTabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAMPO_TABLA");
            entity.Property(e => e.Columna)
                .HasPrecision(18)
                .HasColumnName("COLUMNA");
            entity.Property(e => e.Condensado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'S' ")
                .HasColumnName("CONDENSADO");
            entity.Property(e => e.Fila)
                .HasPrecision(18)
                .HasColumnName("FILA");
            entity.Property(e => e.Mascara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MASCARA");
            entity.Property(e => e.OrdenCampo)
                .HasPrecision(18)
                .HasColumnName("ORDEN_CAMPO");
            entity.Property(e => e.SeImprime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'S' ")
                .HasColumnName("SE_IMPRIME");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            entity.Property(e => e.ValorDefault)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("VALOR_DEFAULT");
        });

        modelBuilder.Entity<AdClasesIdentificadore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_CLASES_IDENTIFICADORES");

            entity.Property(e => e.Clase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Mnemonico)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MNEMONICO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdColumna>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Alias, e.Datafield });

            entity.ToTable("AD_COLUMNAS");

            entity.HasIndex(e => new { e.Objeto, e.Alias }, "IX_AD_COLUMNAS");

            entity.HasIndex(e => e.Objeto, "IX_AD_COLUMNAS_1");

            entity.HasIndex(e => e.Datafield, "IX_AD_COLUMNAS_2");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.Datafield)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATAFIELD");
            entity.Property(e => e.AgregarParametro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AGREGAR_PARAMETRO");
            entity.Property(e => e.CampoLlave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAMPO_LLAVE");
            entity.Property(e => e.Datalist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATALIST");
            entity.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            entity.Property(e => e.EditableGrid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EDITABLE_GRID");
            entity.Property(e => e.ExcluirGrid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EXCLUIR_GRID");
            entity.Property(e => e.HeaderText)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("HEADER_TEXT");
            entity.Property(e => e.Height)
                .HasPrecision(18)
                .HasColumnName("HEIGHT");
            entity.Property(e => e.HeightEtiqueta)
                .HasPrecision(18)
                .HasColumnName("HEIGHT_ETIQUETA");
            entity.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.MostrarFiltro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MOSTRAR_FILTRO");
            entity.Property(e => e.PermitirInsert)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERMITIR_INSERT");
            entity.Property(e => e.PermitirUpdate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERMITIR_UPDATE");
            entity.Property(e => e.Sumarizable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUMARIZABLE");
            entity.Property(e => e.TabIndex)
                .HasPrecision(18)
                .HasColumnName("TAB_INDEX");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
            entity.Property(e => e.ValorInicial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VALOR_INICIAL");
            entity.Property(e => e.Width)
                .HasPrecision(18)
                .HasColumnName("WIDTH");
            entity.Property(e => e.WidthEtiqueta)
                .HasPrecision(18)
                .HasColumnName("WIDTH_ETIQUETA");
        });

        modelBuilder.Entity<AdConsulta>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Alias });

            entity.ToTable("AD_CONSULTAS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Alias)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.DefaultOrderby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_ORDERBY");
            entity.Property(e => e.DefaultWhere)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_WHERE");
            entity.Property(e => e.LinkExpandir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LINK_EXPANDIR");
            entity.Property(e => e.Multiselect)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MULTISELECT");
            entity.Property(e => e.ObjetoRepositorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBJETO_REPOSITORIO");
            entity.Property(e => e.Paginear)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PAGINEAR");
            entity.Property(e => e.SecuenciaFetch)
                .HasPrecision(18)
                .HasColumnName("SECUENCIA_FETCH");
            entity.Property(e => e.SelectStatement)
                .HasColumnType("CLOB")
                .HasColumnName("SELECT_STATEMENT");
            entity.Property(e => e.SelectStatementAux)
                .HasColumnType("CLOB")
                .HasColumnName("SELECT_STATEMENT_AUX");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            entity.Property(e => e.TablaBase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA_BASE");
            entity.Property(e => e.TextoParametros)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TEXTO_PARAMETROS");
            entity.Property(e => e.UtilizaFormulas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UTILIZA_FORMULAS");
        });

        modelBuilder.Entity<AdDefinicionParametro>(entity =>
        {
            entity.HasKey(e => e.Parametro);

            entity.ToTable("AD_DEFINICION_PARAMETROS");

            entity.Property(e => e.Parametro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARAMETRO");
            entity.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            entity.Property(e => e.EtiquetaDefault)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA_DEFAULT");
            entity.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
        });

        modelBuilder.Entity<AdDefwhereFuncion>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Funcion });

            entity.ToTable("AD_DEFWHERE_FUNCION");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            entity.Property(e => e.DefaultWhere)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_WHERE");

            entity.HasOne(d => d.ObjetoNavigation).WithMany(p => p.AdDefwhereFuncions)
                .HasForeignKey(d => d.Objeto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_DEFWHERE_FUNCION_AD_OBJE");
        });

        modelBuilder.Entity<AdErrore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_ERRORES");

            entity.Property(e => e.Accion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACCION");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UBICACION");
        });

        modelBuilder.Entity<AdFiltro>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Campo });

            entity.ToTable("AD_FILTROS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Campo)
                .HasPrecision(18)
                .HasColumnName("CAMPO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdFormula>(entity =>
        {
            entity.HasKey(e => e.IdFormula);

            entity.ToTable("AD_FORMULAS");

            entity.Property(e => e.IdFormula)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ID_FORMULA");
            entity.Property(e => e.TextoFormula)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("TEXTO_FORMULA");
        });

        modelBuilder.Entity<AdFuncione>(entity =>
        {
            entity.HasKey(e => e.Funcion);

            entity.ToTable("AD_FUNCIONES");

            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("FUNCION");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.EjecucionFormulacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EJECUCION_FORMULACION");
            entity.Property(e => e.Historico)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HISTORICO");
            entity.Property(e => e.Regularizacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REGULARIZACION");
            entity.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");
            entity.Property(e => e.TipoFuncion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_FUNCION");
        });

        modelBuilder.Entity<AdFuncionesUsuario>(entity =>
        {
            entity.HasKey(e => new { e.Usuario, e.Funcion });

            entity.ToTable("AD_FUNCIONES_USUARIO");

            entity.HasIndex(e => new { e.Usuario, e.Restrictiva }, "DTA_INDEX_AD_FUNCIONES_USUARIO");

            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            entity.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");

            entity.HasOne(d => d.FuncionNavigation).WithMany(p => p.AdFuncionesUsuarios)
                .HasForeignKey(d => d.Funcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_FUNCIONES_USUARIO_AD_FUN");
        });

        modelBuilder.Entity<AdGrant>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Perfil, e.Privilegio });

            entity.ToTable("AD_GRANTS");

            entity.HasIndex(e => new { e.Objeto, e.Modo }, "DTA_INDEX_AD_GRANTS_5_20368513");

            entity.HasIndex(e => e.Objeto, "IX_AD_GRANTS");

            entity.HasIndex(e => e.Perfil, "IX_AD_GRANTS_1");

            entity.HasIndex(e => e.Privilegio, "IX_AD_GRANTS_2");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.Privilegio)
                .HasPrecision(6)
                .HasColumnName("PRIVILEGIO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Granteable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GRANTEABLE");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Modo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MODO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");

            entity.HasOne(d => d.PerfilNavigation).WithMany(p => p.AdGrants)
                .HasForeignKey(d => d.Perfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRANTS_AD_PERFILES");

            entity.HasOne(d => d.PrivilegioNavigation).WithMany(p => p.AdGrants)
                .HasForeignKey(d => d.Privilegio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRANTS_AD_PRIVILEGIOS");
        });

        modelBuilder.Entity<AdGrupo>(entity =>
        {
            entity.HasKey(e => e.Grupo);

            entity.ToTable("AD_GRUPOS");

            entity.Property(e => e.Grupo)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("GRUPO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdGruposFuncion>(entity =>
        {
            entity.HasKey(e => new { e.Funcion, e.Grupo });

            entity.ToTable("AD_GRUPOS_FUNCION");

            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            entity.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");

            entity.HasOne(d => d.FuncionNavigation).WithMany(p => p.AdGruposFuncions)
                .HasForeignKey(d => d.Funcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRUPOS_FUNCION_AD_FUNCIO");

            entity.HasOne(d => d.GrupoNavigation).WithMany(p => p.AdGruposFuncions)
                .HasForeignKey(d => d.Grupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRUPOS_FUNCION_AD_GRUPOS");
        });

        modelBuilder.Entity<AdHuella>(entity =>
        {
            entity.HasKey(e => e.Usuario);

            entity.ToTable("AD_HUELLAS");

            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.FirmaDactilar)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("FIRMA_DACTILAR");
        });

        modelBuilder.Entity<AdInstanciasOperacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_INSTANCIAS_OPERACION");

            entity.HasIndex(e => new { e.Operacion, e.Grupo, e.Valor, e.TipoPredicado }, "DTA_INDEX_AD_INSTANCIAS_OPER_1");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            entity.Property(e => e.TipoPredicado)
                .HasPrecision(2)
                .HasColumnName("TIPO_PREDICADO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
            entity.Property(e => e.Valor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<AdListasValore>(entity =>
        {
            entity.HasKey(e => e.IdLista);

            entity.ToTable("AD_LISTAS_VALORES");

            entity.Property(e => e.IdLista)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ID_LISTA");
            entity.Property(e => e.CargarBajoDemanda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARGAR_BAJO_DEMANDA");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.ForzarFiltro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FORZAR_FILTRO");
            entity.Property(e => e.SqlStatement)
                .HasMaxLength(3500)
                .IsUnicode(false)
                .HasColumnName("SQL_STATEMENT");
            entity.Property(e => e.UsarDiccionario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USAR_DICCIONARIO");
            entity.Property(e => e.UsarWebcache)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USAR_WEBCACHE");
        });

        modelBuilder.Entity<AdMapeoObjeto>(entity =>
        {
            entity.HasKey(e => new { e.ObjetoInicial, e.ObjetoFinal });

            entity.ToTable("AD_MAPEO_OBJETOS");

            entity.HasIndex(e => e.ObjetoInicial, "IX_AD_MAPEO_OBJETOS");

            entity.HasIndex(e => e.ObjetoFinal, "IX_AD_MAPEO_OBJETOS_1");

            entity.Property(e => e.ObjetoInicial)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_INICIAL");
            entity.Property(e => e.ObjetoFinal)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_FINAL");
            entity.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");
        });

        modelBuilder.Entity<AdMatrizOperacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_MATRIZ_OPERACIONES");

            entity.Property(e => e.ClaseGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASE_GRUPO");
            entity.Property(e => e.ClaseModificacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASE_MODIFICACION");
            entity.Property(e => e.ClaseRegistro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASE_REGISTRO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.IdMatriz)
                .HasPrecision(4)
                .HasColumnName("ID_MATRIZ");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Modo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MODO");
            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdMensajesError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_MENSAJES_ERROR");

            entity.Property(e => e.Accion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ACCION");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MENSAJE");
            entity.Property(e => e.Numero)
                .HasPrecision(6)
                .HasColumnName("NUMERO");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PREFIJO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdNoticia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_NOTICIAS");

            entity.Property(e => e.Asunto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ASUNTO");
            entity.Property(e => e.Contenido)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CONTENIDO");
            entity.Property(e => e.De)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DE");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.FechaFinVigencia)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_FIN_VIGENCIA");
            entity.Property(e => e.FechaInicioVigencia)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INICIO_VIGENCIA");
            entity.Property(e => e.Para)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PARA");
            entity.Property(e => e.Prioridad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PRIORIDAD");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdNumerosEntradum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_NUMEROS_ENTRADA");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Ejercicio)
                .HasPrecision(4)
                .HasColumnName("EJERCICIO");
            entity.Property(e => e.Entidad)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.NoEntrada)
                .HasPrecision(6)
                .HasColumnName("NO_ENTRADA");
            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdObjeto>(entity =>
        {
            entity.HasKey(e => e.Objeto).HasName("OBJ_PK");

            entity.ToTable("AD_OBJETOS");

            entity.HasIndex(e => new { e.Objeto, e.NombreLogico, e.NombreFisico, e.Etiqueta, e.ObjetoPadre, e.TipoObjeto, e.Nivel, e.OrdenTabulacion }, "DTA_INDEX_AD_OBJETOS_5_26795_1");

            entity.HasIndex(e => new { e.Objeto, e.NombreLogico, e.NombreFisico, e.Etiqueta, e.ObjetoPadre, e.TipoObjeto, e.Nivel, e.OrdenTabulacion, e.ImagenBotonArriba, e.ImagenBotonSobre }, "DTA_INDEX_AD_OBJETOS_5_26795_2");

            entity.HasIndex(e => e.ObjetoPadre, "IX_AD_OBJETOS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.AmbienteDesarrollo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AMBIENTE_DESARROLLO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.ImagenBotonArriba)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_ARRIBA");
            entity.Property(e => e.ImagenBotonSobre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_SOBRE");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'A'")
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("0")
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nivel)
                .HasPrecision(3)
                .HasColumnName("NIVEL");
            entity.Property(e => e.NombreFisico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FISICO");
            entity.Property(e => e.NombreLogico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_LOGICO");
            entity.Property(e => e.Numeracion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NUMERACION");
            entity.Property(e => e.ObjetoPadre)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_PADRE");
            entity.Property(e => e.OrdenTabulacion)
                .HasPrecision(9)
                .HasColumnName("ORDEN_TABULACION");
            entity.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .HasColumnName("TIPO_OBJETO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");

            entity.HasOne(d => d.ObjetoPadreNavigation).WithMany(p => p.InverseObjetoPadreNavigation)
                .HasForeignKey(d => d.ObjetoPadre)
                .HasConstraintName("FK__AD_OBJETO__OBJET__39E294A9");

            entity.HasOne(d => d.TipoObjetoNavigation).WithMany(p => p.AdObjetos)
                .HasForeignKey(d => d.TipoObjeto)
                .HasConstraintName("FK_AD_OBJETOS_AD_TIPOS_OBJETO");
        });

        modelBuilder.Entity<AdObjetosCierre>(entity =>
        {
            entity.HasKey(e => e.Objeto);

            entity.ToTable("AD_OBJETOS_CIERRE");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
        });

        modelBuilder.Entity<AdOperacionesRestrictiva>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_OPERACIONES_RESTRICTIVAS");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdParametro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PARAMETROS");

            entity.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ETIQUETA");
            entity.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.Parametro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PARAMETRO");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DATO");
        });

        modelBuilder.Entity<AdParametrosSistema>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PARAMETROS_SISTEMA");

            entity.Property(e => e.Contexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTEXTO");
            entity.Property(e => e.DiasExpiracionClaves)
                .HasPrecision(4)
                .HasColumnName("DIAS_EXPIRACION_CLAVES");
            entity.Property(e => e.DiasNoticiaReciente)
                .HasPrecision(5)
                .HasColumnName("DIAS_NOTICIA_RECIENTE");
            entity.Property(e => e.DiasNotifAntesExp)
                .HasPrecision(2)
                .HasColumnName("DIAS_NOTIF_ANTES_EXP");
            entity.Property(e => e.EmailContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CONTACTO");
            entity.Property(e => e.GeneradorPredicados)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENERADOR_PREDICADOS");
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.InterfazSeguridad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INTERFAZ_SEGURIDAD");
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAIS");
            entity.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO");
            entity.Property(e => e.ServidorCorreo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERVIDOR_CORREO");
            entity.Property(e => e.ServidorReportes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERVIDOR_REPORTES");
            entity.Property(e => e.TablespaceTemporal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLESPACE_TEMPORAL");
            entity.Property(e => e.TablespaceUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLESPACE_USUARIO");
            entity.Property(e => e.TasaImpuesto)
                .HasColumnType("NUMBER(8,4)")
                .HasColumnName("TASA_IMPUESTO");
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITULO");
        });

        modelBuilder.Entity<AdPerfile>(entity =>
        {
            entity.HasKey(e => e.Perfil).HasName("PERF_PK");

            entity.ToTable("AD_PERFILES");

            entity.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nivel)
                .HasPrecision(3)
                .HasColumnName("NIVEL");
            entity.Property(e => e.ObjetoRaiz)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_RAIZ");
            entity.Property(e => e.PerfilAdministrativo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERFIL_ADMINISTRATIVO");
            entity.Property(e => e.PerfilPadre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL_PADRE");
            entity.Property(e => e.TipoPerfil)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("TIPO_PERFIL");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdPerfilesColumna>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PERFILES_COLUMNAS");

            entity.Property(e => e.IdColumna)
                .HasPrecision(18)
                .HasColumnName("ID_COLUMNA");
            entity.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.VerificaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VERIFICA_ESTADO");
        });

        modelBuilder.Entity<AdPerfilesFuncion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PERFILES_FUNCION");

            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.PerfilAplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERFIL_APLICACION");
            entity.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");
        });

        modelBuilder.Entity<AdPerfilesUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PERFILES_USUARIO");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            entity.Property(e => e.PerfilAplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERFIL_APLICACION");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<AdPistaOperacionesMe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PISTA_OPERACIONES_ME");

            entity.Property(e => e.FechaOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_OPERACION");
            entity.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<AdPrivilegio>(entity =>
        {
            entity.HasKey(e => e.Privilegio);

            entity.ToTable("AD_PRIVILEGIOS");

            entity.Property(e => e.Privilegio)
                .HasPrecision(6)
                .ValueGeneratedNever()
                .HasColumnName("PRIVILEGIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Generable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GENERABLE");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Sentencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SENTENCIA");
            entity.Property(e => e.UseridAct)
                .HasColumnType("DATE")
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdPrivilegiosTipoObjeto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_PRIVILEGIOS_TIPO_OBJETO");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Privilegio)
                .HasPrecision(6)
                .HasColumnName("PRIVILEGIO");
            entity.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .HasColumnName("TIPO_OBJETO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdRepositorioReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_REPOSITORIO_REPORTES");

            entity.Property(e => e.DiasPresentacion)
                .HasPrecision(18)
                .HasColumnName("DIAS_PRESENTACION");
            entity.Property(e => e.DirectorioReporte)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIRECTORIO_REPORTE");
            entity.Property(e => e.FechaGeneracion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_GENERACION");
            entity.Property(e => e.Objeto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Reporte)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REPORTE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<AdTempoColumna>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Alias, e.Datafield });

            entity.ToTable("AD_TEMPO_COLUMNAS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.Datafield)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATAFIELD");
            entity.Property(e => e.AgregarParametro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AGREGAR_PARAMETRO");
            entity.Property(e => e.CampoLlave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAMPO_LLAVE");
            entity.Property(e => e.Datalist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATALIST");
            entity.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            entity.Property(e => e.EditableGrid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EDITABLE_GRID");
            entity.Property(e => e.ExcluirGrid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EXCLUIR_GRID");
            entity.Property(e => e.HeaderText)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("HEADER_TEXT");
            entity.Property(e => e.Height)
                .HasPrecision(18)
                .HasColumnName("HEIGHT");
            entity.Property(e => e.HeightEtiqueta)
                .HasPrecision(18)
                .HasColumnName("HEIGHT_ETIQUETA");
            entity.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.MostrarFiltro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MOSTRAR_FILTRO");
            entity.Property(e => e.PermitirInsert)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERMITIR_INSERT");
            entity.Property(e => e.PermitirUpdate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERMITIR_UPDATE");
            entity.Property(e => e.Sumarizable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUMARIZABLE");
            entity.Property(e => e.TabIndex)
                .HasPrecision(18)
                .HasColumnName("TAB_INDEX");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
            entity.Property(e => e.ValorInicial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALOR_INICIAL");
            entity.Property(e => e.Width)
                .HasPrecision(18)
                .HasColumnName("WIDTH");
            entity.Property(e => e.WidthEtiqueta)
                .HasPrecision(18)
                .HasColumnName("WIDTH_ETIQUETA");
        });

        modelBuilder.Entity<AdTempoConsulta>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Alias });

            entity.ToTable("AD_TEMPO_CONSULTAS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Alias)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.DefaultOrderby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_ORDERBY");
            entity.Property(e => e.DefaultWhere)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_WHERE");
            entity.Property(e => e.LinkExpandir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LINK_EXPANDIR");
            entity.Property(e => e.Multiselect)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MULTISELECT");
            entity.Property(e => e.ObjetoRepositorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBJETO_REPOSITORIO");
            entity.Property(e => e.Paginear)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PAGINEAR");
            entity.Property(e => e.SecuenciaFetch)
                .HasPrecision(18)
                .HasColumnName("SECUENCIA_FETCH");
            entity.Property(e => e.SelectStatement)
                .HasColumnType("CLOB")
                .HasColumnName("SELECT_STATEMENT");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            entity.Property(e => e.TablaBase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA_BASE");
            entity.Property(e => e.TextoParametros)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TEXTO_PARAMETROS");
            entity.Property(e => e.UtilizaFormulas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UTILIZA_FORMULAS");
        });

        modelBuilder.Entity<AdTempoFiltro>(entity =>
        {
            entity.HasKey(e => new { e.Objeto, e.Campo });

            entity.ToTable("AD_TEMPO_FILTROS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Campo)
                .HasPrecision(18)
                .HasColumnName("CAMPO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdTempoObjeto>(entity =>
        {
            entity.HasKey(e => e.Objeto).HasName("OBJ_PK1");

            entity.ToTable("AD_TEMPO_OBJETOS");

            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.ImagenBotonArriba)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_ARRIBA");
            entity.Property(e => e.ImagenBotonSobre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_SOBRE");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nivel)
                .HasPrecision(3)
                .HasColumnName("NIVEL");
            entity.Property(e => e.NombreFisico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FISICO");
            entity.Property(e => e.NombreLogico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_LOGICO");
            entity.Property(e => e.Numeracion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NUMERACION");
            entity.Property(e => e.ObjetoPadre)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_PADRE");
            entity.Property(e => e.OrdenTabulacion)
                .HasPrecision(9)
                .HasColumnName("ORDEN_TABULACION");
            entity.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .HasColumnName("TIPO_OBJETO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdTemporalRowid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_TEMPORAL_ROWID");

            entity.Property(e => e.Idregistro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IDREGISTRO");
        });

        modelBuilder.Entity<AdTiposObjeto>(entity =>
        {
            entity.HasKey(e => e.TipoObjeto);

            entity.ToTable("AD_TIPOS_OBJETO");

            entity.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_OBJETO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreFisico)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FISICO");
            entity.Property(e => e.ObjetoBd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBJETO_BD");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdUnidadesAdministrativa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_UNIDADES_ADMINISTRATIVAS");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Maa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAA");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Siglas)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SIGLAS");
            entity.Property(e => e.UnidadAdministrativa)
                .HasPrecision(4)
                .HasColumnName("UNIDAD_ADMINISTRATIVA");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<AdUsuario>(entity =>
        {
            entity.HasKey(e => e.Usuario).HasName("USR_PK");

            entity.ToTable("AD_USUARIOS");

            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.AccesoSistemas)
                .HasPrecision(3)
                .HasColumnName("ACCESO_SISTEMAS");
            entity.Property(e => e.Aceptacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACEPTACION");
            entity.Property(e => e.CambiaClave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAMBIA_CLAVE");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EstadoLogin)
                .HasPrecision(3)
                .HasColumnName("ESTADO_LOGIN");
            entity.Property(e => e.FecUltLogin)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ULT_LOGIN");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaEgreso)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_EGRESO");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Puesto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PUESTO");
            entity.Property(e => e.PuestoResponsable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PUESTO_RESPONSABLE");
            entity.Property(e => e.RespaldoEgreso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESPALDO_EGRESO");
            entity.Property(e => e.ResponsableSuperior)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESPONSABLE_SUPERIOR");
            entity.Property(e => e.SesionMultiple)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SESION_MULTIPLE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UBICACION");
            entity.Property(e => e.UltFecCambioClave)
                .HasColumnType("DATE")
                .HasColumnName("ULT_FEC_CAMBIO_CLAVE");
            entity.Property(e => e.UnidadAdministrativa)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_ADMINISTRATIVA");
            entity.Property(e => e.UsuarioSupervisa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO_SUPERVISA");

            entity.HasOne(d => d.GrupoNavigation).WithMany(p => p.AdUsuarios)
                .HasForeignKey(d => d.Grupo)
                .HasConstraintName("FK_AD_USUARIOS_AD_GRUPOS");
        });

        modelBuilder.Entity<AdUsuariosGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AD_USUARIOS_GRUPO");

            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Dtproperty>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Property });

            entity.ToTable("DTPROPERTIES");

            entity.Property(e => e.Id)
                .HasPrecision(10)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Property)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROPERTY");
            entity.Property(e => e.Lvalue)
                .HasColumnType("BLOB")
                .HasColumnName("LVALUE");
            entity.Property(e => e.Objectid)
                .HasPrecision(10)
                .HasColumnName("OBJECTID");
            entity.Property(e => e.Uvalue)
                .HasMaxLength(255)
                .HasColumnName("UVALUE");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VALUE");
            entity.Property(e => e.Version)
                .HasPrecision(10)
                .HasDefaultValueSql("0 ")
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<Equivalencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EQUIVALENCIAS");

            entity.Property(e => e.Equivalencia1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("EQUIVALENCIA");
            entity.Property(e => e.Frase)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FRASE");
            entity.Property(e => e.TipoFrase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_FRASE");
        });

        modelBuilder.Entity<MenuFuncione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENU_FUNCIONES");

            entity.Property(e => e.AmbienteDesarrollo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AMBIENTE_DESARROLLO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            entity.Property(e => e.ImagenBotonArriba)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_ARRIBA");
            entity.Property(e => e.ImagenBotonSobre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_SOBRE");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nivel)
                .HasPrecision(3)
                .HasColumnName("NIVEL");
            entity.Property(e => e.NombreFisico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FISICO");
            entity.Property(e => e.NombreFuncion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUNCION");
            entity.Property(e => e.NombreLogico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_LOGICO");
            entity.Property(e => e.Numeracion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NUMERACION");
            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.ObjetoPadre)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_PADRE");
            entity.Property(e => e.OrdenTabulacion)
                .HasPrecision(9)
                .HasColumnName("ORDEN_TABULACION");
            entity.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .HasColumnName("TIPO_OBJETO");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<Metforeignkey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("METFOREIGNKEYS");

            entity.Property(e => e.ChildColumn)
                .HasMaxLength(128)
                .HasColumnName("CHILD_COLUMN");
            entity.Property(e => e.ChildTable)
                .HasMaxLength(128)
                .HasColumnName("CHILD_TABLE");
            entity.Property(e => e.ForeignKeyName)
                .HasMaxLength(128)
                .HasColumnName("FOREIGN_KEY_NAME");
            entity.Property(e => e.Idfk)
                .HasPrecision(10)
                .HasColumnName("IDFK");
            entity.Property(e => e.Keyno)
                .HasPrecision(5)
                .HasColumnName("KEYNO");
            entity.Property(e => e.ParentColumn)
                .HasMaxLength(128)
                .HasColumnName("PARENT_COLUMN");
            entity.Property(e => e.ParentTable)
                .HasMaxLength(128)
                .HasColumnName("PARENT_TABLE");
        });

        modelBuilder.Entity<Orm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORM__");

            entity.Property(e => e.Databaseguid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATABASEGUID");
        });

        modelBuilder.Entity<Prueba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRUEBA");

            entity.Property(e => e.Caracter)
                .HasColumnType("CLOB")
                .HasColumnName("CARACTER");
            entity.Property(e => e.Prueba1)
                .HasColumnType("CLOB")
                .HasColumnName("PRUEBA");
        });

        modelBuilder.Entity<Prueba1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRUEBA1");

            entity.Property(e => e.Alias)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.DefaultOrderby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_ORDERBY");
            entity.Property(e => e.DefaultWhere)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_WHERE");
            entity.Property(e => e.LinkExpandir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LINK_EXPANDIR");
            entity.Property(e => e.Multiselect)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MULTISELECT");
            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.ObjetoRepositorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBJETO_REPOSITORIO");
            entity.Property(e => e.Paginear)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PAGINEAR");
            entity.Property(e => e.SecuenciaFetch)
                .HasPrecision(18)
                .HasColumnName("SECUENCIA_FETCH");
            entity.Property(e => e.SelectStatement)
                .HasColumnType("CLOB")
                .HasColumnName("SELECT_STATEMENT");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            entity.Property(e => e.TablaBase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA_BASE");
            entity.Property(e => e.TextoParametros)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TEXTO_PARAMETROS");
            entity.Property(e => e.UtilizaFormulas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UTILIZA_FORMULAS");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REPORTE");

            entity.Property(e => e.Codigo)
                .HasPrecision(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Codrep)
                .HasPrecision(10)
                .HasColumnName("CODREP");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RESULTS");

            entity.Property(e => e.Actobra)
                .HasPrecision(3)
                .HasColumnName("ACTOBRA");
            entity.Property(e => e.ActobraNs)
                .HasPrecision(3)
                .HasColumnName("ACTOBRA_NS");
            entity.Property(e => e.ClaseGasto)
                .HasPrecision(3)
                .HasColumnName("CLASE_GASTO");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Ejercicio)
                .HasPrecision(4)
                .HasColumnName("EJERCICIO");
            entity.Property(e => e.Entidad)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.EntidadNs)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD_NS");
            entity.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            entity.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            entity.Property(e => e.Funcion)
                .HasPrecision(3)
                .HasColumnName("FUNCION");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.NivelEstructura)
                .HasPrecision(1)
                .HasColumnName("NIVEL_ESTRUCTURA");
            entity.Property(e => e.NoProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NO_PROYECTO");
            entity.Property(e => e.NomEstructura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_ESTRUCTURA");
            entity.Property(e => e.Programa)
                .HasPrecision(3)
                .HasColumnName("PROGRAMA");
            entity.Property(e => e.ProgramaNs)
                .HasPrecision(3)
                .HasColumnName("PROGRAMA_NS");
            entity.Property(e => e.Proyecto)
                .HasPrecision(3)
                .HasColumnName("PROYECTO");
            entity.Property(e => e.ProyectoNs)
                .HasPrecision(3)
                .HasColumnName("PROYECTO_NS");
            entity.Property(e => e.Subprograma)
                .HasPrecision(3)
                .HasColumnName("SUBPROGRAMA");
            entity.Property(e => e.SubprogramaNs)
                .HasPrecision(3)
                .HasColumnName("SUBPROGRAMA_NS");
            entity.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            entity.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ROLE");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<RtCampo>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("RT_CAMPOS");

            entity.HasIndex(e => e.Tabla, "IX_RT_CAMPOS");

            entity.HasIndex(e => e.Nombre, "IX_RT_CAMPOS_1");

            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Dominio)
                .HasPrecision(18)
                .HasColumnName("DOMINIO");
            entity.Property(e => e.Llave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LLAVE");
            entity.Property(e => e.Longitud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Obligatorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBLIGATORIO");
            entity.Property(e => e.Tabla)
                .HasPrecision(18)
                .HasColumnName("TABLA");
            entity.Property(e => e.TipoControl)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TIPO_CONTROL");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
        });

        modelBuilder.Entity<RtClasesDeRegistro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_CLASES_DE_REGISTROS");

            entity.Property(e => e.ClaseDeRegistro)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLASE_DE_REGISTRO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Tabla)
                .HasPrecision(18)
                .HasColumnName("TABLA");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<RtDominio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_DOMINIOS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Longitud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LONGITUD");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<RtEstado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_ESTADOS");

            entity.Property(e => e.ClaseDeRegistro)
                .HasPrecision(18)
                .HasColumnName("CLASE_DE_REGISTRO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Detabla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DETABLA");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Notas)
                .HasColumnType("CLOB")
                .HasColumnName("NOTAS");
            entity.Property(e => e.Tabla)
                .HasPrecision(18)
                .HasColumnName("TABLA");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<RtOperacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_OPERACIONES");

            entity.Property(e => e.ClaseDeRegistro)
                .HasPrecision(18)
                .HasColumnName("CLASE_DE_REGISTRO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Detabla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DETABLA");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Notas)
                .HasColumnType("CLOB")
                .HasColumnName("NOTAS");
            entity.Property(e => e.Operacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Tabla)
                .HasPrecision(18)
                .HasColumnName("TABLA");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<RtRegla>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_REGLAS");

            entity.Property(e => e.Accion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ACCION");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTATUS");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Notas)
                .HasColumnType("CLOB")
                .HasColumnName("NOTAS");
            entity.Property(e => e.Origen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ORIGEN");
            entity.Property(e => e.OrigenAutor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGEN_AUTOR");
            entity.Property(e => e.OrigenFuente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGEN_FUENTE");
            entity.Property(e => e.OrigenResponsable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGEN_RESPONSABLE");
            entity.Property(e => e.Patron)
                .HasColumnType("NUMBER(28)")
                .HasColumnName("PATRON");
            entity.Property(e => e.Regla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REGLA");
            entity.Property(e => e.ReglaContenedora)
                .HasColumnType("NUMBER(28)")
                .HasColumnName("REGLA_CONTENEDORA");
            entity.Property(e => e.Tid)
                .HasColumnType("NUMBER(28)")
                .HasColumnName("TID");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<RtSistema>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_SISTEMAS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dueno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DUENO");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Sistema)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SISTEMA");
            entity.Property(e => e.Supersistema)
                .HasPrecision(18)
                .HasColumnName("SUPERSISTEMA");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<RtTabla>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("RT_TABLAS");

            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.Bitacorizar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BITACORIZAR");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Reportes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTES");
            entity.Property(e => e.Sinonimo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SINONIMO");
            entity.Property(e => e.Sistema)
                .HasPrecision(18)
                .HasColumnName("SISTEMA");
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
        });

        modelBuilder.Entity<RtTransicione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RT_TRANSICIONES");

            entity.Property(e => e.Automatica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUTOMATICA");
            entity.Property(e => e.EstadoFinal)
                .HasPrecision(18)
                .HasColumnName("ESTADO_FINAL");
            entity.Property(e => e.EstadoInicial)
                .HasPrecision(18)
                .HasColumnName("ESTADO_INICIAL");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        });

        modelBuilder.Entity<Secuencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SECUENCIAS");

            entity.Property(e => e.Anio)
                .HasPrecision(18)
                .HasColumnName("ANIO");
            entity.Property(e => e.Correlativo)
                .HasPrecision(18)
                .HasColumnName("CORRELATIVO");
            entity.Property(e => e.TipoObjeto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_OBJETO");
        });

        modelBuilder.Entity<Seq>(entity =>
        {
            entity.HasKey(e => e.Secuencia);

            entity.ToTable("SEQS");

            entity.Property(e => e.Secuencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SECUENCIA");
            entity.Property(e => e.Valor)
                .HasPrecision(10)
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Sequence>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK__SEQUENCES__07CCE17F");

            entity.ToTable("SEQUENCES");

            entity.Property(e => e.Seq)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SEQ");
            entity.Property(e => e.SequenceId)
                .HasPrecision(10)
                .HasColumnName("SEQUENCE_ID");
        });

        modelBuilder.Entity<SgDetalleBitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SG_DETALLE_BITACORA");

            entity.Property(e => e.IdDetalle)
                .HasPrecision(10)
                .HasColumnName("ID_DETALLE");
            entity.Property(e => e.IdEnc)
                .HasPrecision(10)
                .HasColumnName("ID_ENC");
            entity.Property(e => e.NombreCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CAMPO");
            entity.Property(e => e.ValorAnterior)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("VALOR_ANTERIOR");
            entity.Property(e => e.ValorNuevo)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("VALOR_NUEVO");
        });

        modelBuilder.Entity<SgEncbitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SG_ENCBITACORA");

            entity.Property(e => e.CamposPk)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CAMPOS_PK");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.IdEnc)
                .HasPrecision(10)
                .HasColumnName("ID_ENC");
            entity.Property(e => e.IdOperacion)
                .HasPrecision(10)
                .HasColumnName("ID_OPERACION");
            entity.Property(e => e.LlaveFila)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LLAVE_FILA");
            entity.Property(e => e.NombreTabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TABLA");
            entity.Property(e => e.Operacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.UsuarioBdd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USUARIO_BDD");
        });

        modelBuilder.Entity<SgOperacione>(entity =>
        {
            entity.HasKey(e => e.IdOperacion);

            entity.ToTable("SG_OPERACIONES");

            entity.Property(e => e.IdOperacion)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("ID_OPERACION");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaFinOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_FIN_OPERACION");
            entity.Property(e => e.FechaOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_OPERACION");
            entity.Property(e => e.NombreOperacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_OPERACION");
            entity.Property(e => e.TiempoOperacionBdd)
                .HasPrecision(18)
                .HasColumnName("TIEMPO_OPERACION_BDD");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.UsuarioBdd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USUARIO_BDD");
        });

        modelBuilder.Entity<SgReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SG_REPORTES");

            entity.Property(e => e.FechaFin)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.Filtro)
                .HasColumnType("NCLOB")
                .HasColumnName("FILTRO");
            entity.Property(e => e.Reporte)
                .HasMaxLength(50)
                .HasColumnName("REPORTE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP");

            entity.Property(e => e.AccesoSistemas)
                .HasPrecision(3)
                .HasColumnName("ACCESO_SISTEMAS");
            entity.Property(e => e.CambiaClave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAMBIA_CLAVE");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EstadoLogin)
                .HasPrecision(3)
                .HasColumnName("ESTADO_LOGIN");
            entity.Property(e => e.FecUltLogin)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ULT_LOGIN");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_CREACION");
            entity.Property(e => e.FechaEgreso)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_EGRESO");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Nit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Puesto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PUESTO");
            entity.Property(e => e.PuestoResponsable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PUESTO_RESPONSABLE");
            entity.Property(e => e.RespaldoEgreso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESPALDO_EGRESO");
            entity.Property(e => e.ResponsableSuperior)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESPONSABLE_SUPERIOR");
            entity.Property(e => e.SesionMultiple)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SESION_MULTIPLE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UBICACION");
            entity.Property(e => e.UltFecCambioClave)
                .HasColumnType("DATE")
                .HasColumnName("ULT_FEC_CAMBIO_CLAVE");
            entity.Property(e => e.UnidadAdministrativa)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_ADMINISTRATIVA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.UsuarioSupervisa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO_SUPERVISA");
        });

        modelBuilder.Entity<TempUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_USUARIOS");

            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<TipoReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TIPO_REPORTE");

            entity.Property(e => e.Codigo)
                .HasPrecision(10)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Udt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UDT");

            entity.Property(e => e.Actobra)
                .HasPrecision(3)
                .HasColumnName("ACTOBRA");
            entity.Property(e => e.Aspecto)
                .HasPrecision(5)
                .HasColumnName("ASPECTO");
            entity.Property(e => e.AumentoDisminucion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUMENTO_DISMINUCION");
            entity.Property(e => e.Banco)
                .HasPrecision(3)
                .HasColumnName("BANCO");
            entity.Property(e => e.Caif)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAIF");
            entity.Property(e => e.Cantidad)
                .HasColumnType("NUMBER(16,5)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Categoria)
                .HasPrecision(6)
                .HasColumnName("CATEGORIA");
            entity.Property(e => e.ClaseAux)
                .HasPrecision(2)
                .HasColumnName("CLASE_AUX");
            entity.Property(e => e.ClaseContrato)
                .HasPrecision(4)
                .HasColumnName("CLASE_CONTRATO");
            entity.Property(e => e.ClaseCorrespondencia)
                .HasPrecision(3)
                .HasColumnName("CLASE_CORRESPONDENCIA");
            entity.Property(e => e.ClaseGrupo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLASE_GRUPO");
            entity.Property(e => e.ClaseModificacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLASE_MODIFICACION");
            entity.Property(e => e.ClaseRegistro)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLASE_REGISTRO");
            entity.Property(e => e.Concepto)
                .HasPrecision(4)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Contenido)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CONTENIDO");
            entity.Property(e => e.Cuenta)
                .HasPrecision(2)
                .HasColumnName("CUENTA");
            entity.Property(e => e.CuentaMonetaria)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTA_MONETARIA");
            entity.Property(e => e.DClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_CLASE");
            entity.Property(e => e.DDescripcionCorta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("D_DESCRIPCION_CORTA");
            entity.Property(e => e.DDescripcionMedia)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("D_DESCRIPCION_MEDIA");
            entity.Property(e => e.DEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_ESTADO");
            entity.Property(e => e.DLlave)
                .HasPrecision(18)
                .HasColumnName("D_LLAVE");
            entity.Property(e => e.DLongitud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("D_LONGITUD");
            entity.Property(e => e.DNombreCorto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_NOMBRE_CORTO");
            entity.Property(e => e.DNombreMedio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("D_NOMBRE_MEDIO");
            entity.Property(e => e.DNotas)
                .HasColumnType("CLOB")
                .HasColumnName("D_NOTAS");
            entity.Property(e => e.DOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_OPERACION");
            entity.Property(e => e.DSino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("D_SINO");
            entity.Property(e => e.DSinonimo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("D_SINONIMO");
            entity.Property(e => e.DSistema)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("D_SISTEMA");
            entity.Property(e => e.DTipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("D_TIPO_DATO");
            entity.Property(e => e.DebitoCredito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEBITO_CREDITO");
            entity.Property(e => e.Deduccion)
                .HasPrecision(3)
                .HasColumnName("DEDUCCION");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Deuda)
                .HasPrecision(15)
                .HasColumnName("DEUDA");
            entity.Property(e => e.Dia)
                .HasPrecision(2)
                .HasColumnName("DIA");
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.DisposicionLegal)
                .HasPrecision(12)
                .HasColumnName("DISPOSICION_LEGAL");
            entity.Property(e => e.Economico)
                .HasPrecision(7)
                .HasColumnName("ECONOMICO");
            entity.Property(e => e.Ejercicio)
                .HasPrecision(4)
                .HasColumnName("EJERCICIO");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Entidad)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.EntidadReceptora)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD_RECEPTORA");
            entity.Property(e => e.ErrorHoja)
                .HasPrecision(3)
                .HasColumnName("ERROR_HOJA");
            entity.Property(e => e.EstadoFiscal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO_FISCAL");
            entity.Property(e => e.EstadoFondo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO_FONDO");
            entity.Property(e => e.Factura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FACTURA");
            entity.Property(e => e.Fecha)
                .HasColumnType("DATE")
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaCorta)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_CORTA");
            entity.Property(e => e.Firma)
                .HasMaxLength(8)
                .HasColumnName("FIRMA");
            entity.Property(e => e.FormaPago)
                .HasPrecision(3)
                .HasColumnName("FORMA_PAGO");
            entity.Property(e => e.Fuente)
                .HasPrecision(2)
                .HasColumnName("FUENTE");
            entity.Property(e => e.Funcion)
                .HasPrecision(3)
                .HasColumnName("FUNCION");
            entity.Property(e => e.GastoIngreso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GASTO_INGRESO");
            entity.Property(e => e.Geografico)
                .HasPrecision(4)
                .HasColumnName("GEOGRAFICO");
            entity.Property(e => e.GrupoCuenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GRUPO_CUENTA");
            entity.Property(e => e.GrupoGasto)
                .HasPrecision(3)
                .HasColumnName("GRUPO_GASTO");
            entity.Property(e => e.GrupoIngreso)
                .HasPrecision(5)
                .HasColumnName("GRUPO_INGRESO");
            entity.Property(e => e.IngresoGasto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("INGRESO_GASTO");
            entity.Property(e => e.Instancia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTANCIA");
            entity.Property(e => e.LugarGasto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LUGAR_GASTO");
            entity.Property(e => e.Mayor)
                .HasPrecision(4)
                .HasColumnName("MAYOR");
            entity.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            entity.Property(e => e.Mes)
                .HasPrecision(2)
                .HasColumnName("MES");
            entity.Property(e => e.Meta)
                .HasPrecision(3)
                .HasColumnName("META");
            entity.Property(e => e.Moneda)
                .HasPrecision(3)
                .HasColumnName("MONEDA");
            entity.Property(e => e.Monto)
                .HasColumnType("NUMBER(13,2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Nit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.NivelEstructura)
                .HasPrecision(1)
                .HasColumnName("NIVEL_ESTRUCTURA");
            entity.Property(e => e.NivelInstitucional)
                .HasPrecision(1)
                .HasColumnName("NIVEL_INSTITUCIONAL");
            entity.Property(e => e.NoComprobante)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NO_COMPROBANTE");
            entity.Property(e => e.NoCriterio)
                .HasPrecision(6)
                .HasColumnName("NO_CRITERIO");
            entity.Property(e => e.NoCur)
                .HasPrecision(6)
                .HasColumnName("NO_CUR");
            entity.Property(e => e.NoDeposito)
                .HasPrecision(12)
                .HasColumnName("NO_DEPOSITO");
            entity.Property(e => e.NoEntrada)
                .HasPrecision(6)
                .HasColumnName("NO_ENTRADA");
            entity.Property(e => e.NoFactura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NO_FACTURA");
            entity.Property(e => e.NoFondo)
                .HasPrecision(6)
                .HasColumnName("NO_FONDO");
            entity.Property(e => e.NoMatriz)
                .HasPrecision(4)
                .HasColumnName("NO_MATRIZ");
            entity.Property(e => e.NoOriginal)
                .HasPrecision(6)
                .HasColumnName("NO_ORIGINAL");
            entity.Property(e => e.NoRespaldo)
                .HasPrecision(12)
                .HasColumnName("NO_RESPALDO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Numero)
                .HasPrecision(10)
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroCorto)
                .HasPrecision(4)
                .HasColumnName("NUMERO_CORTO");
            entity.Property(e => e.Objetivos)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OBJETIVOS");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.OperacionBanco)
                .HasPrecision(3)
                .HasColumnName("OPERACION_BANCO");
            entity.Property(e => e.Organismo)
                .HasPrecision(6)
                .HasColumnName("ORGANISMO");
            entity.Property(e => e.OrigenCuenta)
                .HasPrecision(2)
                .HasColumnName("ORIGEN_CUENTA");
            entity.Property(e => e.Pais)
                .HasPrecision(3)
                .HasColumnName("PAIS");
            entity.Property(e => e.Partida)
                .HasPrecision(3)
                .HasColumnName("PARTIDA");
            entity.Property(e => e.PartidaAux)
                .HasPrecision(6)
                .HasColumnName("PARTIDA_AUX");
            entity.Property(e => e.Programa)
                .HasPrecision(3)
                .HasColumnName("PROGRAMA");
            entity.Property(e => e.Proyecto)
                .HasPrecision(3)
                .HasColumnName("PROYECTO");
            entity.Property(e => e.Recaudacion)
                .HasPrecision(3)
                .HasColumnName("RECAUDACION");
            entity.Property(e => e.Recurso)
                .HasPrecision(5)
                .HasColumnName("RECURSO");
            entity.Property(e => e.RecursoAux)
                .HasPrecision(2)
                .HasColumnName("RECURSO_AUX");
            entity.Property(e => e.RegimenIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REGIMEN_IVA");
            entity.Property(e => e.Region)
                .HasPrecision(2)
                .HasColumnName("REGION");
            entity.Property(e => e.Sector)
                .HasPrecision(3)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Secuencia)
                .HasPrecision(10)
                .HasColumnName("SECUENCIA");
            entity.Property(e => e.Semana)
                .HasPrecision(1)
                .HasColumnName("SEMANA");
            entity.Property(e => e.SiCuenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SI_CUENTA");
            entity.Property(e => e.SiProyecto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SI_PROYECTO");
            entity.Property(e => e.Sigla)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SIGLA");
            entity.Property(e => e.Signo)
                .HasPrecision(2)
                .HasColumnName("SIGNO");
            entity.Property(e => e.Sino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SINO");
            entity.Property(e => e.Subcuenta)
                .HasPrecision(2)
                .HasColumnName("SUBCUENTA");
            entity.Property(e => e.Subprograma)
                .HasPrecision(3)
                .HasColumnName("SUBPROGRAMA");
            entity.Property(e => e.Sucursal)
                .HasPrecision(4)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.TasaCambio)
                .HasColumnType("NUMBER(13,6)")
                .HasColumnName("TASA_CAMBIO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TipoCategoria)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPO_CATEGORIA");
            entity.Property(e => e.TipoContrato)
                .HasPrecision(3)
                .HasColumnName("TIPO_CONTRATO");
            entity.Property(e => e.TipoContribuyente)
                .HasPrecision(1)
                .HasColumnName("TIPO_CONTRIBUYENTE");
            entity.Property(e => e.TipoCuenta)
                .HasPrecision(1)
                .HasColumnName("TIPO_CUENTA");
            entity.Property(e => e.TipoDocumento)
                .HasPrecision(3)
                .HasColumnName("TIPO_DOCUMENTO");
            entity.Property(e => e.TipoFianza)
                .HasPrecision(3)
                .HasColumnName("TIPO_FIANZA");
            entity.Property(e => e.TipoPersonal)
                .HasPrecision(2)
                .HasColumnName("TIPO_PERSONAL");
            entity.Property(e => e.TipoPresupuesto)
                .HasPrecision(2)
                .HasColumnName("TIPO_PRESUPUESTO");
            entity.Property(e => e.TipoValor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_VALOR");
            entity.Property(e => e.TotalDetalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TOTAL_DETALLE");
            entity.Property(e => e.Trimestre)
                .HasPrecision(1)
                .HasColumnName("TRIMESTRE");
            entity.Property(e => e.UnidadMedida)
                .HasPrecision(4)
                .HasColumnName("UNIDAD_MEDIDA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Zona)
                .HasPrecision(2)
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<VBitacoraFunusu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BITACORA_FUNUSU");

            entity.Property(e => e.CodigoFuncion)
                .HasColumnType("NUMBER")
                .HasColumnName("CODIGO_FUNCION");
            entity.Property(e => e.CodigoGrupo)
                .HasPrecision(18)
                .HasColumnName("CODIGO_GRUPO");
            entity.Property(e => e.FechaOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_OPERACION");
            entity.Property(e => e.Funcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FUNCION");
            entity.Property(e => e.Grupo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Operacion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            entity.Property(e => e.U)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.UsuarioAsigna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO_ASIGNA");
        });

        modelBuilder.Entity<VwFuncionPerfilObjeto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FUNCION_PERFIL_OBJETO");

            entity.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            entity.Property(e => e.NombreFuncion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUNCION");
            entity.Property(e => e.NombreLogico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_LOGICO");
            entity.Property(e => e.NombrePerfil)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PERFIL");
            entity.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            entity.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
        });

        modelBuilder.Entity<VwUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_USUARIOS");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Entidad)
                .HasPrecision(8)
                .HasColumnName("ENTIDAD");
            entity.Property(e => e.FecUltLogin)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ULT_LOGIN");
            entity.Property(e => e.Institucion)
                .HasPrecision(4)
                .HasColumnName("INSTITUCION");
            entity.Property(e => e.Nit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreInstitucion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_INSTITUCION");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Puesto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PUESTO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.UnidadEjecutora)
                .HasPrecision(3)
                .HasColumnName("UNIDAD_EJECUTORA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });
        modelBuilder.HasSequence("DTPROPERTIES_ID_SEQ");
        modelBuilder.HasSequence("SQ_ENCBITACORA");
        modelBuilder.HasSequence("SQ_OPERACION");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
