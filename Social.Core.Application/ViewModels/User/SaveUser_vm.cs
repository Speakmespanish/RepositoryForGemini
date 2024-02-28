using System.ComponentModel.DataAnnotations;

namespace Social.Core.Application.ViewModels.User
{
    public class SaveUser_vm
    {
        [Required] [StringLength(50)]
        public string Name { get; set; }

        [Required] [StringLength(75)]
        public string LastName { get; set; }

        [Required] [StringLength(150)]
        public string Email { get; set; }

        [Required] [MaxLength(250)]
        public string Password { get; set; }

        public string Phone { get; set; }
        public string ImagePath { get; set; }
    }
}
