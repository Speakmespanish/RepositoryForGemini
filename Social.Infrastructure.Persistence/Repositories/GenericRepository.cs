using Microsoft.EntityFrameworkCore;
using Social.Core.Application.Interfaces.Repositories;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity>
        where Entity : class
    {
        private readonly SocialContext _context;

        public GenericRepository(SocialContext context)
        {
            _context = context;
        }

        public virtual async Task<bool> Create(Entity entity)
        {
            try
            {
                await _context.Set<Entity>().AddAsync(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch { return false; }
        }

        public virtual async Task<bool> Delete(Entity entity)
        {
            try
            {
                _context.Set<Entity>().Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch { return false; }
        }

        public virtual async Task<ICollection<Entity>> GetAll()
        {
            try
            {
                return await _context.Set<Entity>().ToListAsync();
            }
            catch { return null; }
        }

        public virtual async Task<Entity> GetById(int id)
        {
            try
            {
                return await _context.Set<Entity>().FindAsync(id);
            }
            catch { return null; }
        }

        public virtual async Task<bool> Update(Entity entity, int Id)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }
            catch { return false; }
        }
    }
}
