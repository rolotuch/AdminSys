using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdObjetoConfiguracion : IEntityTypeConfiguration<AdObjeto>
    {
        public void Configure(EntityTypeBuilder<AdObjeto> builder)
        {
            builder.HasKey(e => e.Objeto).HasName("OBJ_PK");

            builder.ToTable("AD_OBJETOS");

            builder.HasIndex(e => new { e.Objeto, e.NombreLogico, e.NombreFisico, e.Etiqueta, e.ObjetoPadre, e.TipoObjeto, e.Nivel, e.OrdenTabulacion }, "DTA_INDEX_AD_OBJETOS_5_26795_1");

            builder.HasIndex(e => new { e.Objeto, e.NombreLogico, e.NombreFisico, e.Etiqueta, e.ObjetoPadre, e.TipoObjeto, e.Nivel, e.OrdenTabulacion, e.ImagenBotonArriba, e.ImagenBotonSobre }, "DTA_INDEX_AD_OBJETOS_5_26795_2");

            builder.HasIndex(e => e.ObjetoPadre, "IX_AD_OBJETOS");

            builder.Property(e => e.Objeto)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO");
            builder.Property(e => e.AmbienteDesarrollo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AMBIENTE_DESARROLLO");
            builder.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            builder.Property(e => e.Etiqueta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ETIQUETA");
            builder.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            builder.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            builder.Property(e => e.ImagenBotonArriba)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_ARRIBA");
            builder.Property(e => e.ImagenBotonSobre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IMAGEN_BOTON_SOBRE");
            builder.Property(e => e.MeClase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_CLASE");
            builder.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'A'")
                .HasColumnName("ME_ESTADO");
            builder.Property(e => e.MeOperacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("0")
                .HasColumnName("ME_OPERACION");
            builder.Property(e => e.Nivel)
                .HasPrecision(3)
                .HasColumnName("NIVEL");
            builder.Property(e => e.NombreFisico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FISICO");
            builder.Property(e => e.NombreLogico)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_LOGICO");
            builder.Property(e => e.Numeracion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NUMERACION");
            builder.Property(e => e.ObjetoPadre)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("OBJETO_PADRE");
            builder.Property(e => e.OrdenTabulacion)
                .HasPrecision(9)
                .HasColumnName("ORDEN_TABULACION");
            builder.Property(e => e.TipoObjeto)
                .HasPrecision(5)
                .HasColumnName("TIPO_OBJETO");
            builder.Property(e => e.UseridAct)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ACT");
            builder.Property(e => e.UseridIng)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERID_ING");

            builder.HasOne(d => d.ObjetoPadreNavigation).WithMany(p => p.InverseObjetoPadreNavigation)
                .HasForeignKey(d => d.ObjetoPadre)
                .HasConstraintName("FK__AD_OBJETO__OBJET__39E294A9");

            builder.HasOne(d => d.TipoObjetoNavigation).WithMany(p => p.AdObjetos)
                .HasForeignKey(d => d.TipoObjeto)
                .HasConstraintName("FK_AD_OBJETOS_AD_TIPOS_OBJETO");
        }
    }
}
