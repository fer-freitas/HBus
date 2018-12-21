using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UBus.Domain.Models;

namespace UBus.Infra.Data.Mappings
{
    public class ViagemMap : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Latitude)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Longitude)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.DataAtualizacao)
               .HasColumnType("Datetime")
                .IsRequired();

            builder.Property(c => c.DataConclusao)
               .HasColumnType("Datetime");

            builder.Property(c => c.VeiculoId);
            builder.Property(c => c.RotaId);
            builder.Property(c => c.FuncionarioId);

        }
    }
}
