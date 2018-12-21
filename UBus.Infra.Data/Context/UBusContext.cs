using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using UBus.Domain.Models;
using UBus.Infra.Data.Mappings;

namespace UBus.Infra.Data.Context
{
    public class UBusContext : DbContext
    {
        public UBusContext(DbContextOptions<UBusContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Rota> Rotas { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new RotaMap());
            modelBuilder.ApplyConfiguration(new ItinerarioMap());
            modelBuilder.ApplyConfiguration(new ViagemMap());
            modelBuilder.ApplyConfiguration(new VeiculoMap());
        }
    }
}
