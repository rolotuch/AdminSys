using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdChequesDetalleConfiguracion : IEntityTypeConfiguration<AdChequesDetalle>
    {
        public void Configure(EntityTypeBuilder<AdChequesDetalle> builder)
        {
            builder.HasKey(e => new { e.Entidad, e.UnidadEjecutora, e.UnidadDesconcentrada, e.CuentaPagadora, e.Correlativo, e.NombreCampo });

            builder.ToTable("AD_CHEQUES_DETALLE");

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
            builder.Property(e => e.NombreCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CAMPO");
            builder.Property(e => e.CampoTabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAMPO_TABLA");
            builder.Property(e => e.Columna)
                .HasPrecision(18)
                .HasColumnName("COLUMNA");
            builder.Property(e => e.Condensado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'S' ")
                .HasColumnName("CONDENSADO");
            builder.Property(e => e.Fila)
                .HasPrecision(18)
                .HasColumnName("FILA");
            builder.Property(e => e.Mascara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MASCARA");
            builder.Property(e => e.OrdenCampo)
                .HasPrecision(18)
                .HasColumnName("ORDEN_CAMPO");
            builder.Property(e => e.SeImprime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'S' ")
                .HasColumnName("SE_IMPRIME");
            builder.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            builder.Property(e => e.ValorDefault)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("VALOR_DEFAULT");
        }
    }
}
