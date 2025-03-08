using Microsoft.EntityFrameworkCore;
using OdontoPrevSprint03.Models;

namespace OdontoPrevSprint03.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id); 
        }
    }
}
