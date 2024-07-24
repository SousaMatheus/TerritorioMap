using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MapeamentoTerritorio.Models;

namespace MapeamentoTerritorio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected readonly IConfiguration Configuration;
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mapa> Mapas { get; set; }
        public DbSet<Quadra> Quadras { get; set; }
        public DbSet<Rua> Ruas { get; set; }
        public DbSet<Casa> Casas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
