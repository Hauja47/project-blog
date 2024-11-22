using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustaBlog.Infrastructure.EntityConfiguration;

public class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder
            .HasKey(e => e.Id);
        
        // builder
        //     .Property(e => e.Id)
        //     .UseHiLo();
        
        builder
            .Property(b => b.CreateAt)
            .ValueGeneratedOnAdd();
        
        builder
            .Property(b => b.UpdateAt)
            .ValueGeneratedOnUpdate();
    }
}