using JustaBlog.Contracts.Entities;
using JustaBlog.Contracts.Interfaces.Repositories;
using JustaBlog.Infrastructure.Data;

namespace JustaBlog.Infrastructure.Repositories;

public class CategoryRepository(BlogDbContext dbContext) : GenericRepository<Category>(dbContext), ICategoryRepository
{
    
}