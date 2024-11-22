using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustaBlog.Infrastructure.EntityConfiguration;

public class CommentTypeConfiguration : BaseEntityTypeConfiguration<Comment>
{
    public override void Configure(EntityTypeBuilder<Comment> builder)
    {
        base.Configure(builder);
        
        
    }
}