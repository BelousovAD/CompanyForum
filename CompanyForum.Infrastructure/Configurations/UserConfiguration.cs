using CompanyForum.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyForum.Infrastructure.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);
        builder.ToTable("Users");
        BuildLinks(builder);
    }

    private static void BuildLinks(EntityTypeBuilder<User> builder)
    {
        builder
            .HasMany(user => user.Tags)
            .WithMany()
            .UsingEntity(join =>
            {
                join.ToTable("TagUserJoins");
                join.Property<Guid>("TagsId").HasColumnName("TagId");
            });
    }
}