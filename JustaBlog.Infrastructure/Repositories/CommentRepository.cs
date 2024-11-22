using JustaBlog.Contracts.Entities;
using JustaBlog.Contracts.Interfaces.Repositories;
using JustaBlog.Infrastructure.Data;

namespace JustaBlog.Infrastructure.Repositories;

public class CommentRepository(BlogDbContext dbContext) : GenericRepository<Comment>(dbContext), ICommentRepository
{
    
}