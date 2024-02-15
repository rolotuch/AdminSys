using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class VwFuncionPerfilObjetoConfiguracion : IEntityTypeConfiguration<VwFuncionPerfilObjeto>
    {
        public void Configure(EntityTypeBuilder<VwFuncionPerfilObjeto> builder)
        {
            builder
                .HasNoKey()
                .ToView("VW_FUNCION_PERFIL_OBJETO");

            builder.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            builder.Property(e => e.NombreFuncion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FUNCION");
            builder.Property(e => e.NombreLogico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_LOGICO");
            builder.Property(e => e.NombrePerfil)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PERFIL");
            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
        }
    }
}
