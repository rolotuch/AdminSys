using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class VwUsuarioConfiguracion : IEntityTypeConfiguration<VwUsuario>
    {
        public void Configure(EntityTypeBuilder<VwUsuario> builder)
        {
            builder
                .HasNoKey()
            .ToView("VW_USUARIOS");

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            builder.Property(e => e.Entidad)
                .HasPrecision(8)
                .HasColumnName("ENTIDAD");
            builder.Property(e => e.FecUltLogin)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ULT_LOGIN");
            builder.Property(e => e.Institucion)
                .HasPrecision(4)
                .HasColumnName("INSTITUCION");
            builder.Property(e => e.Nit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NIT");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.NombreInstitucion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_INSTITUCION");
            builder.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            builder.Property(e => e.Puesto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PUESTO");
            builder.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            builder.Property(e => e.UnidadEjecutora)
                .HasPrecision(3)
                .HasColumnName("UNIDAD_EJECUTORA");
            builder.Property(e => e.Usuario)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        }
    }
}
