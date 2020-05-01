using Dal.models;
using Microsoft.EntityFrameworkCore;

namespace Dal.pgDB
{
    public sealed class MorafikContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Server=localhost;Database=morafik;Username=myuser;Password=mypass");

        public DbSet<User> Users { get; set; }
        public DbSet<Sighted> Sighteds { get; set; }
        public DbSet<Blind> Blinds { get; set; }
    }
}