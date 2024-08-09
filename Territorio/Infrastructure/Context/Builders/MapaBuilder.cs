using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Builders
{
    internal class MapaBuilder : IEntityTypeConfiguration<Mapa>
    {
        public void Configure(EntityTypeBuilder<Mapa> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName($"PK_{nameof(Mapa)}");

            builder.HasMany(m => m.Quadras)
                .WithOne(q => q.Mapa)
                .HasForeignKey(q => q.Id)
                .HasConstraintName("FK_Quadra_Mapa_IdMapa");
        }
    }
}
