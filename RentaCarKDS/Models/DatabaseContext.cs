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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=RentaCarDb.db");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<TableCategory> TableCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(n => n.Password)
                .IsRequired();
            modelBuilder.Entity<Admin>()
                .Property(sn => sn.Surname)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(ch => ch.ChassisNo)
                .IsRequired();
            modelBuilder.Entity<Car>()
                .Property(pl => pl.Plate)
                .IsRequired();
            modelBuilder.Entity<Car>()
                .Property(dp => dp.DatePrice)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(n => n.Name)
                .IsRequired();
            modelBuilder.Entity<Department>()
                .Property(ct => ct.City)
                .IsRequired();
        }
    }
}
