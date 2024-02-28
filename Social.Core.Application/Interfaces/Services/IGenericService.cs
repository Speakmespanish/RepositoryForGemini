namespace Social.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveEntityVM, EntityVM, Model>
        where SaveEntityVM : class
        where EntityVM : class
        where Model : class
    {
        Task<bool> Create(SaveEntityVM entity);
        Task<EntityVM> GetById(int id);
        Task<ICollection<EntityVM>> GetAll();
        Task<bool> Update(SaveEntityVM entity, int Id);
        Task<bool> Delete(EntityVM entity);
    }
}
