using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Builders
{
    internal class CasaBuilder : IEntityTypeConfiguration<Casa>
    {
        public void Configure(EntityTypeBuilder<Casa> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName($"fk_{nameof(Casa)}");
        }
    }
}
