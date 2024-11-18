namespace JustaBlog.Contracts.Entities;

public class Tag : BaseEntity
{
    public string Name { get; set; }
    public string Slug { get; set; }
}