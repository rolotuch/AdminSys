using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdDefinicionParametroConfiguracion : IEntityTypeConfiguration<AdDefinicionParametro>
    {
        public void Configure(EntityTypeBuilder<AdDefinicionParametro> builder)
        {
            builder.HasKey(e => e.Parametro);

            builder.ToTable("AD_DEFINICION_PARAMETROS");

            builder.Property(e => e.Parametro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARAMETRO");
            builder.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            builder.Property(e => e.EtiquetaDefault)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA_DEFAULT");
            builder.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            builder.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
        }
    }
}
