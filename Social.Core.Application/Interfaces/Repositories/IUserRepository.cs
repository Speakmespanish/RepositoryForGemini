using Social.Core.Application.ViewModels.User;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<(bool Result, User user_loged, string Message)> LoginAsync(LoginUser_vm user);
    }
}
