namespace Social.Core.Domain.Entities
{
    public class Friendship
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        //Relaciones
        public int User1Id { get; set; }
        public User User1 { get; set; } 

        public int User2Id { get; set;}
        public User User2 { get; set; } 
    }
}
