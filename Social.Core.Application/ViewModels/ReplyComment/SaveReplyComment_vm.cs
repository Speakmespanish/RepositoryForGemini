using System.ComponentModel.DataAnnotations;

namespace Social.Core.Application.ViewModels.ReplyComment
{
    public class SaveReplyComment_vm
    {
        [Required] [StringLength(250)]
        public string Content { get; set; }

        public int UserId { get; set; }

        public int CommentId { get; set; }
    }
}
