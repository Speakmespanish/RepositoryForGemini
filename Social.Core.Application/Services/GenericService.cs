using AutoMapper;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.Interfaces.Services;

namespace Social.Core.Application.Services
{
    public class GenericService<SaveEntityVM, EntityVM, Model> : IGenericService<SaveEntityVM, EntityVM, Model>
        where SaveEntityVM : class
        where EntityVM : class
        where Model : class
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Model> _genericrepository;

        public GenericService (IMapper mapper, IGenericRepository<Model> genericrepository)
        {
            _mapper = mapper;
            _genericrepository = genericrepository;
        }


        public virtual async Task<bool> Create(SaveEntityVM entity)
        {
            try
            {
                Model model = _mapper.Map<Model>(entity);
                return await _genericrepository.Create(model);
            }
            catch { return false; }
        }


        public virtual async Task<bool> Delete(EntityVM entity)
        {
            try
            {
                Model model = _mapper.Map<Model>(entity);
                return await _genericrepository.Delete(model);
            }
            catch { return false; }
        }


        public virtual async Task<ICollection<EntityVM>> GetAll()
        {
            try
            {
                ICollection<EntityVM> Entity= _mapper.Map<ICollection<EntityVM>>(await _genericrepository.GetAll());
                
                return Entity;
            }
            catch { return null; }
        }

          
        public virtual async Task<EntityVM> GetById(int id)
        {
            try
            {
                return _mapper.Map<EntityVM>(await _genericrepository.GetById(id));
            }
            catch { return null; }
        }


        public virtual async Task<bool> Update(SaveEntityVM entity, int Id)
        {
            try
            {
                return await _genericrepository.Update(_mapper.Map<Model>(entity), Id);
            }
            catch { return false; }
        }
    }
}
