using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Builders
{
    internal class QuadraBuilder : IEntityTypeConfiguration<Quadra>
    {
        public void Configure(EntityTypeBuilder<Quadra> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName($"PK_{nameof(Quadra)}");

            builder.HasMany(e => e.Ruas)
                .WithOne(q => q.Quadra)
                .HasForeignKey(q => q.QuadraId)
                .HasConstraintName("FK_Rua_Quadra_QuadraId");
        }
    }
}
