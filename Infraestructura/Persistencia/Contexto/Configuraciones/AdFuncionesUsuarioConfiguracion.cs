using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdFuncionesUsuarioConfiguracion : IEntityTypeConfiguration<AdFuncionesUsuario>
    {
        public void Configure(EntityTypeBuilder<AdFuncionesUsuario> builder)
        {
            builder.HasKey(e => new { e.Usuario, e.Funcion });

            builder.ToTable("AD_FUNCIONES_USUARIO");

            builder.HasIndex(e => new { e.Usuario, e.Restrictiva }, "DTA_INDEX_AD_FUNCIONES_USUARIO");

            builder.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            builder.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            builder.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");

            builder.HasOne(d => d.FuncionNavigation).WithMany(p => p.AdFuncionesUsuarios)
                .HasForeignKey(d => d.Funcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_FUNCIONES_USUARIO_AD_FUN");
        }
    }
}
