using JustaBlog.Contracts.Enums;

namespace JustaBlog.Contracts.Entities;

public class Post : BaseEntity
{
    public string Title { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    // public Guid AuthorId { get; set; }
    public int AuthorSub { get; set; }
    public string Slug { get; set; }
    public PostStatus PostStatus { get; set; }
    public string Content { get; set; }
    public DateTime? PublishedDate { get; set; }
    public IEnumerable<Comment>? Comments { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
    public int TotalLikes { get; set; }
    public int TotalViews { get; set; }
}