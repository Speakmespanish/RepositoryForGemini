using Social.Core.Application.ViewModels.User;

namespace Social.Core.Application.ViewModels.Friendship
{
    public class GetFriendship_vm
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public GetUser_vm User1 { get; set; }

        public GetUser_vm User2 { get; set; }
    }
}
