namespace Social.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<Entity>
        where Entity : class
    {
        Task<bool> Create (Entity entity);
        Task<Entity> GetById (int id);
        Task<ICollection<Entity>> GetAll ();
        Task<bool> Update (Entity entity, int Id);
        Task<bool> Delete (Entity entity);     
    }
}
