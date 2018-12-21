using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UBus.Domain.Models;

namespace UBus.Infra.Data.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.PrimeiroNome)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.UltimoNome)
               .HasColumnType("varchar(50)")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(c => c.Ativo)
               .HasColumnType("bit")
               .IsRequired();
        }
    }
}
