using ChallengeSprint01.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeSprint01.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
