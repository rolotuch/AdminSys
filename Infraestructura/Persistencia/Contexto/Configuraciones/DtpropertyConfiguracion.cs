using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class DtpropertyConfiguracion : IEntityTypeConfiguration<Dtproperty>
    {
        public void Configure(EntityTypeBuilder<Dtproperty> builder)
        {
            builder.HasKey(e => new { e.Id, e.Property });

            builder.ToTable("DTPROPERTIES");

            builder.Property(e => e.Id)
                .HasPrecision(10)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Property)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROPERTY");
            builder.Property(e => e.Lvalue)
                .HasColumnType("BLOB")
                .HasColumnName("LVALUE");
            builder.Property(e => e.Objectid)
                .HasPrecision(10)
                .HasColumnName("OBJECTID");
            builder.Property(e => e.Uvalue)
                .HasMaxLength(255)
                .HasColumnName("UVALUE");
            builder.Property(e => e.Value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VALUE");
            builder.Property(e => e.Version)
                .HasPrecision(10)
                .HasDefaultValueSql("0 ")
                .HasColumnName("VERSION");
        }
    }
}
