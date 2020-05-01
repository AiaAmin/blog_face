using Dal.models;
using Microsoft.EntityFrameworkCore;

namespace Dal.DAL.pgDB
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=my_blog;Username=my_user;Password=my_pass");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<NormalUser> NormalUsers { get; set; }
        public DbSet<LoginSession> LoginSessions { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}