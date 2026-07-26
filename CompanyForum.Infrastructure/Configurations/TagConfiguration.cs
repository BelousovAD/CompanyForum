using CompanyForum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyForum.Infrastructure.Configurations;

internal class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(tag => tag.Id);
        builder.ToTable("Tags");
        BuildProperties(builder);
    }

    private static void BuildProperties(EntityTypeBuilder<Tag> builder) =>
        builder.Property(tag => tag.Text).IsRequired();
}