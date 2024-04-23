using InteractiveMapProject.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations;

public class ValidationStatusConfiguration : IEntityTypeConfiguration<ValidationStatus>
{
    public void Configure(EntityTypeBuilder<ValidationStatus> builder)
    {
        builder.ToTable("ValidationStatuses");

        builder.HasKey(vs => vs.Id);

        builder
            .HasMany(vs => vs.Professionals)
            .WithOne(p => p.ValidationStatus)
            .HasForeignKey(p => p.ValidationStatusId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(vs => vs.PendingProfessionals)
            .WithOne(p => p.ValidationStatus)
            .HasForeignKey(p => p.ValidationStatusId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(
            new ValidationStatus(Guid.NewGuid(), "Approved"),
            new ValidationStatus(Guid.NewGuid(), "Waiting After Creation"),
            new ValidationStatus(Guid.NewGuid(), "Waiting After Update")
        );
    }
}
