using DateReminder.Models;
using Microsoft.EntityFrameworkCore;

namespace DateReminder
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
