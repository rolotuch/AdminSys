using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class OrmConfiguracion : IEntityTypeConfiguration<Orm>
    {
        public void Configure(EntityTypeBuilder<Orm> builder)
        {
            builder
                .HasNoKey()
            .ToTable("ORM__");

            builder.Property(e => e.Databaseguid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATABASEGUID");
        }
    }
}
