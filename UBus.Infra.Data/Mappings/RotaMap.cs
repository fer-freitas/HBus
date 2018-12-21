using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBus.Domain.Models;

namespace UBus.Infra.Data.Mappings
{
    public class RotaMap : IEntityTypeConfiguration<Rota>
    {
        public void Configure(EntityTypeBuilder<Rota> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Origem)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Destino)
              .HasColumnType("varchar(50)")
              .HasMaxLength(50)
              .IsRequired();

            builder.Property(c => c.Inicio)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.Fim)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.Valor)
                .HasColumnType("numeric(5,2)")
                .IsRequired();
        }
    }
}
