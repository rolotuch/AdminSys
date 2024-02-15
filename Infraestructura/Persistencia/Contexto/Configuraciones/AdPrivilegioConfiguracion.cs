using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdPrivilegioConfiguracion : IEntityTypeConfiguration<AdPrivilegio>
    {
        public void Configure(EntityTypeBuilder<AdPrivilegio> builder)
        {
            builder.HasKey(e => e.Privilegio);

            builder.ToTable("AD_PRIVILEGIOS");

            builder.Property(e => e.Privilegio)
                .HasPrecision(6)
                .ValueGeneratedNever()
                .HasColumnName("PRIVILEGIO");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
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
            builder.Property(e => e.Generable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GENERABLE");
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
            builder.Property(e => e.Sentencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SENTENCIA");
            builder.Property(e => e.UseridAct)
                .HasColumnType("DATE")
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        }
    }
}
