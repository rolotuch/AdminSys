using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SgDetalleBitacoraConfiguracion : IEntityTypeConfiguration<SgDetalleBitacora>
    {
        public void Configure(EntityTypeBuilder<SgDetalleBitacora> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SG_DETALLE_BITACORA");

            builder.Property(e => e.IdDetalle)
                .HasPrecision(10)
                .HasColumnName("ID_DETALLE");
            builder.Property(e => e.IdEnc)
                .HasPrecision(10)
                .HasColumnName("ID_ENC");
            builder.Property(e => e.NombreCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CAMPO");
            builder.Property(e => e.ValorAnterior)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("VALOR_ANTERIOR");
            builder.Property(e => e.ValorNuevo)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("VALOR_NUEVO");
        }
    }
}
