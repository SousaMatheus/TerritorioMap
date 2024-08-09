using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Builders
{
    internal class RuaBuilder : IEntityTypeConfiguration<Rua>
    {
        public void Configure(EntityTypeBuilder<Rua> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName($"PK_{nameof(Rua)}");

            builder.HasMany(e => e.Casas)
                .WithOne(q => q.Rua)
                .HasForeignKey(q => q.Id)
                .HasConstraintName("FK_Casa_Rua_RuaID");
        }
    }
}
