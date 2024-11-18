using JustaBlog.Contracts.Enums;

namespace JustaBlog.Contracts.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public RecordStatus RecordStatus { get; set; }
}