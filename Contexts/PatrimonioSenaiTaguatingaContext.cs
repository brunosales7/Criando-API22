using Microsoft.EntityFrameworkCore;
using VoeAirlines.Entities;
using VoeAirlines.EntityConfigurations;

namespace VoeAirlines.Contexts
{
    
    public class VoeAirlinesContext : DbContext
    {

        private readonly IConfiguration _configuration;
        public VoeAirlinesContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }        
        
        public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
        public DbSet<Cancelamento> Cancelamentos => Set<Cancelamento>();
        public DbSet<Manutencao> Manutencoes => Set<Manutencao>();
        public DbSet<Piloto> Pilotos => Set<Piloto>();
        public DbSet<Voo> Voos => Set<Voo>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("VoeAirlines"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AeronaveConfiguration());
            modelBuilder.ApplyConfiguration(new CancelamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ManutencaoConfiguration());
            modelBuilder.ApplyConfiguration(new PilotoConfiguration());
            modelBuilder.ApplyConfiguration(new VooConfiguration());
        }
    }
}