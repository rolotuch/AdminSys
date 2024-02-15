using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdGrantConfiguracion : IEntityTypeConfiguration<AdGrant>
    {
        public void Configure(EntityTypeBuilder<AdGrant> builder)
        {
            builder.HasKey(e => new { e.Objeto, e.Perfil, e.Privilegio });

            builder.ToTable("AD_GRANTS");

            builder.HasIndex(e => new { e.Objeto, e.Modo }, "DTA_INDEX_AD_GRANTS_5_20368513");

            builder.HasIndex(e => e.Objeto, "IX_AD_GRANTS");

            builder.HasIndex(e => e.Perfil, "IX_AD_GRANTS_1");

            builder.HasIndex(e => e.Privilegio, "IX_AD_GRANTS_2");

            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            builder.Property(e => e.Privilegio)
                .HasPrecision(6)
                .HasColumnName("PRIVILEGIO");
            builder.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            builder.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            builder.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            builder.Property(e => e.Granteable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GRANTEABLE");
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
            builder.Property(e => e.Modo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MODO");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");

            builder.HasOne(d => d.PerfilNavigation).WithMany(p => p.AdGrants)
                .HasForeignKey(d => d.Perfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRANTS_AD_PERFILES");

            builder.HasOne(d => d.PrivilegioNavigation).WithMany(p => p.AdGrants)
                .HasForeignKey(d => d.Privilegio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AD_GRANTS_AD_PRIVILEGIOS");
        }
    }
}
