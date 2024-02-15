using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdMensajesErrorConfiguracion : IEntityTypeConfiguration<AdMensajesError>
    {
        public void Configure(EntityTypeBuilder<AdMensajesError> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_MENSAJES_ERROR");

            builder.Property(e => e.Accion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ACCION");
            builder.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            builder.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
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
            builder.Property(e => e.Mensaje)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MENSAJE");
            builder.Property(e => e.Numero)
                .HasPrecision(6)
                .HasColumnName("NUMERO");
            builder.Property(e => e.Prefijo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PREFIJO");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        }
    }
}
