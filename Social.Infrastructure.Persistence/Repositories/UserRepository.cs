using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Domain.Entities;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly SocialContext _context;

        public UserRepository (SocialContext context) : base (context)
        {
            _context = context;
        }
    }
}
