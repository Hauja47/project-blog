using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustaBlog.Infrastructure.EntityConfiguration;

public class PostInteractionTypeConfiguration : BaseEntityTypeConfiguration<PostInteraction>
{
    public override void Configure(EntityTypeBuilder<PostInteraction> builder)
    {
        base.Configure(builder);

        builder
            .HasIndex(p => p.Type)
            .HasFilter("Type = 'like'")
            .HasDatabaseName("like_post_interaction_type");
        
        builder
            .HasIndex(p => p.Type)
            .HasFilter("Type = 'view'")
            .HasDatabaseName("view_post_interaction_type");
        
        builder
            .HasIndex(p => p.Type)
            .HasFilter("Type = 'unlike'")
            .HasDatabaseName("unlike.post_interaction_type");
    }
}