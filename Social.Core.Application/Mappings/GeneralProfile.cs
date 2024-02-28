using AutoMapper;
using Social.Core.Application.ViewModels.Comment;
using Social.Core.Application.ViewModels.Friendship;
using Social.Core.Application.ViewModels.Post;
using Social.Core.Application.ViewModels.ReplyComment;
using Social.Core.Application.ViewModels.User;
using Social.Core.Domain.Entities;

namespace Social.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Creacion mapeos para <Entities, SaveEntitiesVM>
            CreateMap<User, SaveUser_vm>()
                    .ReverseMap();

            CreateMap<ReplyComment, SaveReplyComment_vm>()
                    .ReverseMap();

            CreateMap<Post, SavePost_vm>()
                    .ReverseMap();

            CreateMap<Friendship, SaveFriendship_vm>()
                    .ReverseMap();

            CreateMap<Comment, SaveComment_vm>()
                    .ReverseMap();
            #endregion

            #region Creacion mapeos para <Entities, EntitiesVM>
            CreateMap<User, GetUser_vm>()
                    .ReverseMap();

            CreateMap<ReplyComment, GetReplyComment_vm>()
                    .ReverseMap();

            CreateMap<Post, GetPost_vm>()
                    .ReverseMap();

            CreateMap<Friendship, GetFriendship_vm>()
                    .ReverseMap();

            CreateMap<Comment, GetComment_vm>()
                    .ReverseMap();
            #endregion
        }
    }
}
