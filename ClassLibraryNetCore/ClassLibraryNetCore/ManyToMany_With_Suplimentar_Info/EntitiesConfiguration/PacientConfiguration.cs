using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info.EntitiesConfiguration
{
    public class PacientConfiguration : IEntityTypeConfiguration<Pacient>
    {
        public void Configure(EntityTypeBuilder<Pacient> builder)
        {
            builder.Property(pacient => pacient.FirstName)
                    .HasMaxLength(15)
                    .IsRequired();

            builder.Property(pacient => pacient.LastName)
                    .HasMaxLength(15)
                    .IsRequired();
        }
    }
}
