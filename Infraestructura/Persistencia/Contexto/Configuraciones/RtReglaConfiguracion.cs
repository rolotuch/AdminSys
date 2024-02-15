using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class RtReglaConfiguracion : IEntityTypeConfiguration<RtRegla>
    {
        public void Configure(EntityTypeBuilder<RtRegla> builder)
        {
            builder
                .HasNoKey()
            .ToTable("RT_REGLAS");

            builder.Property(e => e.Accion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ACCION");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTATUS");
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
            builder.Property(e => e.Notas)
                .HasColumnType("CLOB")
                .HasColumnName("NOTAS");
            builder.Property(e => e.Origen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ORIGEN");
            builder.Property(e => e.OrigenAutor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGEN_AUTOR");
            builder.Property(e => e.OrigenFuente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGEN_FUENTE");
            builder.Property(e => e.OrigenResponsable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORIGEN_RESPONSABLE");
            builder.Property(e => e.Patron)
                .HasColumnType("NUMBER(28)")
                .HasColumnName("PATRON");
            builder.Property(e => e.Regla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REGLA");
            builder.Property(e => e.ReglaContenedora)
                .HasColumnType("NUMBER(28)")
                .HasColumnName("REGLA_CONTENEDORA");
            builder.Property(e => e.Tid)
                .HasColumnType("NUMBER(28)")
                .HasColumnName("TID");
            builder.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        }
    }
}
