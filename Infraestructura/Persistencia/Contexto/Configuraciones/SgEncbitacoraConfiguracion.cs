using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class SgEncbitacoraConfiguracion : IEntityTypeConfiguration<SgEncbitacora>
    {
        public void Configure(EntityTypeBuilder<SgEncbitacora> builder)
        {
            builder
                .HasNoKey()
            .ToTable("SG_ENCBITACORA");

            builder.Property(e => e.CamposPk)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CAMPOS_PK");
            builder.Property(e => e.FechaRegistro)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_REGISTRO");
            builder.Property(e => e.IdEnc)
                .HasPrecision(10)
                .HasColumnName("ID_ENC");
            builder.Property(e => e.IdOperacion)
                .HasPrecision(10)
                .HasColumnName("ID_OPERACION");
            builder.Property(e => e.LlaveFila)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LLAVE_FILA");
            builder.Property(e => e.NombreTabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TABLA");
            builder.Property(e => e.Operacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            builder.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            builder.Property(e => e.UsuarioBdd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USUARIO_BDD");
        }
    }
}
