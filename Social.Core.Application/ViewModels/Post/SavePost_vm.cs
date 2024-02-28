using Social.Core.Application.ViewModels.Comment;
using Social.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Social.Core.Application.ViewModels.Post
{
    public class SavePost_vm
    {
        [Required(ErrorMessage = "Este campo necesita un valor")] [StringLength(50)]
        public string Title { get; set; }

        [StringLength(750, ErrorMessage ="No puede exceder los 750 caracteres")]
        public string Content { get; set; }

        public string ImagePath { get; set; }

        public int UserId { get; set; }

        public ICollection<GetComment_vm> Comments { get; set; }
    }
}
