using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class RtCampoConfiguracion : IEntityTypeConfiguration<RtCampo>
    {
        public void Configure(EntityTypeBuilder<RtCampo> builder)
        {
            builder.HasKey(e => e.Tid);

            builder.ToTable("RT_CAMPOS");

            builder.HasIndex(e => e.Tabla, "IX_RT_CAMPOS");

            builder.HasIndex(e => e.Nombre, "IX_RT_CAMPOS_1");

            builder.Property(e => e.Tid)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            builder.Property(e => e.Dominio)
                .HasPrecision(18)
                .HasColumnName("DOMINIO");
            builder.Property(e => e.Llave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LLAVE");
            builder.Property(e => e.Longitud)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LONGITUD");
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
            builder.Property(e => e.Nombre)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Obligatorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBLIGATORIO");
            builder.Property(e => e.Tabla)
                .HasPrecision(18)
                .HasColumnName("TABLA");
            builder.Property(e => e.TipoControl)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TIPO_CONTROL");
            builder.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
        }
    }
}
