using Microsoft.EntityFrameworkCore;

namespace RentaCarKDS.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<TableCategory> TableCategorys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
