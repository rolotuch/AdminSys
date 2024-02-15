using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class RtTransicioneConfiguracion : IEntityTypeConfiguration<RtTransicione>
    {
        public void Configure(EntityTypeBuilder<RtTransicione> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RT_TRANSICIONES");

            builder.Property(e => e.Automatica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AUTOMATICA");
            builder.Property(e => e.EstadoFinal)
                .HasPrecision(18)
                .HasColumnName("ESTADO_FINAL");
            builder.Property(e => e.EstadoInicial)
                .HasPrecision(18)
                .HasColumnName("ESTADO_INICIAL");
            builder.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            builder.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            builder.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_OPERACION");
            builder.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            builder.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        }
    }
}
