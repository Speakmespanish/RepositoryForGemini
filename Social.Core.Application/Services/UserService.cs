using AutoMapper;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.Interfaces.Services;
using Social.Core.Application.ViewModels.User;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Services
{
    public class UserService : GenericService<SaveUser_vm, GetUser_vm, User>, IUserService
    {
        private readonly IUserRepository _userrepository;
        private readonly IMapper _mapper;

        public UserService (IUserRepository userrepository, IMapper mapper) : base (mapper, userrepository)
        {
            _userrepository = userrepository;
            _mapper = mapper;
        }
    }
}
