using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class UdtConfiguracion : IEntityTypeConfiguration<Udt>
    {
        public void Configure(EntityTypeBuilder<Udt> builder)
        {
            builder
                .HasNoKey()
                .ToTable("UDT");

            builder.Property(e => e.Actobra)
                .HasPrecision(3)
                .HasColumnName("ACTOBRA");
            builder.Property(e => e.Aspecto)
                .HasPrecision(5)
                .HasColumnName("ASPECTO");
            builder.Property(e => e.AumentoDisminucion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUMENTO_DISMINUCION");
            builder.Property(e => e.Banco)
                .HasPrecision(3)
                .HasColumnName("BANCO");
            builder.Property(e => e.Caif)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAIF");
            builder.Property(e => e.Cantidad)
                .HasColumnType("NUMBER(16,5)")
                .HasColumnName("CANTIDAD");
            builder.Property(e => e.Categoria)
                .HasPrecision(6)
                .HasColumnName("CATEGORIA");
            builder.Property(e => e.ClaseAux)
                .HasPrecision(2)
                .HasColumnName("CLASE_AUX");
            builder.Property(e => e.ClaseContrato)
                .HasPrecision(4)
                .HasColumnName("CLASE_CONTRATO");
            builder.Property(e => e.ClaseCorrespondencia)
                .HasPrecision(3)
                .HasColumnName("CLASE_CORRESPONDENCIA");
            builder.Property(e => e.ClaseGrupo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLASE_GRUPO");
            builder.Property(e => e.ClaseModificacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLASE_MODIFICACION");
            builder.Property(e => e.ClaseRegistro)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CLASE_REGISTRO");
            builder.Property(e => e.Concepto)
                .HasPrecision(4)
                .HasColumnName("CONCEPTO");
            builder.Property(e => e.Contenido)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CONTENIDO");
            builder.Property(e => e.Cuenta)
                .HasPrecision(2)
                .HasColumnName("CUENTA");
            builder.Property(e => e.CuentaMonetaria)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUENTA_MONETARIA");
            builder.Property(e => e.DClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_CLASE");
            builder.Property(e => e.DDescripcionCorta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("D_DESCRIPCION_CORTA");
            builder.Property(e => e.DDescripcionMedia)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("D_DESCRIPCION_MEDIA");
            builder.Property(e => e.DEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_ESTADO");
            builder.Property(e => e.DLlave)
                .HasPrecision(18)
                .HasColumnName("D_LLAVE");
            builder.Property(e => e.DLongitud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("D_LONGITUD");
            builder.Property(e => e.DNombreCorto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_NOMBRE_CORTO");
            builder.Property(e => e.DNombreMedio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("D_NOMBRE_MEDIO");
            builder.Property(e => e.DNotas)
                .HasColumnType("CLOB")
                .HasColumnName("D_NOTAS");
            builder.Property(e => e.DOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("D_OPERACION");
            builder.Property(e => e.DSino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("D_SINO");
            builder.Property(e => e.DSinonimo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("D_SINONIMO");
            builder.Property(e => e.DSistema)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("D_SISTEMA");
            builder.Property(e => e.DTipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("D_TIPO_DATO");
            builder.Property(e => e.DebitoCredito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEBITO_CREDITO");
            builder.Property(e => e.Deduccion)
                .HasPrecision(3)
                .HasColumnName("DEDUCCION");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Deuda)
                .HasPrecision(15)
                .HasColumnName("DEUDA");
            builder.Property(e => e.Dia)
                .HasPrecision(2)
                .HasColumnName("DIA");
            builder.Property(e => e.Direccion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            builder.Property(e => e.DisposicionLegal)
                .HasPrecision(12)
                .HasColumnName("DISPOSICION_LEGAL");
            builder.Property(e => e.Economico)
                .HasPrecision(7)
                .HasColumnName("ECONOMICO");
            builder.Property(e => e.Ejercicio)
                .HasPrecision(4)
                .HasColumnName("EJERCICIO");
            builder.Property(e => e.Email)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            builder.Property(e => e.Entidad)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD");
            builder.Property(e => e.EntidadReceptora)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD_RECEPTORA");
            builder.Property(e => e.ErrorHoja)
                .HasPrecision(3)
                .HasColumnName("ERROR_HOJA");
            builder.Property(e => e.EstadoFiscal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO_FISCAL");
            builder.Property(e => e.EstadoFondo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO_FONDO");
            builder.Property(e => e.Factura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FACTURA");
            builder.Property(e => e.Fecha)
                .HasColumnType("DATE")
                .HasColumnName("FECHA");
            builder.Property(e => e.FechaCorta)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_CORTA");
            builder.Property(e => e.Firma)
                .HasMaxLength(8)
                .HasColumnName("FIRMA");
            builder.Property(e => e.FormaPago)
                .HasPrecision(3)
                .HasColumnName("FORMA_PAGO");
            builder.Property(e => e.Fuente)
                .HasPrecision(2)
                .HasColumnName("FUENTE");
            builder.Property(e => e.Funcion)
                .HasPrecision(3)
                .HasColumnName("FUNCION");
            builder.Property(e => e.GastoIngreso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GASTO_INGRESO");
            builder.Property(e => e.Geografico)
                .HasPrecision(4)
                .HasColumnName("GEOGRAFICO");
            builder.Property(e => e.GrupoCuenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GRUPO_CUENTA");
            builder.Property(e => e.GrupoGasto)
                .HasPrecision(3)
                .HasColumnName("GRUPO_GASTO");
            builder.Property(e => e.GrupoIngreso)
                .HasPrecision(5)
                .HasColumnName("GRUPO_INGRESO");
            builder.Property(e => e.IngresoGasto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("INGRESO_GASTO");
            builder.Property(e => e.Instancia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTANCIA");
            builder.Property(e => e.LugarGasto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LUGAR_GASTO");
            builder.Property(e => e.Mayor)
                .HasPrecision(4)
                .HasColumnName("MAYOR");
            builder.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            builder.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            builder.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            builder.Property(e => e.Mes)
                .HasPrecision(2)
                .HasColumnName("MES");
            builder.Property(e => e.Meta)
                .HasPrecision(3)
                .HasColumnName("META");
            builder.Property(e => e.Moneda)
                .HasPrecision(3)
                .HasColumnName("MONEDA");
            builder.Property(e => e.Monto)
                .HasColumnType("NUMBER(13,2)")
                .HasColumnName("MONTO");
            builder.Property(e => e.Nit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NIT");
            builder.Property(e => e.NivelEstructura)
                .HasPrecision(1)
                .HasColumnName("NIVEL_ESTRUCTURA");
            builder.Property(e => e.NivelInstitucional)
                .HasPrecision(1)
                .HasColumnName("NIVEL_INSTITUCIONAL");
            builder.Property(e => e.NoComprobante)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NO_COMPROBANTE");
            builder.Property(e => e.NoCriterio)
                .HasPrecision(6)
                .HasColumnName("NO_CRITERIO");
            builder.Property(e => e.NoCur)
                .HasPrecision(6)
                .HasColumnName("NO_CUR");
            builder.Property(e => e.NoDeposito)
                .HasPrecision(12)
                .HasColumnName("NO_DEPOSITO");
            builder.Property(e => e.NoEntrada)
                .HasPrecision(6)
                .HasColumnName("NO_ENTRADA");
            builder.Property(e => e.NoFactura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NO_FACTURA");
            builder.Property(e => e.NoFondo)
                .HasPrecision(6)
                .HasColumnName("NO_FONDO");
            builder.Property(e => e.NoMatriz)
                .HasPrecision(4)
                .HasColumnName("NO_MATRIZ");
            builder.Property(e => e.NoOriginal)
                .HasPrecision(6)
                .HasColumnName("NO_ORIGINAL");
            builder.Property(e => e.NoRespaldo)
                .HasPrecision(12)
                .HasColumnName("NO_RESPALDO");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Numero)
                .HasPrecision(10)
                .HasColumnName("NUMERO");
            builder.Property(e => e.NumeroCorto)
                .HasPrecision(4)
                .HasColumnName("NUMERO_CORTO");
            builder.Property(e => e.Objetivos)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OBJETIVOS");
            builder.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            builder.Property(e => e.OperacionBanco)
                .HasPrecision(3)
                .HasColumnName("OPERACION_BANCO");
            builder.Property(e => e.Organismo)
                .HasPrecision(6)
                .HasColumnName("ORGANISMO");
            builder.Property(e => e.OrigenCuenta)
                .HasPrecision(2)
                .HasColumnName("ORIGEN_CUENTA");
            builder.Property(e => e.Pais)
                .HasPrecision(3)
                .HasColumnName("PAIS");
            builder.Property(e => e.Partida)
                .HasPrecision(3)
                .HasColumnName("PARTIDA");
            builder.Property(e => e.PartidaAux)
                .HasPrecision(6)
                .HasColumnName("PARTIDA_AUX");
            builder.Property(e => e.Programa)
                .HasPrecision(3)
                .HasColumnName("PROGRAMA");
            builder.Property(e => e.Proyecto)
                .HasPrecision(3)
                .HasColumnName("PROYECTO");
            builder.Property(e => e.Recaudacion)
                .HasPrecision(3)
                .HasColumnName("RECAUDACION");
            builder.Property(e => e.Recurso)
                .HasPrecision(5)
                .HasColumnName("RECURSO");
            builder.Property(e => e.RecursoAux)
                .HasPrecision(2)
                .HasColumnName("RECURSO_AUX");
            builder.Property(e => e.RegimenIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REGIMEN_IVA");
            builder.Property(e => e.Region)
                .HasPrecision(2)
                .HasColumnName("REGION");
            builder.Property(e => e.Sector)
                .HasPrecision(3)
                .HasColumnName("SECTOR");
            builder.Property(e => e.Secuencia)
                .HasPrecision(10)
                .HasColumnName("SECUENCIA");
            builder.Property(e => e.Semana)
                .HasPrecision(1)
                .HasColumnName("SEMANA");
            builder.Property(e => e.SiCuenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SI_CUENTA");
            builder.Property(e => e.SiProyecto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SI_PROYECTO");
            builder.Property(e => e.Sigla)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SIGLA");
            builder.Property(e => e.Signo)
                .HasPrecision(2)
                .HasColumnName("SIGNO");
            builder.Property(e => e.Sino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SINO");
            builder.Property(e => e.Subcuenta)
                .HasPrecision(2)
                .HasColumnName("SUBCUENTA");
            builder.Property(e => e.Subprograma)
                .HasPrecision(3)
                .HasColumnName("SUBPROGRAMA");
            builder.Property(e => e.Sucursal)
                .HasPrecision(4)
                .HasColumnName("SUCURSAL");
            builder.Property(e => e.TasaCambio)
                .HasColumnType("NUMBER(13,6)")
                .HasColumnName("TASA_CAMBIO");
            builder.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            builder.Property(e => e.TipoCategoria)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPO_CATEGORIA");
            builder.Property(e => e.TipoContrato)
                .HasPrecision(3)
                .HasColumnName("TIPO_CONTRATO");
            builder.Property(e => e.TipoContribuyente)
                .HasPrecision(1)
                .HasColumnName("TIPO_CONTRIBUYENTE");
            builder.Property(e => e.TipoCuenta)
                .HasPrecision(1)
                .HasColumnName("TIPO_CUENTA");
            builder.Property(e => e.TipoDocumento)
                .HasPrecision(3)
                .HasColumnName("TIPO_DOCUMENTO");
            builder.Property(e => e.TipoFianza)
                .HasPrecision(3)
                .HasColumnName("TIPO_FIANZA");
            builder.Property(e => e.TipoPersonal)
                .HasPrecision(2)
                .HasColumnName("TIPO_PERSONAL");
            builder.Property(e => e.TipoPresupuesto)
                .HasPrecision(2)
                .HasColumnName("TIPO_PRESUPUESTO");
            builder.Property(e => e.TipoValor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_VALOR");
            builder.Property(e => e.TotalDetalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TOTAL_DETALLE");
            builder.Property(e => e.Trimestre)
                .HasPrecision(1)
                .HasColumnName("TRIMESTRE");
            builder.Property(e => e.UnidadMedida)
                .HasPrecision(4)
                .HasColumnName("UNIDAD_MEDIDA");
            builder.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            builder.Property(e => e.Zona)
                .HasPrecision(2)
                .HasColumnName("ZONA")
                .HasColumnName("ZONA");
        }
    }
}
