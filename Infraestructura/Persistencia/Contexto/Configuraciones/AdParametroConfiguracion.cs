using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdParametroConfiguracion : IEntityTypeConfiguration<AdParametro>
    {
        public void Configure(EntityTypeBuilder<AdParametro> builder)
        {
            builder
                .HasNoKey()
            .ToTable("AD_PARAMETROS");

            builder.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            builder.Property(e => e.Etiqueta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ETIQUETA");
            builder.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            builder.Property(e => e.Parametro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PARAMETRO");
            builder.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPO_DATO");
        }
    }
}
