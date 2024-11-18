using JustaBlog.Contracts.Enums;

namespace JustaBlog.Contracts.Entities;

public class Post : BaseEntity
{
    public string Title { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public Guid AuthorId { get; set; }
    public User Author { get; set; }
    public string Slug { get; set; }
    public PostStatus PostStatus { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDate { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Tag> Tags { get; set; }
}