using AutoMapper;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.Interfaces.Services;
using Social.Core.Application.ViewModels.Post;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Services
{
    public class PostService : GenericService<SavePost_vm, GetPost_vm, Post>, IPostService
    {
        private readonly IPostRepository _postrepository;
        private readonly IMapper _mapper;

        public PostService (IPostRepository postrepository, IMapper mapper) : base (mapper, postrepository)
        {
            _postrepository = postrepository;
            _mapper = mapper;
        }
    }
}
