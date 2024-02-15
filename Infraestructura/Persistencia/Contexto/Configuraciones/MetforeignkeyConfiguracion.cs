using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class MetforeignkeyConfiguracion : IEntityTypeConfiguration<Metforeignkey>
    {
        public void Configure(EntityTypeBuilder<Metforeignkey> builder)
        {
            builder
                .HasNoKey()
            .ToTable("METFOREIGNKEYS");

            builder.Property(e => e.ChildColumn)
                .HasMaxLength(128)
                .HasColumnName("CHILD_COLUMN");
            builder.Property(e => e.ChildTable)
                .HasMaxLength(128)
                .HasColumnName("CHILD_TABLE");
            builder.Property(e => e.ForeignKeyName)
                .HasMaxLength(128)
                .HasColumnName("FOREIGN_KEY_NAME");
            builder.Property(e => e.Idfk)
                .HasPrecision(10)
                .HasColumnName("IDFK");
            builder.Property(e => e.Keyno)
                .HasPrecision(5)
                .HasColumnName("KEYNO");
            builder.Property(e => e.ParentColumn)
                .HasMaxLength(128)
                .HasColumnName("PARENT_COLUMN");
            builder.Property(e => e.ParentTable)
                .HasMaxLength(128)
                .HasColumnName("PARENT_TABLE");
        }
    }
}
