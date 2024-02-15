using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SecuenciaConfiguracion : IEntityTypeConfiguration<Secuencia>
    {
        public void Configure(EntityTypeBuilder<Secuencia> builder)
        {
            builder
                .HasNoKey()
            .ToTable("SECUENCIAS");

            builder.Property(e => e.Anio)
                .HasPrecision(18)
                .HasColumnName("ANIO");
            builder.Property(e => e.Correlativo)
                .HasPrecision(18)
                .HasColumnName("CORRELATIVO");
            builder.Property(e => e.TipoObjeto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_OBJETO");
        }
    }
}
