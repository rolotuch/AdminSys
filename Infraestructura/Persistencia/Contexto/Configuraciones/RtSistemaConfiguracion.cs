using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class RtSistemaConfiguracion : IEntityTypeConfiguration<RtSistema>
    {
        public void Configure(EntityTypeBuilder<RtSistema> builder)
        {
            builder
                .HasNoKey()
            .ToTable("RT_SISTEMAS");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Dueno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DUENO");
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
            builder.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Sistema)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SISTEMA");
            builder.Property(e => e.Supersistema)
                .HasPrecision(18)
                .HasColumnName("SUPERSISTEMA");
            builder.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        }
    }
}
