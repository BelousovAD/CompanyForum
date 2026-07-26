using CompanyForum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyForum.Infrastructure.Configurations;

internal class IssueConfiguration : IEntityTypeConfiguration<Issue>
{
    public void Configure(EntityTypeBuilder<Issue> builder)
    {
        builder.HasKey(issue => issue.Id);
        builder.ToTable("Issues");
        BuildLinks(builder);
        BuildProperties(builder);
    }

    private static void BuildLinks(EntityTypeBuilder<Issue> builder)
    {
        builder
            .HasOne(issue => issue.User)
            .WithMany()
            .OnDelete(DeleteBehavior.SetNull);
        builder
            .HasMany(issue => issue.Tags)
            .WithMany()
            .UsingEntity(join =>
            {
                join.ToTable("TagIssueJoins");
                join.Property<Guid>("TagsId").HasColumnName("TagId");
            });
    }

    private static void BuildProperties(EntityTypeBuilder<Issue> builder)
    {
        builder.Property(issue => issue.Title).IsRequired();
        builder.Property(issue => issue.Description).IsRequired();
    }
}