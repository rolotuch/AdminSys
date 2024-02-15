using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdChequesCabeceraConfiguracion : IEntityTypeConfiguration<AdChequesCabecera>
    {       

        public void Configure(EntityTypeBuilder<AdChequesCabecera> builder)
        {
            builder.HasKey(e => new { e.Entidad, e.UnidadEjecutora, e.UnidadDesconcentrada, e.CuentaPagadora, e.Correlativo });

            builder.ToTable("AD_CHEQUES_CABECERA");

            builder.Property(e => e.Entidad)
                .HasPrecision(18)
                .HasColumnName("ENTIDAD");
            builder.Property(e => e.UnidadEjecutora)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_EJECUTORA");
            builder.Property(e => e.UnidadDesconcentrada)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_DESCONCENTRADA");
            builder.Property(e => e.CuentaPagadora)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CUENTA_PAGADORA");
            builder.Property(e => e.Correlativo)
                .HasPrecision(18)
                .HasColumnName("CORRELATIVO");
            builder.Property(e => e.CantidadLineas)
                .HasPrecision(18)
                .HasColumnName("CANTIDAD_LINEAS");
            builder.Property(e => e.CaracteresLinea)
                .HasPrecision(18)
                .HasColumnName("CARACTERES_LINEA");
            builder.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N' ")
                .HasColumnName("RESTRICTIVA");
            builder.Property(e => e.TipoImpresora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPRESORA");
        }
    }
}
