using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdDefwhereFuncionConfiguracion : IEntityTypeConfiguration<AdDefwhereFuncion>
    {
        public void Configure(EntityTypeBuilder<AdDefwhereFuncion> builder)
        {
            builder.HasKey(e => new { e.Objeto, e.Funcion });

            builder.ToTable("AD_DEFWHERE_FUNCION");

            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            builder.Property(e => e.DefaultWhere)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_WHERE");

            builder.HasOne(d => d.ObjetoNavigation).WithMany(p => p.AdDefwhereFuncions)
                .HasForeignKey(d => d.Objeto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_DEFWHERE_FUNCION_AD_OBJE");
        }
    }
}
