using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class ReporteConfiguracion : IEntityTypeConfiguration<Reporte>
    {
        public void Configure(EntityTypeBuilder<Reporte> builder)
        {
            builder
               .HasNoKey()
            .ToTable("REPORTE");

            builder.Property(e => e.Codigo)
                .HasPrecision(10)
                .HasColumnName("CODIGO");
            builder.Property(e => e.Codrep)
                .HasPrecision(10)
                .HasColumnName("CODREP");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE");
        }
    }
}
