using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBus.Domain.Models;

namespace UBus.Infra.Data.Mappings
{
    public class ItinerarioMap : IEntityTypeConfiguration<Itinerario>
    {
        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Local)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Hora)
                .HasColumnType("varchar(5)")
                .HasMaxLength(5)
                .IsRequired();
        }
    }
}
