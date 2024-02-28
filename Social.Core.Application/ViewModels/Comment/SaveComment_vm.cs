using System.ComponentModel.DataAnnotations;

namespace Social.Core.Application.ViewModels.Comment
{
    public class SaveComment_vm
    {
        [Required(ErrorMessage = "Este campo necesita un valor")] [StringLength(400, ErrorMessage = "Limite de caracteres excedido")]
        public string Content { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }
    }
}
