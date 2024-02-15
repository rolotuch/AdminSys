using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdRepositorioReporteConfiguracion : IEntityTypeConfiguration<AdRepositorioReporte>
    {
        public void Configure(EntityTypeBuilder<AdRepositorioReporte> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_REPOSITORIO_REPORTES");

            builder.Property(e => e.DiasPresentacion)
                .HasPrecision(18)
                .HasColumnName("DIAS_PRESENTACION");
            builder.Property(e => e.DirectorioReporte)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIRECTORIO_REPORTE");
            builder.Property(e => e.FechaGeneracion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_GENERACION");
            builder.Property(e => e.Objeto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.Reporte)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REPORTE");
            builder.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        }
    }
}
