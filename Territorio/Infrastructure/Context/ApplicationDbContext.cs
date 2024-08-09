using Domain.Models;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MapeamentoTerritorio.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
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
        }
    }
}
