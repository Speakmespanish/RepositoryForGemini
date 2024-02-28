using Social.Core.Application.ViewModels.Post;
using Social.Core.Application.ViewModels.ReplyComment;
using Social.Core.Application.ViewModels.User;

namespace Social.Core.Application.ViewModels.Comment
{
    public class GetComment_vm
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetPost_vm Post { get; set; }

        public GetUser_vm User { get; set; }

        public ICollection<GetReplyComment_vm> Replys { get; set; }
    }
}
