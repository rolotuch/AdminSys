using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SeqConfiguracion : IEntityTypeConfiguration<Seq>
    {
        public void Configure(EntityTypeBuilder<Seq> builder)
        {
            builder.HasKey(e => e.Secuencia);
            builder.ToTable("SEQS");

            builder.Property(e => e.Secuencia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SECUENCIA");
            builder.Property(e => e.Valor)
                .HasPrecision(10)
                .HasColumnName("VALOR");
        }
    }
}
