using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class Prueba1Configuracion : IEntityTypeConfiguration<Prueba1>
    {
        public void Configure(EntityTypeBuilder<Prueba1> builder)
        {
            builder
                .HasNoKey()
            .ToTable("PRUEBA1");

            builder.Property(e => e.Alias)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            builder.Property(e => e.DefaultOrderby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_ORDERBY");
            builder.Property(e => e.DefaultWhere)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_WHERE");
            builder.Property(e => e.LinkExpandir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LINK_EXPANDIR");
            builder.Property(e => e.Multiselect)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MULTISELECT");
            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.ObjetoRepositorio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OBJETO_REPOSITORIO");
            builder.Property(e => e.Paginear)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PAGINEAR");
            builder.Property(e => e.SecuenciaFetch)
                .HasPrecision(18)
                .HasColumnName("SECUENCIA_FETCH");
            builder.Property(e => e.SelectStatement)
                .HasColumnType("CLOB")
                .HasColumnName("SELECT_STATEMENT");
            builder.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA");
            builder.Property(e => e.TablaBase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLA_BASE");
            builder.Property(e => e.TextoParametros)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TEXTO_PARAMETROS");
            builder.Property(e => e.UtilizaFormulas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UTILIZA_FORMULAS");
        }
    }
}
