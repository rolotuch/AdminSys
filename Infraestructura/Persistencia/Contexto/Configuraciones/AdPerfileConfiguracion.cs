using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdPerfileConfiguracion : IEntityTypeConfiguration<AdPerfile>
    {
        public void Configure(EntityTypeBuilder<AdPerfile> builder)
        {
            builder.HasKey(e => e.Perfil).HasName("PERF_PK");

            builder.ToTable("AD_PERFILES");

            builder.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
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
            builder.Property(e => e.Nivel)
                .HasPrecision(3)
                .HasColumnName("NIVEL");
            builder.Property(e => e.ObjetoRaiz)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_RAIZ");
            builder.Property(e => e.PerfilAdministrativo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERFIL_ADMINISTRATIVO");
            builder.Property(e => e.PerfilPadre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL_PADRE");
            builder.Property(e => e.TipoPerfil)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("TIPO_PERFIL");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        }
    }
}
