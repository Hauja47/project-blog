using JustaBlog.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace JustaBlog.Infrastructure.Data;

public class BlogDbContext(DbContextOptions<BlogDbContext> options) : DbContext(options)
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<PostInteraction> PostInteractions { get; set; }
    
    
}