using CompanyForum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyForum.Infrastructure.Configurations;

internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(comment => comment.Id);
        builder.ToTable("Comments");
        BuildLinks(builder);
        BuildProperties(builder);
    }

    private static void BuildLinks(EntityTypeBuilder<Comment> builder)
    {
        builder
            .HasOne(comment => comment.Branch)
            .WithMany()
            .OnDelete(DeleteBehavior.Cascade);
        builder
            .HasOne(comment => comment.User)
            .WithMany()
            .OnDelete(DeleteBehavior.SetNull);
    }

    private static void BuildProperties(EntityTypeBuilder<Comment> builder) =>
        builder.Property(comment => comment.Text).IsRequired();
}