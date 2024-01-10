using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InteractiveMapProject.Contracts.Entities;
namespace InteractiveMapProject.Data.Db.Configurations;

public class ProfessionalConfiguration : IEntityTypeConfiguration<Professional>
{

    public void Configure(EntityTypeBuilder<Professional> builder)
    {
        builder.ToTable("Professionals");

        builder.HasKey(p => p.Id);

        builder
            .OwnsOne(p => p.Address);

        builder
            .OwnsOne(p => p.ContactPerson);

        builder
            .HasMany(p => p.Audiences)
            .WithOne(p => p.Professional);

        builder
            .HasMany(p => p.PlacesOfIntervention)
            .WithOne(p => p.Professional);

        builder
            .HasMany(p => p.Missions)
            .WithOne(p => p.Professional);

        builder
            .OwnsOne(p => p.Geolocation);
    }
}
