using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdCamposMatrizConfiguracion : IEntityTypeConfiguration<AdCamposMatriz>
    {
        public void Configure(EntityTypeBuilder<AdCamposMatriz> builder)
        {
            builder.HasKey(e => e.Llave);

            builder.ToTable("AD_CAMPOS_MATRIZ");

            builder.Property(e => e.Llave)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("LLAVE");
            builder.Property(e => e.CodigoCampo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CODIGO_CAMPO");
            builder.Property(e => e.Etiqueta)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA");
            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.PredicadoJoin)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PREDICADO_JOIN");
            builder.Property(e => e.TablaCampo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TABLA_CAMPO");
            builder.Property(e => e.TablaJoin)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TABLA_JOIN");
            builder.Property(e => e.TipoCampo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIPO_CAMPO");
            builder.Property(e => e.ValorCampo)
                .HasColumnType("CLOB")
                .HasColumnName("VALOR_CAMPO");
        }
    }
}
