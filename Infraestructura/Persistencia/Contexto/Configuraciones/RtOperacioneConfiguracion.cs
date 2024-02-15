﻿using AdminSys.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admon.Infraestructura.Persistencia.context.Configuraciones
{
    public class RtOperacioneConfiguracion : IEntityTypeConfiguration<RtOperacione>
    {
        public void Configure(EntityTypeBuilder<RtOperacione> builder)
        {
            builder
                .HasNoKey()
            .ToTable("RT_OPERACIONES");

            builder.Property(e => e.ClaseDeRegistro)
                .HasPrecision(18)
                .HasColumnName("CLASE_DE_REGISTRO");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            builder.Property(e => e.Detabla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DETABLA");
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
            builder.Property(e => e.Notas)
                .HasColumnType("CLOB")
                .HasColumnName("NOTAS");
            builder.Property(e => e.Operacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            builder.Property(e => e.Tabla)
                .HasPrecision(18)
                .HasColumnName("TABLA");
            builder.Property(e => e.Tid)
                .HasPrecision(18)
                .HasColumnName("TID");
        }
    }
}
