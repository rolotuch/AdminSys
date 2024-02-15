using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SequenceConfiguracion : IEntityTypeConfiguration<Sequence>
    {
        public void Configure(EntityTypeBuilder<Sequence> builder)
        {
            builder.HasKey(e => e.Seq).HasName("PK__SEQUENCES__07CCE17F");

            builder.ToTable("SEQUENCES");

            builder.Property(e => e.Seq)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SEQ");
            builder.Property(e => e.SequenceId)
                .HasPrecision(10)
                .HasColumnName("SEQUENCE_ID");
        }
    }
}
