using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore
{
    public sealed class PersonsContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public PersonsContext()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlDatabaseString.ClassLibraryNetCore);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Property(person => person.FirstName).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Person>().Property(person => person.LastName).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Person>().Property(person => person.MiddleName).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Person>().Property(person => person.TelephoneNumber).HasMaxLength(10).IsRequired();

        }
    }
}
