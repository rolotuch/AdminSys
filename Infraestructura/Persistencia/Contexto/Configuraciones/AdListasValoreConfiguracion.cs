using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdListasValoreConfiguracion : IEntityTypeConfiguration<AdListasValore>
    {
        public void Configure(EntityTypeBuilder<AdListasValore> builder)
        {
            builder.HasKey(e => e.IdLista);

            builder.ToTable("AD_LISTAS_VALORES");

            builder.Property(e => e.IdLista)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ID_LISTA");
            builder.Property(e => e.CargarBajoDemanda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARGAR_BAJO_DEMANDA");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.ForzarFiltro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FORZAR_FILTRO");
            builder.Property(e => e.SqlStatement)
                .HasMaxLength(3500)
                .IsUnicode(false)
                .HasColumnName("SQL_STATEMENT");
            builder.Property(e => e.UsarDiccionario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USAR_DICCIONARIO");
            builder.Property(e => e.UsarWebcache)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USAR_WEBCACHE");
        }
    }
}
