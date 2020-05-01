using Microsoft.EntityFrameworkCore;

namespace Dal.pgDB
{
    public class MorafikContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=morafik;Username=my_user;Password=my_pass");
        }
    }
}