using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class EquivalenciaConfiguracion : IEntityTypeConfiguration<Equivalencia>
    {
        public void Configure(EntityTypeBuilder<Equivalencia> builder)
        {
            builder
                .HasNoKey()
            .ToTable("EQUIVALENCIAS");

            builder.Property(e => e.Equivalencia1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("EQUIVALENCIA");
            builder.Property(e => e.Frase)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FRASE");
            builder.Property(e => e.TipoFrase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_FRASE");
        }
    }
}
