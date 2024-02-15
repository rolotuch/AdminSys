using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SgOperacioneConfiguracion : IEntityTypeConfiguration<SgOperacione>
    {
        public void Configure(EntityTypeBuilder<SgOperacione> builder)
        {
            builder.HasKey(e => e.IdOperacion);

            builder.ToTable("SG_OPERACIONES");

            builder.Property(e => e.IdOperacion)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("ID_OPERACION");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.FechaFinOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_FIN_OPERACION");
            builder.Property(e => e.FechaOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_OPERACION");
            builder.Property(e => e.NombreOperacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_OPERACION");
            builder.Property(e => e.TiempoOperacionBdd)
                .HasPrecision(18)
                .HasColumnName("TIEMPO_OPERACION_BDD");
            builder.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            builder.Property(e => e.UsuarioBdd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USUARIO_BDD");
        }
    }
}
