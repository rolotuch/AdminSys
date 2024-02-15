using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SgReporteConfiguracion : IEntityTypeConfiguration<SgReporte>
    {
        public void Configure(EntityTypeBuilder<SgReporte> builder)
        {
            builder
                .HasNoKey()
            .ToTable("SG_REPORTES");

            builder.Property(e => e.FechaFin)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_FIN");
            builder.Property(e => e.FechaInicio)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INICIO");
            builder.Property(e => e.Filtro)
                .HasColumnType("NCLOB")
                .HasColumnName("FILTRO");
            builder.Property(e => e.Reporte)
                .HasMaxLength(50)
                .HasColumnName("REPORTE");
            builder.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("USUARIO");
        }
    }
}
