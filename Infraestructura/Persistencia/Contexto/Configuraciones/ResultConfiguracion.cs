using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class ResultConfiguracion : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder
                .HasNoKey()
            .ToTable("RESULTS");

            builder.Property(e => e.Actobra)
                .HasPrecision(3)
                .HasColumnName("ACTOBRA");
            builder.Property(e => e.ActobraNs)
                .HasPrecision(3)
                .HasColumnName("ACTOBRA_NS");
            builder.Property(e => e.ClaseGasto)
                .HasPrecision(3)
                .HasColumnName("CLASE_GASTO");
            builder.Property(e => e.Directiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DIRECTIVA");
            builder.Property(e => e.Ejercicio)
                .HasPrecision(4)
                .HasColumnName("EJERCICIO");
            builder.Property(e => e.Entidad)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD");
            builder.Property(e => e.EntidadNs)
                .HasPrecision(6)
                .HasColumnName("ENTIDAD_NS");
            builder.Property(e => e.FecAct)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ACT");
            builder.Property(e => e.FecIng)
                .HasColumnType("DATE")
                .HasColumnName("FEC_ING");
            builder.Property(e => e.Funcion)
                .HasPrecision(3)
                .HasColumnName("FUNCION");
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
            builder.Property(e => e.NivelEstructura)
                .HasPrecision(1)
                .HasColumnName("NIVEL_ESTRUCTURA");
            builder.Property(e => e.NoProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NO_PROYECTO");
            builder.Property(e => e.NomEstructura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_ESTRUCTURA");
            builder.Property(e => e.Programa)
                .HasPrecision(3)
                .HasColumnName("PROGRAMA");
            builder.Property(e => e.ProgramaNs)
                .HasPrecision(3)
                .HasColumnName("PROGRAMA_NS");
            builder.Property(e => e.Proyecto)
                .HasPrecision(3)
                .HasColumnName("PROYECTO");
            builder.Property(e => e.ProyectoNs)
                .HasPrecision(3)
                .HasColumnName("PROYECTO_NS");
            builder.Property(e => e.Subprograma)
                .HasPrecision(3)
                .HasColumnName("SUBPROGRAMA");
            builder.Property(e => e.SubprogramaNs)
                .HasPrecision(3)
                .HasColumnName("SUBPROGRAMA_NS");
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
