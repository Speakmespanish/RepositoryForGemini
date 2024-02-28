using Social.Core.Application.ViewModels.Post;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Interfaces.Services
{
    public interface IPostService : IGenericService<SavePost_vm, GetPost_vm, Post>
    {
    }
}
