using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Domain.Entities;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly SocialContext _context;

        public CommentRepository (SocialContext context) : base (context)
        {
            _context = context;
        }
    }
}
