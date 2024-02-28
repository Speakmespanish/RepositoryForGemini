using Social.Core.Application.ViewModels.Comment;
using Social.Core.Application.ViewModels.User;

namespace Social.Core.Application.ViewModels.ReplyComment
{
    public class GetReplyComment_vm
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetUser_vm User { get; set; }

        public GetComment_vm Comment { get; set; }
    }
}
