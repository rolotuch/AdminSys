using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdFuncioneConfiguracion : IEntityTypeConfiguration<AdFuncione>
    {
        public void Configure(EntityTypeBuilder<AdFuncione> builder)
        {
            builder.HasKey(e => e.Funcion);

            builder.ToTable("AD_FUNCIONES");

            builder.Property(e => e.Funcion)
                .HasPrecision(18)
                .ValueGeneratedNever()
                .HasColumnName("FUNCION");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.EjecucionFormulacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EJECUCION_FORMULACION");
            builder.Property(e => e.Historico)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HISTORICO");
            builder.Property(e => e.Regularizacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REGULARIZACION");
            builder.Property(e => e.Restrictiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RESTRICTIVA");
            builder.Property(e => e.TipoFuncion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_FUNCION");
        }
    }
}
