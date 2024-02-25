﻿namespace Social.Core.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ImagePath { get; set; }

        public DateTime CreatedAt { get; set; }
        
        //Relaciones
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
