using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class AdUsuarioConfiguracion : IEntityTypeConfiguration<AdUsuario>
    {
        public void Configure(EntityTypeBuilder<AdUsuario> builder)
        {
            builder.ToTable("AD_USUARIOS");

            //builder.HasKey(e => e.Usuario);
            //builder.Property(e => e.Usuario)
            //    .HasColumnName("USUARIO"); //usuario es lo que esta como nombre del id en la bd

            builder.HasKey(e => e.Id).HasName("USR_PK");
            builder.Property(e => e.Id)
                .HasColumnName("USUARIO"); //usuario es lo que esta como nombre del id en la bd


            //builder.HasKey(e => e.Id).HasName("USR_PK");

            builder.Property(e => e.AccesoSistemas)
                .HasPrecision(3)
                .HasColumnName("ACCESO_SISTEMAS");
            builder.Property(e => e.Aceptacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACEPTACION");
            builder.Property(e => e.CambiaClave)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CAMBIA_CLAVE");
            builder.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            builder.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            builder.Property(e => e.EstadoLogin)
                .HasPrecision(3)
                .HasColumnName("ESTADO_LOGIN");
            builder.Property(e => e.FecUltLogin)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ULT_LOGIN");
            builder.Property(e => e.FechaCreacion)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_CREACION");
            builder.Property(e => e.FechaEgreso)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_EGRESO");
            builder.Property(e => e.FechaIngreso)
                .HasColumnType("DATE")
                .HasColumnName("FECHA_INGRESO");
            builder.Property(e => e.Grupo)
                .HasPrecision(18)
                .HasColumnName("GRUPO");
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
            builder.Property(e => e.Nit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NIT");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            builder.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            builder.Property(e => e.Password2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD2");
            builder.Property(e => e.Puesto)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PUESTO");
            builder.Property(e => e.PuestoResponsable)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PUESTO_RESPONSABLE");
            builder.Property(e => e.RespaldoEgreso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESPALDO_EGRESO");
            builder.Property(e => e.ResponsableSuperior)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RESPONSABLE_SUPERIOR");
            builder.Property(e => e.SesionMultiple)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SESION_MULTIPLE");
            builder.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            builder.Property(e => e.Ubicacion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UBICACION");
            builder.Property(e => e.UltFecCambioClave)
                .HasColumnType("DATE")
                .HasColumnName("ULT_FEC_CAMBIO_CLAVE");
            builder.Property(e => e.UnidadAdministrativa)
                .HasPrecision(18)
                .HasColumnName("UNIDAD_ADMINISTRATIVA");
            builder.Property(e => e.UsuarioSupervisa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO_SUPERVISA");

            builder.HasOne(d => d.GrupoNavigation).WithMany(p => p.AdUsuarios)
                .HasForeignKey(d => d.Grupo)
                .HasConstraintName("FK_AD_USUARIOS_AD_GRUPOS");
        }
    }
}
