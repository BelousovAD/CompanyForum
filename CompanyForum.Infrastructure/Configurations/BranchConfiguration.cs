using CompanyForum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyForum.Infrastructure.Configurations;

internal class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.HasKey(branch => branch.Id);
        builder.ToTable("Branches");
        BuildLinks(builder);
    }

    private static void BuildLinks(EntityTypeBuilder<Branch> builder)
    {
        builder
            .HasOne(branch => branch.Issue)
            .WithMany()
            .OnDelete(DeleteBehavior.Cascade);
        builder
            .HasOne(branch => branch.User)
            .WithMany()
            .OnDelete(DeleteBehavior.SetNull);
    }
}