using JustaBlog.Contracts.Entities;
using JustaBlog.Contracts.Interfaces.Repositories;
using JustaBlog.Infrastructure.Data;

namespace JustaBlog.Infrastructure.Repositories;

public class TagRepository(BlogDbContext dbContext) : GenericRepository<Tag>(dbContext), ITagRepository
{
    
}