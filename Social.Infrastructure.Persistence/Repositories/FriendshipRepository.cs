using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Domain.Entities;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class FriendshipRepository : GenericRepository<Friendship>, IFriendshipRepository
    {
        private readonly SocialContext _context;

        public FriendshipRepository (SocialContext context) : base (context)
        {
            _context = context;
        }
    }
}
