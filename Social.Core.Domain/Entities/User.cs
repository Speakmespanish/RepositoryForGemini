namespace Social.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public string ImagePath { get; set; }

        public ICollection<User> RequestFriend { get; set; }

        //Relaciones
        public ICollection<Friendship> Friendships { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<ReplyComment> ReplyComments { get; set; }
    }
}
