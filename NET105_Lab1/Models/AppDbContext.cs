using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
namespace NET105_Lab1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<employee> employees { get; set; }
        public DbSet<department> departments { get; set; }

    }
}
