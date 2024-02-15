using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdPistaOperacionesMeConfiguracion : IEntityTypeConfiguration<AdPistaOperacionesMe>
    {
        public void Configure(EntityTypeBuilder<AdPistaOperacionesMe> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_PISTA_OPERACIONES_ME");

            builder.Property(e => e.FechaOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_OPERACION");
            builder.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            builder.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        }
    }
}
