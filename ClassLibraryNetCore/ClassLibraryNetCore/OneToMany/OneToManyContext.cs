using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore.OneToMany
{
    public sealed class OneToManyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public OneToManyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlDatabaseString.ClassLibraryNetCore);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(customer => customer.City).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Customer>().Property(customer => customer.Name).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Customer>()
                        .HasMany(customer => customer.Orders)
                        .WithOne(order => order.Customer);
        }
    }
}
