using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdMapeoObjetoConfiguracion : IEntityTypeConfiguration<AdMapeoObjeto>
    {
        public void Configure(EntityTypeBuilder<AdMapeoObjeto> builder)
        {
            builder.HasKey(e => new { e.ObjetoInicial, e.ObjetoFinal });

            builder.ToTable("AD_MAPEO_OBJETOS");

            builder.HasIndex(e => e.ObjetoInicial, "IX_AD_MAPEO_OBJETOS");

            builder.HasIndex(e => e.ObjetoFinal, "IX_AD_MAPEO_OBJETOS_1");

            builder.Property(e => e.ObjetoInicial)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_INICIAL");
            builder.Property(e => e.ObjetoFinal)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_FINAL");
            builder.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");
        }
    }
}
