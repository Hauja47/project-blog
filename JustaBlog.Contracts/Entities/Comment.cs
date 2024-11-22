namespace JustaBlog.Contracts.Entities;

public class Comment : BaseEntity
{
    public Guid PostId { get; set; }
    public Post Post { get; set; }
    public Guid UserId { get; set; }
    public int UserSub { get; set; }
    public string Content { get; set; }
    public Guid? ParentCommentId { get; set; }
    public Comment? ParentComment { get; set; }
    public IEnumerable<Comment>? Replies { get; set; }
}