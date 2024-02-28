using Social.Core.Application.ViewModels.Friendship;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Interfaces.Services
{
    public interface IFriendshipService : IGenericService<SaveFriendship_vm, GetFriendship_vm, Friendship>
    {
    }
}
