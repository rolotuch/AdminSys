using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdMatrizOperacioneConfiguracion : IEntityTypeConfiguration<AdMatrizOperacione>
    {
        public void Configure(EntityTypeBuilder<AdMatrizOperacione> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_MATRIZ_OPERACIONES");

            builder.Property(e => e.ClaseGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASE_GRUPO");
            builder.Property(e => e.ClaseModificacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASE_MODIFICACION");
            builder.Property(e => e.ClaseRegistro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASE_REGISTRO");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
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
            builder.Property(e => e.IdMatriz)
                .HasPrecision(4)
                .HasColumnName("ID_MATRIZ");
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
            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
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
