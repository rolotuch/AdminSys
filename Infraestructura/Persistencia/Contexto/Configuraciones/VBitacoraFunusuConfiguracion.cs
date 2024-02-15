using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class VBitacoraFunusuConfiguracion : IEntityTypeConfiguration<VBitacoraFunusu>
    {
        public void Configure(EntityTypeBuilder<VBitacoraFunusu> builder)
        {
            builder
                .HasNoKey()
                .ToView("V_BITACORA_FUNUSU");

            builder.Property(e => e.CodigoFuncion)
                .HasColumnType("NUMBER")
                .HasColumnName("CODIGO_FUNCION");
            builder.Property(e => e.CodigoGrupo)
                .HasPrecision(18)
                .HasColumnName("CODIGO_GRUPO");
            builder.Property(e => e.FechaOperacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_OPERACION");
            builder.Property(e => e.Funcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FUNCION");
            builder.Property(e => e.Grupo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            builder.Property(e => e.MeEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Operacion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            builder.Property(e => e.U)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            builder.Property(e => e.UsuarioAsigna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO_ASIGNA");
        }
    }
}
