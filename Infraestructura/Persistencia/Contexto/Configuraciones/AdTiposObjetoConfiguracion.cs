using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdTiposObjetoConfiguracion : IEntityTypeConfiguration<AdTiposObjeto>
    {
        public void Configure(EntityTypeBuilder<AdTiposObjeto> builder)
        {
            builder.HasKey(e => e.TipoObjeto);

            builder.ToTable("AD_TIPOS_OBJETO");

            builder.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .ValueGeneratedNever()
                .HasColumnName("TIPO_OBJETO");
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
            builder.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.NombreFisico)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FISICO");
            builder.Property(e => e.ObjetoBd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBJETO_BD");
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
