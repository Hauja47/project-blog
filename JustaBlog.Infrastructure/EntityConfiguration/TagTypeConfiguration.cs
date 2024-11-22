using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustaBlog.Infrastructure.EntityConfiguration;

public class TagTypeConfiguration : BaseEntityTypeConfiguration<Tag>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        base.Configure(builder);

        builder
            .HasIndex(t => t.Name)
            .IsUnique();

        builder
            .HasIndex(t => t.Slug)
            .IsUnique();
    }
}