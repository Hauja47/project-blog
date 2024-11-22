using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustaBlog.Infrastructure.EntityConfiguration;

public class PostTypeConfiguration : BaseEntityTypeConfiguration<Post>
{
    public override void Configure(EntityTypeBuilder<Post> builder)
    {
        base.Configure(builder);

        // builder
        //     .HasIndex(p => p.Title);

        builder
            .HasIndex(p => p.Slug)
            .IsUnique();
    }
}