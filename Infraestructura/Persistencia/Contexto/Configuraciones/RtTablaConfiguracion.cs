using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class RtTablaConfiguracion : IEntityTypeConfiguration<RtTabla>
    {
        public void Configure(EntityTypeBuilder<RtTabla> builder)
        {
            builder.HasKey(e => e.Tid);

            builder.ToTable("RT_TABLAS");

            builder.Property(e => e.Tid)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            builder.Property(e => e.Bitacorizar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BITACORIZAR");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
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
            builder.Property(e => e.Reportes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("REPORTES");
            builder.Property(e => e.Sinonimo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SINONIMO");
            builder.Property(e => e.Sistema)
                .HasPrecision(18)
                .HasColumnName("SISTEMA");
            builder.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
        }
    }
}
