using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class TempUsuarioConfiguracion : IEntityTypeConfiguration<TempUsuario>
    {
        public void Configure(EntityTypeBuilder<TempUsuario> builder)
        {
            builder
                .HasNoKey()
            .ToTable("TEMP_USUARIOS");

            builder.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        }
    }
}
