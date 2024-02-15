using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdTempoColumnaConfiguracion : IEntityTypeConfiguration<AdTempoColumna>
    {
        public void Configure(EntityTypeBuilder<AdTempoColumna> builder)
        {
            builder.HasKey(e => new { e.Objeto, e.Alias, e.Datafield });

            builder.ToTable("AD_TEMPO_COLUMNAS");

            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            builder.Property(e => e.Datafield)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATAFIELD");
            builder.Property(e => e.AgregarParametro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AGREGAR_PARAMETRO");
            builder.Property(e => e.CampoLlave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAMPO_LLAVE");
            builder.Property(e => e.Datalist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATALIST");
            builder.Property(e => e.Decimales)
                .HasPrecision(18)
                .HasColumnName("DECIMALES");
            builder.Property(e => e.EditableGrid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EDITABLE_GRID");
            builder.Property(e => e.ExcluirGrid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EXCLUIR_GRID");
            builder.Property(e => e.HeaderText)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("HEADER_TEXT");
            builder.Property(e => e.Height)
                .HasPrecision(18)
                .HasColumnName("HEIGHT");
            builder.Property(e => e.HeightEtiqueta)
                .HasPrecision(18)
                .HasColumnName("HEIGHT_ETIQUETA");
            builder.Property(e => e.Longitud)
                .HasPrecision(18)
                .HasColumnName("LONGITUD");
            builder.Property(e => e.MostrarFiltro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MOSTRAR_FILTRO");
            builder.Property(e => e.PermitirInsert)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERMITIR_INSERT");
            builder.Property(e => e.PermitirUpdate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PERMITIR_UPDATE");
            builder.Property(e => e.Sumarizable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SUMARIZABLE");
            builder.Property(e => e.TabIndex)
                .HasPrecision(18)
                .HasColumnName("TAB_INDEX");
            builder.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_DATO");
            builder.Property(e => e.ValorInicial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALOR_INICIAL");
            builder.Property(e => e.Width)
                .HasPrecision(18)
                .HasColumnName("WIDTH");
            builder.Property(e => e.WidthEtiqueta)
                .HasPrecision(18)
                .HasColumnName("WIDTH_ETIQUETA");
        }
    }
}
