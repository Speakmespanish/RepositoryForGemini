using Social.Core.Application.ViewModels.Comment;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Interfaces.Services
{
    public interface ICommentService : IGenericService<SaveComment_vm, GetComment_vm, Comment>
    {
    }
}
