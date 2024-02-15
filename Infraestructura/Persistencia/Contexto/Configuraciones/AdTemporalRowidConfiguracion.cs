using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdTemporalRowidConfiguracion : IEntityTypeConfiguration<AdTemporalRowid>
    {
        public void Configure(EntityTypeBuilder<AdTemporalRowid> builder)
        {
            builder
               .HasNoKey()
               .ToTable("AD_TEMPORAL_ROWID");

            builder.Property(e => e.Idregistro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IDREGISTRO");
        }
    }
}
