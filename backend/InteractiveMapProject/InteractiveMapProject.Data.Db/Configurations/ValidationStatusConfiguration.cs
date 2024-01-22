using InteractiveMapProject.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations;

public class ValidationStatusConfiguration : IEntityTypeConfiguration<ValidationStatus>
{
    public void Configure(EntityTypeBuilder<ValidationStatus> builder)
    {
        builder.ToTable("ValidationStatuses");

        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Professionals)
            .WithOne(p => p.ValidationStatus)
            .HasForeignKey(p => p.ValidationStatusId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(p => p.PendingProfessionals)
            .WithOne(p => p.ValidationStatus)
            .HasForeignKey(p => p.ValidationStatusId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
            new ValidationStatus(Guid.NewGuid(), "Approved"),
            new ValidationStatus(Guid.NewGuid(), "Waiting After Creation"),
            new ValidationStatus(Guid.NewGuid(), "Waiting After Update")
        );
    }
}
