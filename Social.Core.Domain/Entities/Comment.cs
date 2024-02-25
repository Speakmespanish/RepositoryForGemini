namespace Social.Core.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        //Relaciones
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<ReplyComment> Replys { get; set; }
    }
}
