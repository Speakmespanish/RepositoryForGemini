using AutoMapper;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.Interfaces.Services;
using Social.Core.Application.ViewModels.Friendship;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Services
{
    public class FriendshipService : GenericService<SaveFriendship_vm, GetFriendship_vm, Friendship>, IFriendshipService
    {
        private readonly IFriendshipRepository _friendshiprepository;
        private readonly IMapper _mapper;

        public FriendshipService (IFriendshipRepository friendshiprepository, IMapper mapper) : base (mapper, friendshiprepository)
        {
            _friendshiprepository = friendshiprepository;
            _mapper = mapper;
        }
    }
}
