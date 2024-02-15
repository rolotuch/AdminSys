using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdPerfilesFuncionConfiguracion : IEntityTypeConfiguration<AdPerfilesFuncion>
    {
        public void Configure(EntityTypeBuilder<AdPerfilesFuncion> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_PERFILES_FUNCION");

            builder.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            builder.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            builder.Property(e => e.PerfilAplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERFIL_APLICACION");
            builder.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");
        }
    }
}
