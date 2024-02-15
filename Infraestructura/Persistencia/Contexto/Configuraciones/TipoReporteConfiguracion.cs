using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class TipoReporteConfiguracion : IEntityTypeConfiguration<TipoReporte>
    {
        public void Configure(EntityTypeBuilder<TipoReporte> builder)
        {
            builder
                .HasNoKey()
            .ToTable("TIPO_REPORTE");

            builder.Property(e => e.Codigo)
                .HasPrecision(10)
                .HasColumnName("CODIGO");

            builder.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NOMBRE");
        }
    }
}
