using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminSys.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class ActUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AD_CAMPOS_MATRIZ",
                columns: table => new
                {
                    LLAVE = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    VALOR_CAMPO = table.Column<string>(type: "CLOB", nullable: false),
                    TIPO_CAMPO = table.Column<string>(type: "VARCHAR2(2)", unicode: false, maxLength: 2, nullable: false),
                    ETIQUETA = table.Column<string>(type: "VARCHAR2(70)", unicode: false, maxLength: 70, nullable: false),
                    PREDICADO_JOIN = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    TABLA_CAMPO = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    TABLA_JOIN = table.Column<string>(type: "CHAR(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    CODIGO_CAMPO = table.Column<string>(type: "VARCHAR2(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_CAMPOS_MATRIZ", x => x.LLAVE);
                });

            migrationBuilder.CreateTable(
                name: "AD_CAMPOS_OPERACION_RES",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    OPERACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_CHEQUES_CABECERA",
                columns: table => new
                {
                    ENTIDAD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    UNIDAD_EJECUTORA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    UNIDAD_DESCONCENTRADA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    CUENTA_PAGADORA = table.Column<string>(type: "VARCHAR2(25)", unicode: false, maxLength: 25, nullable: false),
                    CORRELATIVO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    TIPO_IMPRESORA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    CANTIDAD_LINEAS = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    CARACTERES_LINEA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    RESTRICTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "'N' ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_CHEQUES_CABECERA", x => new { x.ENTIDAD, x.UNIDAD_EJECUTORA, x.UNIDAD_DESCONCENTRADA, x.CUENTA_PAGADORA, x.CORRELATIVO });
                });

            migrationBuilder.CreateTable(
                name: "AD_CHEQUES_DETALLE",
                columns: table => new
                {
                    ENTIDAD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    UNIDAD_EJECUTORA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    UNIDAD_DESCONCENTRADA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    CUENTA_PAGADORA = table.Column<string>(type: "VARCHAR2(25)", unicode: false, maxLength: 25, nullable: false),
                    CORRELATIVO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    NOMBRE_CAMPO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    ORDEN_CAMPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    FILA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    COLUMNA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    SE_IMPRIME = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "'S' "),
                    TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    CAMPO_TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    VALOR_DEFAULT = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    MASCARA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    CONDENSADO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false, defaultValueSql: "'S' ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_CHEQUES_DETALLE", x => new { x.ENTIDAD, x.UNIDAD_EJECUTORA, x.UNIDAD_DESCONCENTRADA, x.CUENTA_PAGADORA, x.CORRELATIVO, x.NOMBRE_CAMPO });
                });

            migrationBuilder.CreateTable(
                name: "AD_CLASES_IDENTIFICADORES",
                columns: table => new
                {
                    MNEMONICO = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false),
                    CLASE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_COLUMNAS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    ALIAS = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    DATAFIELD = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    HEADER_TEXT = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: false),
                    TAB_INDEX = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    TIPO_DATO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    CAMPO_LLAVE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    DATALIST = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    EXCLUIR_GRID = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    MOSTRAR_FILTRO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    LONGITUD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DECIMALES = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    PERMITIR_INSERT = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    PERMITIR_UPDATE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    SUMARIZABLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    EDITABLE_GRID = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    WIDTH = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    HEIGHT = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    WIDTH_ETIQUETA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    HEIGHT_ETIQUETA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    VALOR_INICIAL = table.Column<string>(type: "VARCHAR2(200)", unicode: false, maxLength: 200, nullable: true),
                    AGREGAR_PARAMETRO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_COLUMNAS", x => new { x.OBJETO, x.ALIAS, x.DATAFIELD });
                });

            migrationBuilder.CreateTable(
                name: "AD_CONSULTAS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    ALIAS = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: false),
                    SELECT_STATEMENT = table.Column<string>(type: "CLOB", nullable: false),
                    TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    SECUENCIA_FETCH = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DEFAULT_WHERE = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DEFAULT_ORDERBY = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    MULTISELECT = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TEXTO_PARAMETROS = table.Column<string>(type: "VARCHAR2(250)", unicode: false, maxLength: 250, nullable: true),
                    OBJETO_REPOSITORIO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TABLA_BASE = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    LINK_EXPANDIR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    UTILIZA_FORMULAS = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    PAGINEAR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    SELECT_STATEMENT_AUX = table.Column<string>(type: "CLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_CONSULTAS", x => new { x.OBJETO, x.ALIAS });
                });

            migrationBuilder.CreateTable(
                name: "AD_DEFINICION_PARAMETROS",
                columns: table => new
                {
                    PARAMETRO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    TIPO_DATO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    LONGITUD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DECIMALES = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    ETIQUETA_DEFAULT = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_DEFINICION_PARAMETROS", x => x.PARAMETRO);
                });

            migrationBuilder.CreateTable(
                name: "AD_ERRORES",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "CHAR(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "CHAR(300)", unicode: false, fixedLength: true, maxLength: 300, nullable: true),
                    ACCION = table.Column<string>(type: "CHAR(300)", unicode: false, fixedLength: true, maxLength: 300, nullable: false),
                    UBICACION = table.Column<string>(type: "CHAR(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_FILTROS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    CAMPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_FILTROS", x => new { x.OBJETO, x.CAMPO });
                });

            migrationBuilder.CreateTable(
                name: "AD_FORMULAS",
                columns: table => new
                {
                    ID_FORMULA = table.Column<string>(type: "VARCHAR2(35)", unicode: false, maxLength: 35, nullable: false),
                    TEXTO_FORMULA = table.Column<string>(type: "VARCHAR2(700)", unicode: false, maxLength: 700, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_FORMULAS", x => x.ID_FORMULA);
                });

            migrationBuilder.CreateTable(
                name: "AD_FUNCIONES",
                columns: table => new
                {
                    FUNCION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    RESTRICTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    EJECUCION_FORMULACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    HISTORICO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    REGULARIZACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TIPO_FUNCION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_FUNCIONES", x => x.FUNCION);
                });

            migrationBuilder.CreateTable(
                name: "AD_GRUPOS",
                columns: table => new
                {
                    GRUPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_GRUPOS", x => x.GRUPO);
                });

            migrationBuilder.CreateTable(
                name: "AD_HUELLAS",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    FIRMA_DACTILAR = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_HUELLAS", x => x.USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "AD_INSTANCIAS_OPERACION",
                columns: table => new
                {
                    OPERACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    GRUPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    VALOR = table.Column<string>(type: "VARCHAR2(500)", unicode: false, maxLength: 500, nullable: false),
                    TIPO_PREDICADO = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_LISTAS_VALORES",
                columns: table => new
                {
                    ID_LISTA = table.Column<string>(type: "VARCHAR2(25)", unicode: false, maxLength: 25, nullable: false),
                    SQL_STATEMENT = table.Column<string>(type: "VARCHAR2(3500)", unicode: false, maxLength: 3500, nullable: false),
                    USAR_WEBCACHE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    CARGAR_BAJO_DEMANDA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    USAR_DICCIONARIO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: true),
                    FORZAR_FILTRO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_LISTAS_VALORES", x => x.ID_LISTA);
                });

            migrationBuilder.CreateTable(
                name: "AD_MAPEO_OBJETOS",
                columns: table => new
                {
                    OBJETO_INICIAL = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    OBJETO_FINAL = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    RESTRICTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_MAPEO_OBJETOS", x => new { x.OBJETO_INICIAL, x.OBJETO_FINAL });
                });

            migrationBuilder.CreateTable(
                name: "AD_MATRIZ_OPERACIONES",
                columns: table => new
                {
                    ID_MATRIZ = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: false),
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    CLASE_REGISTRO = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    CLASE_MODIFICACION = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    CLASE_GRUPO = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    MODO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_MENSAJES_ERROR",
                columns: table => new
                {
                    PREFIJO = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: false),
                    NUMERO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    MENSAJE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    ACCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_NOTICIAS",
                columns: table => new
                {
                    FECHA_INICIO_VIGENCIA = table.Column<DateTime>(type: "DATE", nullable: false),
                    FECHA_FIN_VIGENCIA = table.Column<DateTime>(type: "DATE", nullable: true),
                    DE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    PARA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    ASUNTO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: false),
                    PRIORIDAD = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    CONTENIDO = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: false),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_NUMEROS_ENTRADA",
                columns: table => new
                {
                    ENTIDAD = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    EJERCICIO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: false),
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    NO_ENTRADA = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_OBJETOS_CIERRE",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_OBJETOS_CIERRE", x => x.OBJETO);
                });

            migrationBuilder.CreateTable(
                name: "AD_OPERACIONES_RESTRICTIVAS",
                columns: table => new
                {
                    OPERACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PARAMETROS",
                columns: table => new
                {
                    PARAMETRO = table.Column<string>(type: "CHAR(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    ETIQUETA = table.Column<string>(type: "CHAR(60)", unicode: false, fixedLength: true, maxLength: 60, nullable: false),
                    TIPO_DATO = table.Column<string>(type: "CHAR(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    LONGITUD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DECIMALES = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PARAMETROS_SISTEMA",
                columns: table => new
                {
                    PROPIETARIO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    TITULO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    INSTITUCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    PAIS = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    TASA_IMPUESTO = table.Column<decimal>(type: "NUMBER(8,4)", nullable: true),
                    CONTEXTO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    INTERFAZ_SEGURIDAD = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    GENERADOR_PREDICADOS = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    TABLESPACE_USUARIO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    TABLESPACE_TEMPORAL = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    DIAS_NOTICIA_RECIENTE = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    SERVIDOR_REPORTES = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    EMAIL_CONTACTO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    SERVIDOR_CORREO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIAS_EXPIRACION_CLAVES = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    DIAS_NOTIF_ANTES_EXP = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PERFILES",
                columns: table => new
                {
                    PERFIL = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: false),
                    NIVEL = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    PERFIL_PADRE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    TIPO_PERFIL = table.Column<string>(type: "VARCHAR2(240)", unicode: false, maxLength: 240, nullable: true),
                    OBJETO_RAIZ = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: true),
                    PERFIL_ADMINISTRATIVO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PERF_PK", x => x.PERFIL);
                });

            migrationBuilder.CreateTable(
                name: "AD_PERFILES_COLUMNAS",
                columns: table => new
                {
                    ID_COLUMNA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    PERFIL = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    VERIFICA_ESTADO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PERFILES_FUNCION",
                columns: table => new
                {
                    PERFIL = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    FUNCION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    RESTRICTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    PERFIL_APLICACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PERFILES_USUARIO",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    PERFIL = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    PERFIL_APLICACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PISTA_OPERACIONES_ME",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    OPERACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    FECHA_OPERACION = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_PRIVILEGIOS",
                columns: table => new
                {
                    PRIVILEGIO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    SENTENCIA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    GENERABLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_PRIVILEGIOS", x => x.PRIVILEGIO);
                });

            migrationBuilder.CreateTable(
                name: "AD_PRIVILEGIOS_TIPO_OBJETO",
                columns: table => new
                {
                    PRIVILEGIO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    TIPO_OBJETO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_REPOSITORIO_REPORTES",
                columns: table => new
                {
                    REPORTE = table.Column<string>(type: "VARCHAR2(250)", unicode: false, maxLength: 250, nullable: true),
                    USUARIO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    DIRECTORIO_REPORTE = table.Column<string>(type: "VARCHAR2(250)", unicode: false, maxLength: 250, nullable: true),
                    FECHA_GENERACION = table.Column<DateTime>(type: "DATE", nullable: true),
                    DIAS_PRESENTACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    OBJETO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_TEMPO_COLUMNAS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    ALIAS = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    DATAFIELD = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: false),
                    HEADER_TEXT = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: false),
                    TAB_INDEX = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    TIPO_DATO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    CAMPO_LLAVE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    DATALIST = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    EXCLUIR_GRID = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    MOSTRAR_FILTRO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    LONGITUD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DECIMALES = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    PERMITIR_INSERT = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    PERMITIR_UPDATE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    SUMARIZABLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    EDITABLE_GRID = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    WIDTH = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    HEIGHT = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    WIDTH_ETIQUETA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    HEIGHT_ETIQUETA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    VALOR_INICIAL = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    AGREGAR_PARAMETRO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_TEMPO_COLUMNAS", x => new { x.OBJETO, x.ALIAS, x.DATAFIELD });
                });

            migrationBuilder.CreateTable(
                name: "AD_TEMPO_CONSULTAS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    ALIAS = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: false),
                    SELECT_STATEMENT = table.Column<string>(type: "CLOB", nullable: false),
                    TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    SECUENCIA_FETCH = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DEFAULT_WHERE = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DEFAULT_ORDERBY = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    MULTISELECT = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TEXTO_PARAMETROS = table.Column<string>(type: "VARCHAR2(250)", unicode: false, maxLength: 250, nullable: true),
                    OBJETO_REPOSITORIO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TABLA_BASE = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    LINK_EXPANDIR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    UTILIZA_FORMULAS = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    PAGINEAR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_TEMPO_CONSULTAS", x => new { x.OBJETO, x.ALIAS });
                });

            migrationBuilder.CreateTable(
                name: "AD_TEMPO_FILTROS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    CAMPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_TEMPO_FILTROS", x => new { x.OBJETO, x.CAMPO });
                });

            migrationBuilder.CreateTable(
                name: "AD_TEMPO_OBJETOS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    NOMBRE_LOGICO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: false),
                    NOMBRE_FISICO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    ETIQUETA = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    OBJETO_PADRE = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: true),
                    TIPO_OBJETO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    NIVEL = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    NUMERACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ORDEN_TABULACION = table.Column<int>(type: "NUMBER(9)", precision: 9, nullable: true),
                    IMAGEN_BOTON_ARRIBA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    IMAGEN_BOTON_SOBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OBJ_PK1", x => x.OBJETO);
                });

            migrationBuilder.CreateTable(
                name: "AD_TEMPORAL_ROWID",
                columns: table => new
                {
                    IDREGISTRO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_TIPOS_OBJETO",
                columns: table => new
                {
                    TIPO_OBJETO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(40)", unicode: false, maxLength: 40, nullable: false),
                    NOMBRE_FISICO = table.Column<string>(type: "VARCHAR2(40)", unicode: false, maxLength: 40, nullable: false),
                    OBJETO_BD = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_TIPOS_OBJETO", x => x.TIPO_OBJETO);
                });

            migrationBuilder.CreateTable(
                name: "AD_UNIDADES_ADMINISTRATIVAS",
                columns: table => new
                {
                    UNIDAD_ADMINISTRATIVA = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    MAA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    SIGLAS = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_USUARIOS_GRUPO",
                columns: table => new
                {
                    GRUPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    USUARIO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DTPROPERTIES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PROPERTY = table.Column<string>(type: "VARCHAR2(64)", unicode: false, maxLength: 64, nullable: false),
                    OBJECTID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true),
                    VALUE = table.Column<string>(type: "VARCHAR2(255)", unicode: false, maxLength: 255, nullable: true),
                    UVALUE = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    LVALUE = table.Column<byte[]>(type: "BLOB", nullable: true),
                    VERSION = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false, defaultValueSql: "0 ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTPROPERTIES", x => new { x.ID, x.PROPERTY });
                });

            migrationBuilder.CreateTable(
                name: "EQUIVALENCIAS",
                columns: table => new
                {
                    FRASE = table.Column<string>(type: "VARCHAR2(500)", unicode: false, maxLength: 500, nullable: false),
                    EQUIVALENCIA = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    TIPO_FRASE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MENU_FUNCIONES",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    NOMBRE_LOGICO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: false),
                    NOMBRE_FISICO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    ETIQUETA = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    OBJETO_PADRE = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: true),
                    TIPO_OBJETO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    NIVEL = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    NUMERACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ORDEN_TABULACION = table.Column<int>(type: "NUMBER(9)", precision: 9, nullable: true),
                    IMAGEN_BOTON_ARRIBA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    IMAGEN_BOTON_SOBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    AMBIENTE_DESARROLLO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    FUNCION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    NOMBRE_FUNCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "METFOREIGNKEYS",
                columns: table => new
                {
                    IDFK = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false),
                    KEYNO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    FOREIGN_KEY_NAME = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    CHILD_TABLE = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    CHILD_COLUMN = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true),
                    PARENT_TABLE = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    PARENT_COLUMN = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ORM__",
                columns: table => new
                {
                    DATABASEGUID = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRUEBA",
                columns: table => new
                {
                    PRUEBA = table.Column<string>(type: "CLOB", nullable: true),
                    CARACTER = table.Column<string>(type: "CLOB", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRUEBA1",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    ALIAS = table.Column<string>(type: "VARCHAR2(80)", unicode: false, maxLength: 80, nullable: false),
                    SELECT_STATEMENT = table.Column<string>(type: "CLOB", nullable: false),
                    TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    SECUENCIA_FETCH = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    DEFAULT_WHERE = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DEFAULT_ORDERBY = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    MULTISELECT = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TEXTO_PARAMETROS = table.Column<string>(type: "VARCHAR2(250)", unicode: false, maxLength: 250, nullable: true),
                    OBJETO_REPOSITORIO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TABLA_BASE = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    LINK_EXPANDIR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    UTILIZA_FORMULAS = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    PAGINEAR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "REPORTE",
                columns: table => new
                {
                    CODREP = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false),
                    CODIGO = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false),
                    NOMBRE = table.Column<string>(type: "CHAR(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "CHAR(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RESULTS",
                columns: table => new
                {
                    NIVEL_ESTRUCTURA = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: false),
                    EJERCICIO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: false),
                    ENTIDAD = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    PROGRAMA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    SUBPROGRAMA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    PROYECTO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    ACTOBRA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    NOM_ESTRUCTURA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    FUNCION = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    NO_PROYECTO = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    ENTIDAD_NS = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    PROGRAMA_NS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    SUBPROGRAMA_NS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PROYECTO_NS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    ACTOBRA_NS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: false),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: false),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    CLASE_GASTO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    Id = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ROLE",
                columns: table => new
                {
                    ID = table.Column<string>(type: "CHAR(36)", unicode: false, fixedLength: true, maxLength: 36, nullable: true),
                    NAME = table.Column<string>(type: "CHAR(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "CHAR(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_CAMPOS",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    TIPO_DATO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    DOMINIO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    LONGITUD = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    OBLIGATORIO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TABLA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    LLAVE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TIPO_CONTROL = table.Column<string>(type: "VARCHAR2(6)", unicode: false, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RT_CAMPOS", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "RT_CLASES_DE_REGISTROS",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    CLASE_DE_REGISTRO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    TABLA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_DOMINIOS",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    TIPO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    LONGITUD = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_ESTADOS",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    NOTAS = table.Column<string>(type: "CLOB", nullable: true),
                    DETABLA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    TABLA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    CLASE_DE_REGISTRO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_OPERACIONES",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    NOTAS = table.Column<string>(type: "CLOB", nullable: true),
                    DETABLA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    TABLA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    CLASE_DE_REGISTRO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_REGLAS",
                columns: table => new
                {
                    TID = table.Column<decimal>(type: "NUMBER(28)", nullable: false),
                    PATRON = table.Column<decimal>(type: "NUMBER(28)", nullable: true),
                    REGLA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    TIPO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    NOTAS = table.Column<string>(type: "CLOB", nullable: true),
                    REGLA_CONTENEDORA = table.Column<decimal>(type: "NUMBER(28)", nullable: true),
                    ORIGEN = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ORIGEN_AUTOR = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    ORIGEN_RESPONSABLE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    ORIGEN_FUENTE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    ESTATUS = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ACCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_SISTEMAS",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    SISTEMA = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    DUENO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    SUPERSISTEMA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RT_TABLAS",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    SINONIMO = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: false),
                    SISTEMA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    REPORTES = table.Column<string>(type: "CHAR(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    BITACORIZAR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RT_TABLAS", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "RT_TRANSICIONES",
                columns: table => new
                {
                    TID = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    OPERACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    ESTADO_INICIAL = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    ESTADO_FINAL = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    AUTOMATICA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SECUENCIAS",
                columns: table => new
                {
                    TIPO_OBJETO = table.Column<string>(type: "CHAR(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    ANIO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    CORRELATIVO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SEQS",
                columns: table => new
                {
                    SECUENCIA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    VALOR = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEQS", x => x.SECUENCIA);
                });

            migrationBuilder.CreateTable(
                name: "SEQUENCES",
                columns: table => new
                {
                    SEQ = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    SEQUENCE_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SEQUENCES__07CCE17F", x => x.SEQ);
                });

            migrationBuilder.CreateTable(
                name: "SG_DETALLE_BITACORA",
                columns: table => new
                {
                    ID_DETALLE = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false),
                    ID_ENC = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true),
                    NOMBRE_CAMPO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    VALOR_ANTERIOR = table.Column<string>(type: "VARCHAR2(2048)", unicode: false, maxLength: 2048, nullable: true),
                    VALOR_NUEVO = table.Column<string>(type: "VARCHAR2(2048)", unicode: false, maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SG_ENCBITACORA",
                columns: table => new
                {
                    ID_ENC = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false),
                    NOMBRE_TABLA = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    OPERACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    LLAVE_FILA = table.Column<string>(type: "VARCHAR2(500)", unicode: false, maxLength: 500, nullable: true),
                    CAMPOS_PK = table.Column<string>(type: "VARCHAR2(1000)", unicode: false, maxLength: 1000, nullable: true),
                    USUARIO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "DATE", nullable: true),
                    ID_OPERACION = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true),
                    USUARIO_BDD = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SG_OPERACIONES",
                columns: table => new
                {
                    ID_OPERACION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    NOMBRE_OPERACION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    USUARIO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_OPERACION = table.Column<DateTime>(type: "DATE", nullable: true),
                    USUARIO_BDD = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FECHA_FIN_OPERACION = table.Column<DateTime>(type: "DATE", nullable: true),
                    TIEMPO_OPERACION_BDD = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SG_OPERACIONES", x => x.ID_OPERACION);
                });

            migrationBuilder.CreateTable(
                name: "SG_REPORTES",
                columns: table => new
                {
                    REPORTE = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    FECHA_INICIO = table.Column<DateTime>(type: "DATE", nullable: true),
                    FECHA_FIN = table.Column<DateTime>(type: "DATE", nullable: true),
                    USUARIO = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    FILTRO = table.Column<string>(type: "NCLOB", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TEMP",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    PUESTO = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: false),
                    TELEFONO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    UBICACION = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: true),
                    DIRECCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ULT_FEC_CAMBIO_CLAVE = table.Column<DateTime>(type: "DATE", nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ULT_LOGIN = table.Column<DateTime>(type: "DATE", nullable: true),
                    ESTADO_LOGIN = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PASSWORD = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    GRUPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "DATE", nullable: false),
                    SESION_MULTIPLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    CAMBIA_CLAVE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    USUARIO_SUPERVISA = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    NIT = table.Column<string>(type: "VARCHAR2(12)", unicode: false, maxLength: 12, nullable: true),
                    ACCESO_SISTEMAS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    FECHA_EGRESO = table.Column<DateTime>(type: "DATE", nullable: true),
                    RESPALDO_EGRESO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_INGRESO = table.Column<DateTime>(type: "DATE", nullable: true),
                    RESPONSABLE_SUPERIOR = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    PUESTO_RESPONSABLE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    UNIDAD_ADMINISTRATIVA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TEMP_USUARIOS",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TIPO_REPORTE",
                columns: table => new
                {
                    CODIGO = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true),
                    NOMBRE = table.Column<string>(type: "CHAR(25)", unicode: false, fixedLength: true, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UDT",
                columns: table => new
                {
                    FIRMA = table.Column<byte[]>(type: "RAW(8)", maxLength: 8, nullable: true),
                    D_NOTAS = table.Column<string>(type: "CLOB", nullable: true),
                    FECHA_CORTA = table.Column<DateTime>(type: "DATE", nullable: true),
                    FECHA = table.Column<DateTime>(type: "DATE", nullable: true),
                    TIPO_CONTRIBUYENTE = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: true),
                    MES = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    ZONA = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    UNIDAD_MEDIDA = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    TRIMESTRE = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: true),
                    TIPO_PRESUPUESTO = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    TIPO_PERSONAL = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    TIPO_FIANZA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    TIPO_DOCUMENTO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    TIPO_CUENTA = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: true),
                    TIPO_CONTRATO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    TASA_CAMBIO = table.Column<decimal>(type: "NUMBER(13,6)", nullable: true),
                    SUCURSAL = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    SUBPROGRAMA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    SUBCUENTA = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    SIGNO = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    SEMANA = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: true),
                    SECUENCIA = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true),
                    SECTOR = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    REGION = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    RECURSO_AUX = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    RECURSO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    RECAUDACION = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PROYECTO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PROGRAMA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PARTIDA_AUX = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    PARTIDA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PAIS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    ORIGEN_CUENTA = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    ORGANISMO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    OPERACION_BANCO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    NUMERO_CORTO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    NUMERO = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: true),
                    NO_RESPALDO = table.Column<long>(type: "NUMBER(12)", precision: 12, nullable: true),
                    NO_ORIGINAL = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    NO_MATRIZ = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    NO_FONDO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    NO_ENTRADA = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    NO_DEPOSITO = table.Column<long>(type: "NUMBER(12)", precision: 12, nullable: true),
                    NO_CUR = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    NO_CRITERIO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    NIVEL_INSTITUCIONAL = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: true),
                    NIVEL_ESTRUCTURA = table.Column<bool>(type: "NUMBER(1)", precision: 1, nullable: true),
                    MONTO = table.Column<decimal>(type: "NUMBER(13,2)", nullable: true),
                    MONEDA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    META = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    MAYOR = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    GRUPO_INGRESO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    GRUPO_GASTO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    GEOGRAFICO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    FUNCION = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    FUENTE = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    FORMA_PAGO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    ERROR_HOJA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    ENTIDAD_RECEPTORA = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    ENTIDAD = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    EJERCICIO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    ECONOMICO = table.Column<int>(type: "NUMBER(7)", precision: 7, nullable: true),
                    DISPOSICION_LEGAL = table.Column<long>(type: "NUMBER(12)", precision: 12, nullable: true),
                    DIA = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    DEUDA = table.Column<long>(type: "NUMBER(15)", precision: 15, nullable: true),
                    DEDUCCION = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    D_LLAVE = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    CUENTA = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    CONCEPTO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    CLASE_CORRESPONDENCIA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    CLASE_CONTRATO = table.Column<byte>(type: "NUMBER(4)", precision: 4, nullable: true),
                    CLASE_AUX = table.Column<byte>(type: "NUMBER(2)", precision: 2, nullable: true),
                    CATEGORIA = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: true),
                    CANTIDAD = table.Column<decimal>(type: "NUMBER(16,5)", nullable: true),
                    BANCO = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    ASPECTO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    ACTOBRA = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    USUARIO = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    TOTAL_DETALLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TIPO_VALOR = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    TIPO_CATEGORIA = table.Column<string>(type: "VARCHAR2(3)", unicode: false, maxLength: 3, nullable: true),
                    TELEFONO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    SINO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    SIGLA = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    SI_PROYECTO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    SI_CUENTA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    REGIMEN_IVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    OBSERVACIONES = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    OBJETIVOS = table.Column<string>(type: "VARCHAR2(2000)", unicode: false, maxLength: 2000, nullable: true),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    NO_FACTURA = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    NO_COMPROBANTE = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    NIT = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    LUGAR_GASTO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    INSTANCIA = table.Column<string>(type: "VARCHAR2(3)", unicode: false, maxLength: 3, nullable: true),
                    INGRESO_GASTO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    GRUPO_CUENTA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    GASTO_INGRESO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    FACTURA = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    ESTADO_FONDO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ESTADO_FISCAL = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR2(45)", unicode: false, maxLength: 45, nullable: true),
                    DIRECCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    DEBITO_CREDITO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    D_TIPO_DATO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    D_SISTEMA = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: true),
                    D_SINONIMO = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: true),
                    D_SINO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    D_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    D_NOMBRE_MEDIO = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: true),
                    D_NOMBRE_CORTO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    D_LONGITUD = table.Column<string>(type: "VARCHAR2(10)", unicode: false, maxLength: 10, nullable: true),
                    D_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    D_DESCRIPCION_MEDIA = table.Column<string>(type: "VARCHAR2(300)", unicode: false, maxLength: 300, nullable: true),
                    D_DESCRIPCION_CORTA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    D_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    CUENTA_MONETARIA = table.Column<string>(type: "VARCHAR2(15)", unicode: false, maxLength: 15, nullable: true),
                    CONTENIDO = table.Column<string>(type: "VARCHAR2(2000)", unicode: false, maxLength: 2000, nullable: true),
                    CLASE_REGISTRO = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: true),
                    CLASE_MODIFICACION = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: true),
                    CLASE_GRUPO = table.Column<string>(type: "VARCHAR2(4)", unicode: false, maxLength: 4, nullable: true),
                    CAIF = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    AUMENTO_DISMINUCION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AD_FUNCIONES_USUARIO",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: false),
                    FUNCION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    RESTRICTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_FUNCIONES_USUARIO", x => new { x.USUARIO, x.FUNCION });
                    table.ForeignKey(
                        name: "FK_AD_FUNCIONES_USUARIO_AD_FUN",
                        column: x => x.FUNCION,
                        principalTable: "AD_FUNCIONES",
                        principalColumn: "FUNCION");
                });

            migrationBuilder.CreateTable(
                name: "AD_GRUPOS_FUNCION",
                columns: table => new
                {
                    FUNCION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    GRUPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    RESTRICTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_GRUPOS_FUNCION", x => new { x.FUNCION, x.GRUPO });
                    table.ForeignKey(
                        name: "FK_AD_GRUPOS_FUNCION_AD_FUNCIO",
                        column: x => x.FUNCION,
                        principalTable: "AD_FUNCIONES",
                        principalColumn: "FUNCION");
                    table.ForeignKey(
                        name: "FK_AD_GRUPOS_FUNCION_AD_GRUPOS",
                        column: x => x.GRUPO,
                        principalTable: "AD_GRUPOS",
                        principalColumn: "GRUPO");
                });

            migrationBuilder.CreateTable(
                name: "AD_USUARIOS",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    NOMBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: false),
                    PUESTO = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: false),
                    TELEFONO = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    UBICACION = table.Column<string>(type: "VARCHAR2(60)", unicode: false, maxLength: 60, nullable: true),
                    DIRECCION = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    ULT_FEC_CAMBIO_CLAVE = table.Column<DateTime>(type: "DATE", nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ULT_LOGIN = table.Column<DateTime>(type: "DATE", nullable: true),
                    ESTADO_LOGIN = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    PASSWORD = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    PASSWORD2 = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    GRUPO = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    SESION_MULTIPLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    CAMBIA_CLAVE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR2(50)", unicode: false, maxLength: 50, nullable: true),
                    USUARIO_SUPERVISA = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    NIT = table.Column<string>(type: "VARCHAR2(12)", unicode: false, maxLength: 12, nullable: true),
                    ACCESO_SISTEMAS = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: true),
                    FECHA_EGRESO = table.Column<DateTime>(type: "DATE", nullable: true),
                    RESPALDO_EGRESO = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_INGRESO = table.Column<DateTime>(type: "DATE", nullable: true),
                    RESPONSABLE_SUPERIOR = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    PUESTO_RESPONSABLE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    UNIDAD_ADMINISTRATIVA = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: true),
                    ACEPTACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "DATE", nullable: false),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_USUARIOS", x => x.USUARIO);
                    table.ForeignKey(
                        name: "FK_AD_USUARIOS_AD_GRUPOS",
                        column: x => x.GRUPO,
                        principalTable: "AD_GRUPOS",
                        principalColumn: "GRUPO");
                });

            migrationBuilder.CreateTable(
                name: "AD_GRANTS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    PERFIL = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: false),
                    PRIVILEGIO = table.Column<int>(type: "NUMBER(6)", precision: 6, nullable: false),
                    GRANTEABLE = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    MODO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: false),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_GRANTS", x => new { x.OBJETO, x.PERFIL, x.PRIVILEGIO });
                    table.ForeignKey(
                        name: "FK_AD_GRANTS_AD_PERFILES",
                        column: x => x.PERFIL,
                        principalTable: "AD_PERFILES",
                        principalColumn: "PERFIL");
                    table.ForeignKey(
                        name: "FK_AD_GRANTS_AD_PRIVILEGIOS",
                        column: x => x.PRIVILEGIO,
                        principalTable: "AD_PRIVILEGIOS",
                        principalColumn: "PRIVILEGIO");
                });

            migrationBuilder.CreateTable(
                name: "AD_OBJETOS",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    NOMBRE_LOGICO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: false),
                    NOMBRE_FISICO = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    ETIQUETA = table.Column<string>(type: "VARCHAR2(150)", unicode: false, maxLength: 150, nullable: true),
                    OBJETO_PADRE = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: true),
                    TIPO_OBJETO = table.Column<short>(type: "NUMBER(5)", precision: 5, nullable: true),
                    NIVEL = table.Column<byte>(type: "NUMBER(3)", precision: 3, nullable: false),
                    NUMERACION = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ORDEN_TABULACION = table.Column<int>(type: "NUMBER(9)", precision: 9, nullable: true),
                    IMAGEN_BOTON_ARRIBA = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    IMAGEN_BOTON_SOBRE = table.Column<string>(type: "VARCHAR2(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECTIVA = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true),
                    ME_CLASE = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true),
                    ME_OPERACION = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true, defaultValueSql: "0"),
                    ME_ESTADO = table.Column<string>(type: "VARCHAR2(30)", unicode: false, maxLength: 30, nullable: true, defaultValueSql: "'A'"),
                    FEC_ING = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ING = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    FEC_ACT = table.Column<DateTime>(type: "DATE", nullable: true),
                    USERID_ACT = table.Column<string>(type: "VARCHAR2(20)", unicode: false, maxLength: 20, nullable: true),
                    AMBIENTE_DESARROLLO = table.Column<string>(type: "VARCHAR2(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OBJ_PK", x => x.OBJETO);
                    table.ForeignKey(
                        name: "FK_AD_OBJETOS_AD_TIPOS_OBJETO",
                        column: x => x.TIPO_OBJETO,
                        principalTable: "AD_TIPOS_OBJETO",
                        principalColumn: "TIPO_OBJETO");
                    table.ForeignKey(
                        name: "FK__AD_OBJETO__OBJET__39E294A9",
                        column: x => x.OBJETO_PADRE,
                        principalTable: "AD_OBJETOS",
                        principalColumn: "OBJETO");
                });

            migrationBuilder.CreateTable(
                name: "AD_DEFWHERE_FUNCION",
                columns: table => new
                {
                    OBJETO = table.Column<string>(type: "VARCHAR2(9)", unicode: false, maxLength: 9, nullable: false),
                    FUNCION = table.Column<long>(type: "NUMBER(18)", precision: 18, nullable: false),
                    DEFAULT_WHERE = table.Column<string>(type: "VARCHAR2(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AD_DEFWHERE_FUNCION", x => new { x.OBJETO, x.FUNCION });
                    table.ForeignKey(
                        name: "FK_AD_DEFWHERE_FUNCION_AD_OBJE",
                        column: x => x.OBJETO,
                        principalTable: "AD_OBJETOS",
                        principalColumn: "OBJETO");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AD_COLUMNAS",
                table: "AD_COLUMNAS",
                columns: new[] { "OBJETO", "ALIAS" });

            migrationBuilder.CreateIndex(
                name: "IX_AD_COLUMNAS_1",
                table: "AD_COLUMNAS",
                column: "OBJETO");

            migrationBuilder.CreateIndex(
                name: "IX_AD_COLUMNAS_2",
                table: "AD_COLUMNAS",
                column: "DATAFIELD");

            migrationBuilder.CreateIndex(
                name: "DTA_INDEX_AD_FUNCIONES_USUARIO",
                table: "AD_FUNCIONES_USUARIO",
                columns: new[] { "USUARIO", "RESTRICTIVA" });

            migrationBuilder.CreateIndex(
                name: "IX_AD_FUNCIONES_USUARIO_FUNCION",
                table: "AD_FUNCIONES_USUARIO",
                column: "FUNCION");

            migrationBuilder.CreateIndex(
                name: "DTA_INDEX_AD_GRANTS_5_20368513",
                table: "AD_GRANTS",
                columns: new[] { "OBJETO", "MODO" });

            migrationBuilder.CreateIndex(
                name: "IX_AD_GRANTS",
                table: "AD_GRANTS",
                column: "OBJETO");

            migrationBuilder.CreateIndex(
                name: "IX_AD_GRANTS_1",
                table: "AD_GRANTS",
                column: "PERFIL");

            migrationBuilder.CreateIndex(
                name: "IX_AD_GRANTS_2",
                table: "AD_GRANTS",
                column: "PRIVILEGIO");

            migrationBuilder.CreateIndex(
                name: "IX_AD_GRUPOS_FUNCION_GRUPO",
                table: "AD_GRUPOS_FUNCION",
                column: "GRUPO");

            migrationBuilder.CreateIndex(
                name: "DTA_INDEX_AD_INSTANCIAS_OPER_1",
                table: "AD_INSTANCIAS_OPERACION",
                columns: new[] { "OPERACION", "GRUPO", "VALOR", "TIPO_PREDICADO" });

            migrationBuilder.CreateIndex(
                name: "IX_AD_MAPEO_OBJETOS",
                table: "AD_MAPEO_OBJETOS",
                column: "OBJETO_INICIAL");

            migrationBuilder.CreateIndex(
                name: "IX_AD_MAPEO_OBJETOS_1",
                table: "AD_MAPEO_OBJETOS",
                column: "OBJETO_FINAL");

            migrationBuilder.CreateIndex(
                name: "DTA_INDEX_AD_OBJETOS_5_26795_1",
                table: "AD_OBJETOS",
                columns: new[] { "OBJETO", "NOMBRE_LOGICO", "NOMBRE_FISICO", "ETIQUETA", "OBJETO_PADRE", "TIPO_OBJETO", "NIVEL", "ORDEN_TABULACION" });

            migrationBuilder.CreateIndex(
                name: "DTA_INDEX_AD_OBJETOS_5_26795_2",
                table: "AD_OBJETOS",
                columns: new[] { "OBJETO", "NOMBRE_LOGICO", "NOMBRE_FISICO", "ETIQUETA", "OBJETO_PADRE", "TIPO_OBJETO", "NIVEL", "ORDEN_TABULACION", "IMAGEN_BOTON_ARRIBA", "IMAGEN_BOTON_SOBRE" });

            migrationBuilder.CreateIndex(
                name: "IX_AD_OBJETOS",
                table: "AD_OBJETOS",
                column: "OBJETO_PADRE");

            migrationBuilder.CreateIndex(
                name: "IX_AD_OBJETOS_TIPO_OBJETO",
                table: "AD_OBJETOS",
                column: "TIPO_OBJETO");

            migrationBuilder.CreateIndex(
                name: "IX_AD_USUARIOS_GRUPO",
                table: "AD_USUARIOS",
                column: "GRUPO");

            migrationBuilder.CreateIndex(
                name: "IX_RT_CAMPOS",
                table: "RT_CAMPOS",
                column: "TABLA");

            migrationBuilder.CreateIndex(
                name: "IX_RT_CAMPOS_1",
                table: "RT_CAMPOS",
                column: "NOMBRE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AD_CAMPOS_MATRIZ");

            migrationBuilder.DropTable(
                name: "AD_CAMPOS_OPERACION_RES");

            migrationBuilder.DropTable(
                name: "AD_CHEQUES_CABECERA");

            migrationBuilder.DropTable(
                name: "AD_CHEQUES_DETALLE");

            migrationBuilder.DropTable(
                name: "AD_CLASES_IDENTIFICADORES");

            migrationBuilder.DropTable(
                name: "AD_COLUMNAS");

            migrationBuilder.DropTable(
                name: "AD_CONSULTAS");

            migrationBuilder.DropTable(
                name: "AD_DEFINICION_PARAMETROS");

            migrationBuilder.DropTable(
                name: "AD_DEFWHERE_FUNCION");

            migrationBuilder.DropTable(
                name: "AD_ERRORES");

            migrationBuilder.DropTable(
                name: "AD_FILTROS");

            migrationBuilder.DropTable(
                name: "AD_FORMULAS");

            migrationBuilder.DropTable(
                name: "AD_FUNCIONES_USUARIO");

            migrationBuilder.DropTable(
                name: "AD_GRANTS");

            migrationBuilder.DropTable(
                name: "AD_GRUPOS_FUNCION");

            migrationBuilder.DropTable(
                name: "AD_HUELLAS");

            migrationBuilder.DropTable(
                name: "AD_INSTANCIAS_OPERACION");

            migrationBuilder.DropTable(
                name: "AD_LISTAS_VALORES");

            migrationBuilder.DropTable(
                name: "AD_MAPEO_OBJETOS");

            migrationBuilder.DropTable(
                name: "AD_MATRIZ_OPERACIONES");

            migrationBuilder.DropTable(
                name: "AD_MENSAJES_ERROR");

            migrationBuilder.DropTable(
                name: "AD_NOTICIAS");

            migrationBuilder.DropTable(
                name: "AD_NUMEROS_ENTRADA");

            migrationBuilder.DropTable(
                name: "AD_OBJETOS_CIERRE");

            migrationBuilder.DropTable(
                name: "AD_OPERACIONES_RESTRICTIVAS");

            migrationBuilder.DropTable(
                name: "AD_PARAMETROS");

            migrationBuilder.DropTable(
                name: "AD_PARAMETROS_SISTEMA");

            migrationBuilder.DropTable(
                name: "AD_PERFILES_COLUMNAS");

            migrationBuilder.DropTable(
                name: "AD_PERFILES_FUNCION");

            migrationBuilder.DropTable(
                name: "AD_PERFILES_USUARIO");

            migrationBuilder.DropTable(
                name: "AD_PISTA_OPERACIONES_ME");

            migrationBuilder.DropTable(
                name: "AD_PRIVILEGIOS_TIPO_OBJETO");

            migrationBuilder.DropTable(
                name: "AD_REPOSITORIO_REPORTES");

            migrationBuilder.DropTable(
                name: "AD_TEMPO_COLUMNAS");

            migrationBuilder.DropTable(
                name: "AD_TEMPO_CONSULTAS");

            migrationBuilder.DropTable(
                name: "AD_TEMPO_FILTROS");

            migrationBuilder.DropTable(
                name: "AD_TEMPO_OBJETOS");

            migrationBuilder.DropTable(
                name: "AD_TEMPORAL_ROWID");

            migrationBuilder.DropTable(
                name: "AD_UNIDADES_ADMINISTRATIVAS");

            migrationBuilder.DropTable(
                name: "AD_USUARIOS");

            migrationBuilder.DropTable(
                name: "AD_USUARIOS_GRUPO");

            migrationBuilder.DropTable(
                name: "DTPROPERTIES");

            migrationBuilder.DropTable(
                name: "EQUIVALENCIAS");

            migrationBuilder.DropTable(
                name: "MENU_FUNCIONES");

            migrationBuilder.DropTable(
                name: "METFOREIGNKEYS");

            migrationBuilder.DropTable(
                name: "ORM__");

            migrationBuilder.DropTable(
                name: "PRUEBA");

            migrationBuilder.DropTable(
                name: "PRUEBA1");

            migrationBuilder.DropTable(
                name: "REPORTE");

            migrationBuilder.DropTable(
                name: "RESULTS");

            migrationBuilder.DropTable(
                name: "ROLE");

            migrationBuilder.DropTable(
                name: "RT_CAMPOS");

            migrationBuilder.DropTable(
                name: "RT_CLASES_DE_REGISTROS");

            migrationBuilder.DropTable(
                name: "RT_DOMINIOS");

            migrationBuilder.DropTable(
                name: "RT_ESTADOS");

            migrationBuilder.DropTable(
                name: "RT_OPERACIONES");

            migrationBuilder.DropTable(
                name: "RT_REGLAS");

            migrationBuilder.DropTable(
                name: "RT_SISTEMAS");

            migrationBuilder.DropTable(
                name: "RT_TABLAS");

            migrationBuilder.DropTable(
                name: "RT_TRANSICIONES");

            migrationBuilder.DropTable(
                name: "SECUENCIAS");

            migrationBuilder.DropTable(
                name: "SEQS");

            migrationBuilder.DropTable(
                name: "SEQUENCES");

            migrationBuilder.DropTable(
                name: "SG_DETALLE_BITACORA");

            migrationBuilder.DropTable(
                name: "SG_ENCBITACORA");

            migrationBuilder.DropTable(
                name: "SG_OPERACIONES");

            migrationBuilder.DropTable(
                name: "SG_REPORTES");

            migrationBuilder.DropTable(
                name: "TEMP");

            migrationBuilder.DropTable(
                name: "TEMP_USUARIOS");

            migrationBuilder.DropTable(
                name: "TIPO_REPORTE");

            migrationBuilder.DropTable(
                name: "UDT");

            migrationBuilder.DropTable(
                name: "AD_OBJETOS");

            migrationBuilder.DropTable(
                name: "AD_PERFILES");

            migrationBuilder.DropTable(
                name: "AD_PRIVILEGIOS");

            migrationBuilder.DropTable(
                name: "AD_FUNCIONES");

            migrationBuilder.DropTable(
                name: "AD_GRUPOS");

            migrationBuilder.DropTable(
                name: "AD_TIPOS_OBJETO");
        }
    }
}
