using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdUnidadesAdministrativaConfiguracion : IEntityTypeConfiguration<AdUnidadesAdministrativa>
    {
        public void Configure(EntityTypeBuilder<AdUnidadesAdministrativa> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_UNIDADES_ADMINISTRATIVAS");

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
            builder.Property(e => e.Maa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAA");
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
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Siglas)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SIGLAS");
            builder.Property(e => e.UnidadAdministrativa)
                .HasPrecision(4)
                .HasColumnName("UNIDAD_ADMINISTRATIVA");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        }
    }
}
