using Social.Core.Application.ViewModels.Comment;
using Social.Core.Application.ViewModels.User;

namespace Social.Core.Application.ViewModels.Post
{
    public class GetPost_vm
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ImagePath { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetUser_vm User { get; set; }

        public ICollection<GetComment_vm> Comments { get; set; }
    }
}
