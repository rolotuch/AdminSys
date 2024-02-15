using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdFormulaConfiguracion : IEntityTypeConfiguration<AdFormula>
    {
        public void Configure(EntityTypeBuilder<AdFormula> builder)
        {
            builder.HasKey(e => e.IdFormula);

            builder.ToTable("AD_FORMULAS");

            builder.Property(e => e.IdFormula)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ID_FORMULA");
            builder.Property(e => e.TextoFormula)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("TEXTO_FORMULA");
        }
    }
}
