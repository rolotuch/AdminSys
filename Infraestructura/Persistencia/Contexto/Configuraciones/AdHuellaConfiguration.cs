using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdHuellaConfiguration : IEntityTypeConfiguration<AdHuella>
    {
        public void Configure(EntityTypeBuilder<AdHuella> builder)
        {
            builder.HasKey(e => e.Usuario);

            builder.ToTable("AD_HUELLAS");

            builder.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            builder.Property(e => e.FirmaDactilar)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("FIRMA_DACTILAR");
        }
    }
}
