using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class
    PendingProfessionalPlaceOfInterventionConfiguration : IEntityTypeConfiguration<
        PendingProfessionalPlaceOfIntervention>
{
    public void Configure(EntityTypeBuilder<PendingProfessionalPlaceOfIntervention> builder)
    {
        builder.ToTable("PendingProfessionalsPlacesOfIntervention");

        builder
            .HasKey(pa =>
                new { PendingProfessionalId = pa.PendingProfessionalId, MissionId = pa.PlaceOfInterventionId });

        builder
            .HasOne(pb => pb.PendingProfessional)
            .WithMany(p => p.PlacesOfIntervention)
            .HasForeignKey("PendingProfessionalId");

        builder
            .HasOne(pb => pb.PlaceOfIntervention)
            .WithMany(b => b.PendingProfessionals)
            .HasForeignKey("PlaceOfInterventionId");
    }
}
