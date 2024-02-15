using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdParametrosSistemaConfiguracion : IEntityTypeConfiguration<AdParametrosSistema>
    {
        public void Configure(EntityTypeBuilder<AdParametrosSistema> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_PARAMETROS_SISTEMA");

            builder.Property(e => e.Contexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTEXTO");
            builder.Property(e => e.DiasExpiracionClaves)
                .HasPrecision(4)
                .HasColumnName("DIAS_EXPIRACION_CLAVES");
            builder.Property(e => e.DiasNoticiaReciente)
                .HasPrecision(5)
                .HasColumnName("DIAS_NOTICIA_RECIENTE");
            builder.Property(e => e.DiasNotifAntesExp)
                .HasPrecision(2)
                .HasColumnName("DIAS_NOTIF_ANTES_EXP");
            builder.Property(e => e.EmailContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL_CONTACTO");
            builder.Property(e => e.GeneradorPredicados)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENERADOR_PREDICADOS");
            builder.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INSTITUCION");
            builder.Property(e => e.InterfazSeguridad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INTERFAZ_SEGURIDAD");
            builder.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAIS");
            builder.Property(e => e.Propietario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO");
            builder.Property(e => e.ServidorCorreo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERVIDOR_CORREO");
            builder.Property(e => e.ServidorReportes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERVIDOR_REPORTES");
            builder.Property(e => e.TablespaceTemporal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLESPACE_TEMPORAL");
            builder.Property(e => e.TablespaceUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLESPACE_USUARIO");
            builder.Property(e => e.TasaImpuesto)
                .HasColumnType("NUMBER(8,4)")
                .HasColumnName("TASA_IMPUESTO");
            builder.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITULO");
        }
    }
}
