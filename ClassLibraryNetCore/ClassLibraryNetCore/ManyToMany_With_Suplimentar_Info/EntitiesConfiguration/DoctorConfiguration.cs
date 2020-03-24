using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info.EntitiesConfiguration
{
    class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(doctor => doctor.FirstName)
                   .HasMaxLength(15)
                   .IsRequired();

            builder.Property(doctor => doctor.LastName)
                   .HasMaxLength(15)
                   .IsRequired();

            builder.Property(doctor => doctor.Specialty)
                   .HasMaxLength(15)
                   .IsRequired();
        }
    }
}
