using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class PruebaConfiguracion : IEntityTypeConfiguration<Prueba>
    {
        public void Configure(EntityTypeBuilder<Prueba> builder)
        {
            builder
                .HasNoKey()
            .ToTable("PRUEBA");

            builder.Property(e => e.Caracter)
                .HasColumnType("CLOB")
                .HasColumnName("CARACTER");
            builder.Property(e => e.Prueba1)
                .HasColumnType("CLOB")
                .HasColumnName("PRUEBA");
        }
    }
}
