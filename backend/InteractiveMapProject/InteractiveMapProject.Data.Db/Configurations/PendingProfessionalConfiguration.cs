using InteractiveMapProject.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations;

public class PendingProfessionalConfiguration : IEntityTypeConfiguration<PendingProfessional>
{
    public void Configure(EntityTypeBuilder<PendingProfessional> builder)
    {
        builder.ToTable("PendingProfessionals");

        builder.HasKey(p => p.Id);

        builder
            .OwnsOne(p => p.Address);

        builder
            .OwnsOne(p => p.ContactPerson);

        builder
            .HasMany(p => p.Audiences)
            .WithOne(p => p.PendingProfessional);

        builder
            .HasMany(p => p.PlacesOfIntervention)
            .WithOne(p => p.PendingProfessional);

        builder
            .HasMany(p => p.Missions)
            .WithOne(p => p.PendingProfessional);

        builder
            .OwnsOne(p => p.Geolocation);

        builder
            .HasOne(p => p.ValidationStatus)
            .WithMany(vs => vs.PendingProfessionals)
            .HasForeignKey(p => p.ValidationStatusId);

        builder
            .HasOne(p => p.Professional)
            .WithMany(p => p.PendingProfessionals)
            .HasForeignKey(p => p.ProfessionalId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
