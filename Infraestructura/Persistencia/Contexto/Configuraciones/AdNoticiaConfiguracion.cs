using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdNoticiaConfiguracion : IEntityTypeConfiguration<AdNoticia>
    {
        public void Configure(EntityTypeBuilder<AdNoticia> builder)
        {
            builder
                .HasNoKey()
            .ToTable("AD_NOTICIAS");

            builder.Property(e => e.Asunto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ASUNTO");
            builder.Property(e => e.Contenido)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CONTENIDO");
            builder.Property(e => e.De)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DE");
            builder.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            builder.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            builder.Property(e => e.FechaFinVigencia)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_FIN_VIGENCIA");
            builder.Property(e => e.FechaInicioVigencia)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INICIO_VIGENCIA");
            builder.Property(e => e.Para)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PARA");
            builder.Property(e => e.Prioridad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PRIORIDAD");
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
