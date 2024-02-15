using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdErroreConfiguracion : IEntityTypeConfiguration<AdErrore>
    {
        public void Configure(EntityTypeBuilder<AdErrore> builder)
        {
            builder
                .HasNoKey()
            .ToTable("AD_ERRORES");

            builder.Property(e => e.Accion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACCION");
            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODIGO");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UBICACION");
        }
    }
}
