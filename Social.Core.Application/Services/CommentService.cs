using AutoMapper;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.Interfaces.Services;
using Social.Core.Application.ViewModels.Comment;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Services
{
    public class CommentService : GenericService<SaveComment_vm, GetComment_vm, Comment>, ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService (ICommentRepository commentRepository, IMapper mapper) : base (mapper, commentRepository)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }
    }
}
