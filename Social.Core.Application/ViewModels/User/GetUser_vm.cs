using Social.Core.Application.ViewModels.Friendship;
using Social.Core.Application.ViewModels.Post;

namespace Social.Core.Application.ViewModels.User
{
    public class GetUser_vm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ImagePath { get; set; }

        public ICollection<GetUser_vm> RequestFriend { get; set; }        //Solicitudes de amistades recibidas

        public ICollection<GetFriendship_vm> Friendships { get; set; }    //Amistades hechas ya sea por aceptacion del usuario o del otro usuario que tuvo dicha solicitud en RequestFriend

        public ICollection<GetPost_vm> Posts { get; set; }
    }
}
