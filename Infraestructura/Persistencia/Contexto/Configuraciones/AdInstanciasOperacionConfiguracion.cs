using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdInstanciasOperacionConfiguracion : IEntityTypeConfiguration<AdInstanciasOperacion>
    {
        public void Configure(EntityTypeBuilder<AdInstanciasOperacion> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_INSTANCIAS_OPERACION");

            builder.HasIndex(e => new { e.Operacion, e.Grupo, e.Valor, e.TipoPredicado }, "DTA_INDEX_AD_INSTANCIAS_OPER_1");

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
            builder.Property(e => e.Operacion)
                .HasPrecision(18)
                .HasColumnName("OPERACION");
            builder.Property(e => e.TipoPredicado)
                .HasPrecision(2)
                .HasColumnName("TIPO_PREDICADO");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");
            builder.Property(e => e.Valor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VALOR");
        }
    }
}
