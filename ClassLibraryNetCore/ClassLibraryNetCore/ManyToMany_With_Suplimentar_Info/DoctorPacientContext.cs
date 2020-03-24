using ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info
{
    public class DoctorPacientContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<DoctorPacient> DoctorPacients { get; set; }

        public DoctorPacientContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SqlDatabaseString.ClassLibraryNetCore);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new PacientConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorPacientConfiguration());
        }
    }
}