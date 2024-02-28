using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Domain.Entities;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class ReplyCommentRepository : GenericRepository<ReplyComment>, IReplyCommentRepository
    {
        private readonly SocialContext _context;

        public ReplyCommentRepository (SocialContext context) : base (context)
        {
            _context = context;
        }
    }
}
