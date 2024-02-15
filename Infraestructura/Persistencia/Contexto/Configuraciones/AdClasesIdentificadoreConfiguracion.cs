using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdClasesIdentificadoreConfiguracion : IEntityTypeConfiguration<AdClasesIdentificadore>
    {
        public void Configure(EntityTypeBuilder<AdClasesIdentificadore> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_CLASES_IDENTIFICADORES");

            builder.Property(e => e.Clase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
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
            builder.Property(e => e.Mnemonico)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MNEMONICO");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
        }
    }
}
