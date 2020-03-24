using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info.EntitiesConfiguration
{
    class DoctorPacientConfiguration : IEntityTypeConfiguration<DoctorPacient>
    {
        public void Configure(EntityTypeBuilder<DoctorPacient> builder)
        {
            builder.HasKey(doctorPacient => new { doctorPacient.DoctorId, doctorPacient.PacientId });

            builder.HasOne(doctorPacient => doctorPacient.Doctor)
                    .WithMany(doctor => doctor.DoctorPacients);

            builder.HasOne(doctorPacient => doctorPacient.Pacient)
                    .WithMany(pacient => pacient.DoctorPacients);
        }
    }
}
