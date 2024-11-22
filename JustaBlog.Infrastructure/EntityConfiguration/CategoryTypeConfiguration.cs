using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustaBlog.Infrastructure.EntityConfiguration;

public class CategoryTypeConfiguration : BaseEntityTypeConfiguration<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
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