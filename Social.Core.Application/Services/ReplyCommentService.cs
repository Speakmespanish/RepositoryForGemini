using AutoMapper;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.Interfaces.Services;
using Social.Core.Application.ViewModels.ReplyComment;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Services
{
    public class ReplyCommentService : GenericService<SaveReplyComment_vm, GetReplyComment_vm, ReplyComment>, IReplyCommentService
    {
        private readonly IReplyCommentRepository _replyrepository;
        private readonly IMapper _mapper;

        public ReplyCommentService (IReplyCommentRepository replyrepository, IMapper mapper) : base (mapper, replyrepository)
        {
            _replyrepository = replyrepository;
            _mapper = mapper;
        }
    }
}
