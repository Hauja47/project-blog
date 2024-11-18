using JustaBlog.Contracts.Enums;

namespace JustaBlog.Contracts.Entities;

public class PostInteraction : BaseEntity
{
    public Guid PostId { get; set; }
    public Guid UserId { get; set; }
    public InteractionType Type { get; set; }
}