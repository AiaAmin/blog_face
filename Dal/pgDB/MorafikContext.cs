using Dal.models;
using Microsoft.EntityFrameworkCore;

namespace Dal.pgDB
{
    public sealed class MorafikContext : DbContext
    {
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Server=localhost;Database=morafik;Username=postgres;Password=747774909");*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Server=localhost;Database=morafik;Username=myuser;Password=mypass");

        public DbSet<User> Users { get; set; }
        public DbSet<Sighted> Sighteds { get; set; }
        public DbSet<Blind> Blinds { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceTime> ServiceTimes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<SightedLanguage> SightedLanguages { get; set; }
        public DbSet<SightedService> SightedServices { get; set; }
        public DbSet<SightedSkill> SightedSkills { get; set; }
    }
}