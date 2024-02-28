using Social.Core.Application.ViewModels.User;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUser_vm, GetUser_vm, User>
    {
    }
}
