using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdObjetosCierreConfiguracion : IEntityTypeConfiguration<AdObjetosCierre>
    {
        public void Configure(EntityTypeBuilder<AdObjetosCierre> builder)
        {
            builder.HasKey(e => e.Objeto);

            builder.ToTable("AD_OBJETOS_CIERRE");

            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
        }
    }
}
