namespace JustaBlog.Contracts.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Slug { get; set; }
}