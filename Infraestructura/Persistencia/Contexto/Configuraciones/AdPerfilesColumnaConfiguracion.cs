using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdPerfilesColumnaConfiguracion : IEntityTypeConfiguration<AdPerfilesColumna>
    {
        public void Configure(EntityTypeBuilder<AdPerfilesColumna> builder)
        {
            builder
                .HasNoKey()
                .ToTable("AD_PERFILES_COLUMNAS");

            builder.Property(e => e.IdColumna)
                .HasPrecision(18)
                .HasColumnName("ID_COLUMNA");
            builder.Property(e => e.Perfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PERFIL");
            builder.Property(e => e.VerificaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VERIFICA_ESTADO");
        }
    }
}
