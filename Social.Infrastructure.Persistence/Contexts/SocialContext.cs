using Microsoft.EntityFrameworkCore;
using Social.Core.Domain.Entities;

namespace Social.Infrastructure.Persistence.Contexts
{
    public class SocialContext : DbContext
    {
        public SocialContext(DbContextOptions options) : base(options)
        {
        }

        //Creacion de los DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<ReplyComment> ReplyComments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configuracion para entidad User
            modelBuilder.Entity<User>(model =>
            {
                model.ToTable("Users");
                model.HasKey(k => k.Id);
                model.Property(p => p.Name).IsRequired().HasMaxLength(50);
                model.Property(p => p.LastName).IsRequired().HasMaxLength(75);
                model.Property(p => p.Email).IsRequired().HasMaxLength(150);
                model.Property(p => p.Password).IsRequired().HasMaxLength(250);
                model.Property(p => p.Phone).HasMaxLength(16);

                //Relaciones
                model.HasMany(fk => fk.Friendships)
                    .WithOne(_fk => _fk.User1)
                    .HasForeignKey(f => f.User1Id)
                        .OnDelete(DeleteBehavior.Cascade);

                model.HasMany(fk => fk.Posts)
                    .WithOne(_fk => _fk.User)
                    .HasForeignKey(f => f.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

                model.HasMany(fk => fk.Comments)
                    .WithOne(_fk => _fk.User)
                    .HasForeignKey(f => f.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

                model.HasMany(fk => fk.ReplyComments)
                    .WithOne(_fk => _fk.User)
                    .HasForeignKey(f => f.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion


            #region Configuracion para entidad ReplyComment
            modelBuilder.Entity<ReplyComment>(model =>
            {
                model.ToTable("ReplyComments");
                model.HasKey(k => k.Id);
                model.Property(p => p.Content).IsRequired();
            });
            #endregion


            #region Configuracion para entidad Post
            modelBuilder.Entity<Post>(model =>
            {
                model.ToTable("Posts");
                model.HasKey(k => k.Id);
                model.Property(p => p.Title).IsRequired().HasMaxLength(50);
                model.Property(p => p.Content).HasMaxLength(750);

                //Relaciones
                model.HasOne(fk => fk.User)
                    .WithMany(_fk => _fk.Posts)
                    .HasForeignKey(f => f.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

                model.HasMany(fk => fk.Comments)
                    .WithOne(_fk => _fk.Post)
                    .HasForeignKey(f => f.PostId)
                        .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion


            #region Configuracion para entidad Friendship
            modelBuilder.Entity<Friendship>(model =>
            {
                model.ToTable("Friendships");
                model.HasKey(k => k.Id);

                //Relaciones
                model.HasOne(fk => fk.User1)
                    .WithMany(_fk => _fk.Friendships)
                    .HasForeignKey(f => f.User1Id)
                        .OnDelete(DeleteBehavior.Cascade);

                model.HasOne(fk => fk.User2)
                    .WithMany(_fk => _fk.Friendships)
                    .HasForeignKey(f => f.User2Id)
                        .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion


            #region Configuracion para entidad Comment
            modelBuilder.Entity<Comment>(model =>
            {
                model.ToTable("Comments");
            });
            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}
