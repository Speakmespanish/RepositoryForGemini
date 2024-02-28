using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Domain.Entities;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        private readonly SocialContext _context;

        public PostRepository (SocialContext context) : base (context)
        {
            _context = context;
        }
    }
}
