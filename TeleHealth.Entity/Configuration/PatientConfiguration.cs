using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeleHealth.Entity.Patients;

namespace TeleHealth.Entity.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Firstname).IsRequired();

            builder.Property(x => x.Lastname).IsRequired();

            builder.Property(x => x.Gender).IsRequired();
        }
    }
}
