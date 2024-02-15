using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdGruposFuncionConfiguracion : IEntityTypeConfiguration<AdGruposFuncion>
    {
        public void Configure(EntityTypeBuilder<AdGruposFuncion> builder)
        {
            builder.HasKey(e => new { e.Funcion, e.Grupo });

            builder.ToTable("AD_GRUPOS_FUNCION");

            builder.Property(e => e.Funcion)
                .HasPrecision(18)
                .HasColumnName("FUNCION");
            builder.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
            builder.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");

            builder.HasOne(d => d.FuncionNavigation).WithMany(p => p.AdGruposFuncions)
                .HasForeignKey(d => d.Funcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRUPOS_FUNCION_AD_FUNCIO");

            builder.HasOne(d => d.GrupoNavigation).WithMany(p => p.AdGruposFuncions)
                .HasForeignKey(d => d.Grupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRUPOS_FUNCION_AD_GRUPOS");
        }
    }
}
