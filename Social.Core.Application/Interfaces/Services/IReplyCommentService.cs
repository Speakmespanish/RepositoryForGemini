using Social.Core.Application.ViewModels.ReplyComment;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Interfaces.Services
{
    public interface IReplyCommentService : IGenericService<SaveReplyComment_vm, GetReplyComment_vm, ReplyComment>
    {
    }
}
