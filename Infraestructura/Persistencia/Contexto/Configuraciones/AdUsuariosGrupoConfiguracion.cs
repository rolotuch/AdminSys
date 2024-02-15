using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdUsuariosGrupoConfiguracion : IEntityTypeConfiguration<AdUsuariosGrupo>
    {
        public void Configure(EntityTypeBuilder<AdUsuariosGrupo> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_USUARIOS_GRUPO");

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
            builder.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
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
            builder.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
            builder.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        }
    }
}
